using System.ComponentModel.DataAnnotations;

namespace Backend.Dtos;

public class ProjetDto
{

    [Required, MaxLength(200)]
    public string Titre { get; set; } = string.Empty;

    [MaxLength(300)]
    public string? SousTitre { get; set; }

    public string? Description { get; set; }

    [MaxLength(100)]
    public string? Categorie { get; set; }

    public string[] Images { get; set; } = Array.Empty<string>();

    public string[] Videos { get; set; } = Array.Empty<string>();
}