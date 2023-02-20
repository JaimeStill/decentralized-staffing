using Enterprise.Data;
using Enterprise.Models.Entities;
using Enterprise.Services;
using Microsoft.AspNetCore.Mvc;
using Soc.Api.Controllers;

namespace Enterprise.Api.Controllers;

[Route("api/[controller]")]
public class OrganizationController : EntityController<Organization, AppDbContext>
{
    public OrganizationController(OrganizationService svc)
        : base (svc) { }

    [HttpGet("[action]/{message?}")]
    public IActionResult GenerateException([FromRoute]string message = "An exception occurred") =>
        Ok(OrganizationService.GenerateException(message));
}