using Cadeteria.Authorization;
using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cadeteria;

[Authorize]
[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase
{
    private readonly IProfileRepository _dbProfile;
    private readonly DataContext _db;
    private readonly ILogger<ProfileController> _logger;


    public ProfileController(ILogger<ProfileController> logger, DataContext db, IProfileRepository Profile)
    {
        _dbProfile = Profile;
        _db = db;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_dbProfile.Get());

    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var response = _db.Users.Join(_db.Profile, u => u.Id, p => p.userForeiKey,
        (u, p) => new { u.userName, p.userForeiKey, p.id, p.Nombre, p.Direccion, p.Telefono, p.Referencia })
        .Where(x => x.userForeiKey == id).FirstOrDefault();
        return Ok(response);
    }
    [HttpPost]
    public IActionResult Post([FromBody] Profile Profile)
    {
        _dbProfile.Save(Profile);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Profile Profile)
    {
        _dbProfile.Update(id, Profile);
        _dbProfile.Save(Profile);
        return Ok();
    }

}
