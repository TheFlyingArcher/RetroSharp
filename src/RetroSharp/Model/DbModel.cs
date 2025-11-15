using System.ComponentModel.DataAnnotations;

namespace RetroSharp.Model;

public abstract class DbModel
{
    /// <summary>
    /// Get or set the primary key of the record
    ///
    /// NOTE: This should not be set individually but by the underlying datastore
    /// </summary>
    [Key]
    public int Id { get; set; }
    
    /// <summary>
    /// Get or set whether the record is considered active and in use
    /// </summary>
    [Required]
    public bool Active { get; set; }
    
    /// <summary>
    /// Get or set who created the record
    /// </summary>
    [Required]
    public string CreatedBy { get; set; } = string.Empty;

    /// <summary>
    /// Get or set when the record was created
    /// </summary>
    [Required]
    public DateTime CreatedAt { get; set; }
    
    public string ModifiedBy { get; set; } = string.Empty;

    public DateTime ModifiedAt { get; set; }
}