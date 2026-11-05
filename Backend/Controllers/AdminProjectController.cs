using Backend.Data;
using Backend.Dtos;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    public async Task<ActionResult<Projet>> CreateProjet(ProjetDto dto)
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

    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Projet>> UpdateProjet(int id, ProjetDto dto)
    {
        var projet = await _db.Projets.FirstOrDefaultAsync(p => p.Id == id);

        if (projet == null)
            return NotFound();

        projet.Titre = dto.Titre;
        projet.SousTitre = dto.SousTitre;
        projet.Description = dto.Description;
        projet.Categorie = dto.Categorie;
        projet.Images = dto.Images;
        projet.Videos = dto.Videos;

        await _db.SaveChangesAsync();

        return Ok(projet);
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Projet>> DeleteProjet(int id)
    {
        var projet = await _db.Projets.FindAsync(id);

        if (projet is null)
            return NotFound();

        _db.Projets.Remove(projet);
        await _db.SaveChangesAsync();

        return NoContent();
    }

}