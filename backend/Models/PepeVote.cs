using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models;

public class PepeVote
{
    [Key]
    public int Id {get; set;}
    public Vote Vote { get; set; }

    [ForeignKey("Pepe")]
    public int PepeId { get; set; }
    public virtual Pepe Pepe { get; set; }
    [Required]
    public int UserId { get; set; }
}

public enum Vote { Down, Up };
