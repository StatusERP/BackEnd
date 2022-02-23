using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StatusERP.DataAccess;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Dto.Response.ERPADMIN;
using StatusERP.Entities;
using StatusERP.Services.Interfaces.ERPADMIN;

namespace StatusERP.Services.Implementations.ERPADMIN
{
    public class UserService : IUserService
    {
        private readonly UserManager<StatusERPUserIdentity> _userManager;
        private readonly ILogger<UserService> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(UserManager<StatusERPUserIdentity> userManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<UserService> logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        public async Task<DtoLoginResponse> LoginAsync(DtoLogin request)
        {
            throw new NotImplementedException();
            
            

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
    }
}
