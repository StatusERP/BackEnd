﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Implementations.AS;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.API.Controllers.AS;
[ApiController]
[Route("api/AS/[controller]")]
[Authorize]
public class UsuarioBodegaController : Controller
{
    private readonly IUsuarioBodegaService _service;
    private readonly ILogger<UsuarioBodegaService> _logger;

    public UsuarioBodegaController(IUsuarioBodegaService service,ILogger<UsuarioBodegaService> logger)
    {
        _service = service;
        _logger = logger;
    }
    [HttpGet]
    public async Task<ActionResult<BaseResponseGeneric<ICollection<UsuarioBodega>>>> Get(int page, int rows)
    {
        return Ok(await _service.GetAsync(page, rows));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<UsuarioBodega>>> Get(int id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Post(DtoUsuarioBodega request)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        if (userId == null) return Unauthorized();
        var response = await _service.CreateAsync(request, userId.Value, request.BodegaId);
        HttpContext.Response.Headers.Add("location",$"/api/AS/usuarioBodega/{response.Result}");
        return Ok(response);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, DtoUsuarioBodega request)
    {
        var userId=HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        var response =await _service.UpdateAsync(id, request,userId.Value);
        return Ok(new {response});
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<BaseResponseGeneric<int>>> Delete(int id)
    {
        var userId=HttpContext.User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);
        var response = await _service.DeleteAsync(id,userId.Value);
        return Ok(response);
           
    }
}