using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private PokedexContext _db;

    public UsersController(PokedexContext db)
    {
      _db = db;
    }

    // GET api/users
    [HttpGet]
    public ActionResult<IEnumerable<User>> Get()
    {
      return _db.Users.ToList();
    }

    // POST api/users
    [HttpPost]
    public void Post([FromBody] User user)
    {
      _db.Users.Add(user);
      _db.SaveChanges();
    }

    // GET api/users/{id}
    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
      return _db.Users.FirstOrDefault(entry => entry.UserId == id);
    }
    
    // PUT api/users/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] User user)
    {
      user.UserId = id;
      _db.Entry(user).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/users/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var userToDelete = _db.Users.FirstOrDefault(entry => entry.UserId ==id);
      _db.Users.Remove(userToDelete);
      _db.SaveChanges();
    }
  }
}