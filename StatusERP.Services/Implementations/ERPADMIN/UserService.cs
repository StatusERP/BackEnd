﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StatusERP.DataAccess;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Dto.Response.ERPADMIN;
using StatusERP.Entities;
using StatusERP.Services.Interfaces.ERPADMIN;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;

namespace StatusERP.Services.Implementations.ERPADMIN
{
    public class UserService : IUserService
    {
        private readonly UserManager<StatusERPUserIdentity> _userManager;
        private readonly ILogger<UserService> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IOptions<AppSettings> _options;

        

        public UserService(UserManager<StatusERPUserIdentity> userManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<UserService> logger,
            IOptions<AppSettings> options
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _options = options;
        }

        public async Task<DtoLoginResponse> LoginAsync(DtoLogin request)
        {
            var response = new DtoLoginResponse();
            var identity = await _userManager.FindByEmailAsync(request.Email);
            if (identity == null)
            {
                response.Success = false;
                response.Errors.Add("El Correo no Existe");
                return response;
            }

            if(!await _userManager.CheckPasswordAsync(identity, request.Password))
            {
                response.Errors.Add("Clave Incorrecta");
                return response;
            }

            var expiredDate = DateTime.Now.AddHours(1);
            response.FullName = $"{identity.Firstname} {identity.Lastname}";

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, response.FullName),
                new Claim(ClaimTypes.Email,identity.Email),
                new Claim(ClaimTypes.Sid,identity.Id)
            };

            var roles = await _userManager.GetRolesAsync(identity);
            response.Roles = new List<string>();
            foreach (var role in roles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, role));
                response.Roles.Add(role);
            }

            var llavesimetrica = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Value.Jwt.Signinkey));
            var credentials = new SigningCredentials(llavesimetrica, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(credentials);
            var payload = new JwtPayload(
                issuer: _options.Value.Jwt.Issuer,
                audience: _options.Value.Jwt.Audience,
                claims: authClaims,
                notBefore: DateTime.Now,
                expires: expiredDate);

            var token = new JwtSecurityToken(header, payload);
            response.Token = new JwtSecurityTokenHandler().WriteToken(token);
            response.Success = true;
            return response;

        }

        public async Task<BaseResponseGeneric<string>> RegisterAsync(DtoRegisterUser request)
        {
            var response =new BaseResponseGeneric<string>();
            try
            {
                var result = await _userManager.CreateAsync(new StatusERPUserIdentity
                {
                    Firstname = request.Firstname,
                    Lastname = request.LastName,
                    Email = request.email,
                    Age = request.Age,
                    TypeDocument = request.TypeDocument,
                    DocumentNumber = request.DocumentoNumber,
                    UserName = request.email
                }, request.Password);
                if (!result.Succeeded)
                {
                    response.Errors=result.Errors
                        .Select(p=> p.Description)
                        .ToList();
                    response.Success=false;
                    return response;
                }

                var userIdentity = await _userManager.FindByEmailAsync(request.email);
                if (userIdentity != null)
                {
                    if (!await _roleManager.RoleExistsAsync(Constants.RoleAdministrador))
                        await _roleManager.CreateAsync(new IdentityRole(Constants.RoleAdministrador));
                    if (!await _roleManager.RoleExistsAsync(Constants.RoleCustomer))
                        await _roleManager.CreateAsync(new IdentityRole(Constants.RoleCustomer));
                   if( await _userManager.Users.CountAsync() == 1)
                    {
                        await _userManager.AddToRoleAsync(userIdentity,Constants.RoleAdministrador);
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(userIdentity, Constants.RoleCustomer);
                    }
                    response.Result = userIdentity.Id;
                }
                response.Success = result.Succeeded;
                

            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Errors.Add(ex.Message);
                _logger.LogCritical(ex.Message);
            }
            return response;
        }

        public async Task<BaseResponseGeneric<string>> SendTokenToResetPasswordAsnc(DtoResetPasssword request)
        {
            var response = new BaseResponseGeneric<string>();
            try
            {
                var userIdentity = await _userManager.FindByEmailAsync(request.Email);
                if (userIdentity == null)
                {
                    response.Success = false;
                    response.Errors.Add($"El Correo {request.Email} no existe");
                    return response;
                }
                var token = await _userManager.GeneratePasswordResetTokenAsync(userIdentity);
                //TODO: Enviar un correo electronico al usuario con el token generado

                var mail = new MailMessage(
                        new MailAddress(_options.Value.MailConfiguration.FromAddress,
                        _options.Value.MailConfiguration.FromName),
                        new MailAddress(userIdentity.Email));
                mail.Subject = "Reseteo de Contrasena";
                mail.Body = $"Se le envia su cuenta con el token generado , apuntelo\n<b>{token}</b>\n Que Tenga un buen dia";
                mail.IsBodyHtml = true;
                var smtpClient = new SmtpClient(_options.Value.MailConfiguration.SmtpServer,
                    _options.Value.MailConfiguration.Port);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(_options.Value.MailConfiguration.UserName,
                    _options.Value.MailConfiguration.Password);
                await smtpClient.SendMailAsync(mail);


                response.Result = token;
                response.Success = true;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                throw;
            }
            return response;
        }
        public async Task<BaseResponseGeneric<string>> ResetPassword(DtoConfirmReset request)
        {
            var response = new BaseResponseGeneric<string>();
            try
            {
                var userIdentity = await _userManager.FindByEmailAsync(request.Email);
                if (userIdentity == null)
                {
                    response.Success = false;
                    response.Errors.Add($"El correo {request.Email} no existe");
                    return response;
                }
                var identity = await _userManager.ResetPasswordAsync(userIdentity, request.Token, request.Password);

                response.Result = userIdentity.Email;
                response.Success = identity.Succeeded;
                response.Errors = identity.Errors
                    .Select(p => p.Description)
                    .ToList();
            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Errors.Add(ex.Message);

            }
            return response;
        }

        public async Task<BaseResponse> ChangePassword(DtoChangePassword request)
        {
            var response = new BaseResponse();

            try
            {
                var userIdentity = await _userManager.FindByEmailAsync(request.Email);
                if (userIdentity == null)
                {
                    response.Success = false;
                    response.Errors.Add($"El correo {request.Email} no existe");
                    return response;
                }
                var identity = await _userManager.ChangePasswordAsync(userIdentity, request.OldPassword, request.NewPassword);
                response.Success = identity.Succeeded;
                response.Errors = identity.Errors
                    .Select(p => p.Description)
                    .ToList();
            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Errors.Add(ex.Message);
            }

            return response;
        }
    }
}
