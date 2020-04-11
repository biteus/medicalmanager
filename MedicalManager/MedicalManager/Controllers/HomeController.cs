using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MedicalManager.Models;

namespace MedicalManager.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {

        private readonly IMedicationRepository _handlerMedicationRepository;

        public HomeController(IMedicationRepository medicationRepository)
        {
            _handlerMedicationRepository = medicationRepository;
        }

       
        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create(Medication medication)
        {
            if (ModelState.IsValid)
            {
                Medication medicationAdded = _handlerMedicationRepository.AddMedication(medication);
                return RedirectToAction("details", new { id = medicationAdded.Id });
            }

            return View();
        }

        [Route("Details")]
        public IActionResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel
            {
                Medication = _handlerMedicationRepository.GetMedication(id ?? 1),
                Title = "Medication Details"
            };
            return View(homeDetailsViewModel);
        }

        [Route("Delete")]
        public IActionResult Delete(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel
            {
                Medication = _handlerMedicationRepository.DeleteMedication(id ?? 1),
                Title = "Medication Delete"
            };
            return View(homeDetailsViewModel);
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var model = _handlerMedicationRepository.GetAllMedication();
            return View(model);
        }

        [Route("About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
}
