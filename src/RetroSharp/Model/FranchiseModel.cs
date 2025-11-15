using System.ComponentModel.DataAnnotations;

namespace RetroSharp.Model;

public class FranchiseModel : DbModel
{
    [Required]
    public string FranchiseCode { get; set; } = String.Empty;
    
    public string? Leagues { get; set; }
    
    [Required]
    public string City { get; set; } = string.Empty;
    
    public string TeamName { get; set; } = string.Empty;
    
    [Required]
    public short FirstYear { get; set; }
    
    public short? LastYear { get; set; }
    
    [Required]
    public bool Extant { get; set; }
}