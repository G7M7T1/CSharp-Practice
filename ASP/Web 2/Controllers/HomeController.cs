using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPAPP.Models;

namespace ASPAPP.Controllers;

public class HomeController : Controller
{
    private static List<HotelBookingModel> BookLists = new List<HotelBookingModel>();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Booking()
    {
        var book = new HotelBookingModel();
        return View(book);
    }
    
    public IActionResult MakeBook(HotelBookingModel hotelBookingModel)
    {
        BookLists.Add(hotelBookingModel);
        return RedirectToAction(nameof(BookingList));
    }

    public IActionResult BookingList()
    {
        return View(BookLists);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}