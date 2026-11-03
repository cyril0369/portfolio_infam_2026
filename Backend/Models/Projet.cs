using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models;

[Table("projet")]
public class Projet
{
    [Column("id")] public int Id { get; set; }
    [Column("titre")] public string Titre { get; set; } = string.Empty;
    [Column("sous_titre")] public string? SousTitre { get; set; }
    [Column("description")] public string? Description { get; set; }
    [Column("categorie")] public string? Categorie { get; set; }
    [Column("images")] public string[] Images { get; set; } = Array.Empty<string>();
    [Column("videos")] public string[] Videos { get; set; } = Array.Empty<string>();
}