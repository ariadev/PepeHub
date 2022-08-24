using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Avatar { get; set; }
    [Required]
    public string Bio { get; set; }
    public List<Pepe> Pepes { get; set; }
}