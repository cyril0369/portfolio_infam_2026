using Backend.Data;
using Backend.Dtos;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("api/projets")]

public class AdminProjetController : ControllerBase
{
    private readonly AppDbContext _db;

    public AdminProjetController(AppDbContext db)
    {
        _db = db;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Projet>> CreateProjet(ProjetCreateDto dto)
    {
        var projet = new Projet
        {
            Titre = dto.Titre,
            SousTitre = dto.SousTitre,
            Description = dto.Description,
            Categorie = dto.Categorie,
            Images = dto.Images,
            Videos = dto.Videos
        };

        _db.Projets.Add(projet);
        await _db.SaveChangesAsync();

        return CreatedAtAction(nameof(ProjectController.GetProjet), new { id = projet.Id }, projet);
    }
}