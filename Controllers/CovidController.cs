using System;
using Microsoft.AspNetCore.Mvc;
using web_api_app_test.Extensions;
using web_api_app_test.Models;

namespace web_api_app_test.Controllers
{
   //[Route("vaccine/cert/verify/76f38cfc-0d91-4288-bec0-006c442a43e1/[controller]/[action]")]
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
                VaccineNumber = _rand.Next(100000000),
                DefaultVaccineNumber = "9470000058260899"
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
                VaccineNumber = _rand.Next(100000000),
                DefaultVaccineNumber = "9470000058260899"
            };

            return View("Index", _model);
            
        }

        [Route("vaccine/cert/verify/{guid}")]
        public IActionResult IndexFromGuid(Guid guid)
        {
            _model = guid.ToString() switch
            {
                "eac9ddbd-f2e4-458e-8c64-d4d8fdd2b380" => CovidExtensions.Model1,
                "2e26f9d1-7c12-40e3-b7c5-e39c499d0efe" => CovidExtensions.Model2,
                "c0a38c73-5570-422a-91ee-d41604542d33" => CovidExtensions.Model3,
                "fcc9b1c9-2cf7-41af-8105-555f4576d65e" => CovidExtensions.Model4,
                "e36dd104-5bdb-49de-ac40-f63391e22f71" => CovidExtensions.Model5,
                _ => CovidExtensions.Model1
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