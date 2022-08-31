using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class PepeController : ControllerBase
{
    private readonly PepeHubDbContext _context = new PepeHubDbContext();

    [HttpPost(Name = "NewPepe")]
    public async Task<ActionResult<Pepe>> AddNewPepe(Pepe pepe)
    {
        User user = _context.Users.Find(1)!;
        pepe.User = user;

        await _context.Pepes.AddAsync(pepe);

        return Ok(pepe);
    }

    [HttpGet("{id:int}", Name = "Get Pepe")]
    public ActionResult<Pepe> GetPepe(int Id)
    {
        Pepe pepe = _context.Pepes.Find(Id)!;
        if (pepe == null) return NotFound();

        return Ok(pepe);
    }
}