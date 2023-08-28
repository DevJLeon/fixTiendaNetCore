using System.Net;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller;
public class RegionController : BaseApiController
{
    private readonly IUnitOfWork unitOfWork;

    public RegionController(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Region>>> Get()
    {
        var regiones = await unitOfWork.Regiones.GetAllAsync();
        return Ok(regiones);
    }

    [HttpGet]
}
