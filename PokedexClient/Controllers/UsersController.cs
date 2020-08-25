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
    public IActionResult Details(int id)
    {
      var thisUser = User.GetUsers(id);
      return View(thisUser);
    }
    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(User user)
    {
      User.Post(user);
      return RedirectToAction("Details");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
      User user = User.GetDetails(id);
      return View(user);
    }

    [HttpPost]
    public IActionResult Update(User user)
    {
      User.Put(user);
      return RedirectToAction("Details");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
      User user = User.GetDetails(id);
      return View(user);
    }

    [HttpPost]
    public ActionResult Delete(User user)
    {
      return RedirectToAction("Index", "Pokemon");
    }

  }
}