using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PokedexClient.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexClient.Controllers
{
  public class UsersController : Controller
  {

    //[Route("users/index/{id}")]
    public IActionResult Index(int id)
    {
      var thisUser = User.GetUsers(id);
      return View(thisUser);
    }


  }
}