using System;
using Microsoft.AspNetCore.Mvc;
using web_api_app_test.Models;

namespace web_api_app_test.Controllers
{
    [Route("vaccine/cert/verify/76f38cfc-0d91-4288-bec0-006c442a43e1/[controller]/[action]")]
    public class CovidController : Controller
    {
        private static CovidBindingModel _model;

        private static Random _rand = new Random();
        // GET
        public IActionResult Index(string lang = "ru")
        {
            _model = new CovidBindingModel
            {
                Language = lang,
                FirstName = "Тестов",
                SecondName = "Тест",
                ThirdName = "Тестович",
                DateOfBirth = DateTime.Now.AddYears(-20),
                PassportNumber = 1234567890,
                CertNumber = 94700000,
                VaccineNumber = _rand.Next(100000000)
            };

            return View(_model);
        }

        public IActionResult IndexFromParams(string firstName, string secondName, string thirdName, DateTime dateOfBirth, long passportNumber)
        {
            _model = new CovidBindingModel
            {
                Language = "ru",
                FirstName = firstName,
                SecondName = secondName,
                ThirdName = thirdName,
                DateOfBirth = dateOfBirth,
                PassportNumber = passportNumber,
                CertNumber = 94700000,
                VaccineNumber = _rand.Next(100000000)
            };

            return View("Index", _model);
            
        }
        

        public IActionResult FromNumber(string lang)
        {
            _model.Language = lang;
            return View("Index", _model);
        }

        public IActionResult Eng()
        {
            _model.Language = "ru";
            return RedirectToAction("FromNumber", new { lang = "ru" });
        }

        public IActionResult Rus()
        {
            _model.Language = "en";
            return RedirectToAction("FromNumber", new { lang = "en" });
        }
    }
}