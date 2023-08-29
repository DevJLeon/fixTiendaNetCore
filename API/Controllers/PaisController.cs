using System.Net;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using API.Controllers;

namespace API.Controller;
public class PaisController : BaseApiController
{
    private readonly IUnitOfWork unitOfWork;

    private readonly IMapper mapper;

    public PaisController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<PaisDtos>>> Get()
    {
        var pais = await unitOfWork.Paises.GetAllAsync();
        return mapper.Map<List<PaisDtos>>(pais);
    }
}
