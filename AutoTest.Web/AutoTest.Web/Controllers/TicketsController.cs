using AutoTest.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AutoTest.Web.Controllers;

public class TicketsController : Controller
{
    private readonly List<QuestionModel>? _questions;
    public TicketsController()
    {

        var path = Path.Combine("JsonData", "uzkiril.json");
        var json = System.IO.File.ReadAllText(path);

        _questions = JsonConvert.DeserializeObject<List<QuestionModel>>(json);
    }

    public IActionResult Index()
    {
        ViewBag.TicketCount = _questions?.Count / 20;
        return View();
    }
}