using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DeckOfCardsAPI.Models;

namespace DeckOfCardsAPI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult DeckOfCards()
    {
       ReshuffleDeckModel result = ReshuffleDeckDAL.Reshuffle();
        return View(result);
        
    }

    public IActionResult Result()
    {
        DrawFiveModel result = DrawFiveDAL.UserDrawFive();
        return View(result);
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

