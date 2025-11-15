using System.ComponentModel.DataAnnotations;

namespace RetroSharp.Model;

public class GameModel : DbModel
{
    [Required]
    public string GameId { get; set; } = string.Empty;
    
    [Required]
    public DateTime GameDate { get; set; }
    
    [Required]
    public bool DesignatedHitterUsed { get; set; }
    
    public short? GameLengthMinutes { get; set; }
    
    public int? Attendance { get; set; }
    
    [Required]
    public byte InningsPlayed { get; set; }
    
    [Required]
    public string AwayFranchiseId { get; set; }
    
    [Required]
    public string HomeFranchiseId { get; set; }
}