using System.ComponentModel.DataAnnotations;

namespace RetroSharp.Model;

public sealed class PersonModel : DbModel
{
    [Required]
    public string PersonId { get; set; } = string.Empty;
    
    [Required]
    public string LastName { get; set; } = string.Empty;
    
    [StringLength(64)]
    public string? FirstMiddleName { get; set; }
    
    [StringLength(32)]
    public string? Nickname { get; set; }
    
    public DateTime? BirthDate { get; set; }
    
    [StringLength(64)]
    public string? BirthCity { get; set; }
    
    [StringLength(32)]
    public string? BirthState { get; set; }
    
    [StringLength(64)]
    public string? BirthCountry { get; set; }
    
    public DateTime? PlayerDebut { get; set; }
    
    public DateTime? PlayerLastGame { get; set; }
    
    public DateTime? ManagerDebut { get; set; }
    
    public DateTime? ManagerLastGame { get; set; }
    
    public DateTime? CoachDebut { get; set; }
    
    public DateTime? CoachLastGame { get; set; }
    
    public DateTime? UmpireDebut { get; set; }
    
    public DateTime? UmpireLastGame { get; set; }
    
    public DateTime? DeathDate { get; set; }
    
    [StringLength(64)]
    public string? DeathCity { get; set; }

    [StringLength(32)]
    public string? DeathState { get; set; }
    
    [StringLength(64)]
    public string? DeathCountry { get; set; }
    
    [StringLength(4)]
    public string? Bats { get; set; }
    
    [StringLength(4)]
    public string? Throws { get; set; }
    
    [StringLength(8)]
    public string? Height { get; set; }
    
    [StringLength(8)]
    public string? Weight { get; set; }
    
    [StringLength(64)]
    public string? Cemetery { get; set; }
    
    [StringLength(64)]
    public string? CemetaryCity { get; set; }
    
    [StringLength(32)]
    public string? CemetaryState { get; set; }
    
    [StringLength(32)]
    public string? CemetaryCountry { get; set; }
    
    [StringLength(128)]
    public string? CemetaryNote { get; set; }
    
    [StringLength(32)]
    public string? BirthName { get; set; }
    
    public DateTime? NameChange { get; set; }
    
    public DateTime? BattingChange { get; set; }
    
    public bool HallOfFame { get; set; }    
}