using System.ComponentModel.DataAnnotations;

namespace RetroSharp.Model;

public class PlayerModel : DbModel
{
    [Required]
    public int Season { get; set; }
    
    public short GamesPlayed { get; set; }
    
    public short GamesStarted { get; set; }
    
    public short PlateAppearances { get; set; }
    
    public short AtBats { get; set; }
    
    [Required]
    public int PersonId { get; set; }
    
    public PersonModel Person { get; set; }
    
    public int FranchiseId { get; set; }
    
    public FranchiseModel Franchise { get; set; }
}