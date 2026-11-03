using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

[ApiController]
[Route("api/projets")]
public class ProjectController : ControllerBase
{
    private readonly AppDbContext _db;

    public ProjectController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Projet>>> GetProjets()
    {
        var projet = await _db.Projets
            .AsNoTracking()
            .OrderBy(p => p.Id)
            .ToListAsync();

        return Ok(projet);
    }
}
