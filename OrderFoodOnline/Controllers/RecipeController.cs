﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrderFoodOnline.Models;

namespace OrderFoodOnline.Controllers
{
  public class RecipeController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;

    public RecipeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
      _userManager = userManager;
    }
    public IActionResult Index()
    {
      return View();
    }
    [HttpPost]
    public IActionResult GetRecipeCard([FromBody] List<Recipe> recipes)
    {
      return PartialView("_RecipeCard", recipes);
    }
    public IActionResult Search([FromQuery] string recipe)
    {
      ViewBag.Recipe = recipe;
      return View();
    }
    public IActionResult Order([FromQuery] string id)
    {
      ViewBag.Id = id;
      //var user = await _userManager.GetUserAsync(HttpContext.User);
      //ViewBag.UserId = user?.Id;
      //ViewBag.Address = user?.Address;
      return View();
    }
    [HttpPost]
    public async Task<IActionResult> ShowOrder(OrderRecipeDetails orderRecipeDetails)
    {
      Random random = new Random();
      ViewBag.Price = Math.Round(random.Next(150, 500) / 5.0) * 5;

      var user = await _userManager.GetUserAsync(HttpContext.User);
      ViewBag.UserId = user?.Id;
      ViewBag.Address = user?.Address;

      return PartialView("_ShowOrder", orderRecipeDetails);
    }
  }
}
