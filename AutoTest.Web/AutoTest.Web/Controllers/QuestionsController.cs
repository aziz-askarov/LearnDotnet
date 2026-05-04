using AutoTest.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AutoTest.Web.Controllers;

public class QuestionsController : Controller
{
    private readonly List<QuestionModel>? _questions;
    public QuestionsController()
    {

        var path = Path.Combine("JsonData", "uzkiril.json");
        var json = System.IO.File.ReadAllText(path);

        _questions = JsonConvert.DeserializeObject<List<QuestionModel>>(json);
    }

    public IActionResult Index()
    {
        ViewBag.Questions = _questions;

        return View();
    }

    public IActionResult QuestionGetById(int id,int? choiceIndex = null)
    {
        var question = _questions?.FirstOrDefault(q => q.Id == id);

        if (question == null)
        {
            ViewBag.IsSuccess = false;
            ViewBag.QuestionId = id;
        }
        else
        {
            ViewBag.IsSuccess = true;
            ViewBag.Question = question;

            
            
        }

        return View();
    }
}
