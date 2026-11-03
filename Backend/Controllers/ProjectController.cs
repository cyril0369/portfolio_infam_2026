using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("/project")]
public class ProjectController : ControllerBase
{
    [HttpGet]
    public string GetProject()
    {
        return "la liste des projet";
    }
}