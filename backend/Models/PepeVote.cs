using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class PepeVote
{
    [Key]
    public int Id {get; set;}
    public Vote Vote { get; set; }

    public int UserId { get; set; } 
    public User User { get; set; }

    public int PepeId { get; set; }
    public Pepe Pepe { get; set; }
}

public enum Vote { Down, Up };
