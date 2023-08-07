using FormApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicantRepository _applicantRepository;

        public HomeController(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create([FromRoute] int id)
        {
            var applicant = _applicantRepository.GetApplicant(id);
            return View(applicant);
        }

        [HttpPost]
        public IActionResult Create(Applicant model)
        {
            if (ModelState.IsValid)
            {
                Applicant newApplicant = new Applicant
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department
                };

                var applicant = _applicantRepository.CreateApplicant(newApplicant);
                return RedirectToAction("Create", new { applicant.Id });
            }
            return View();
        }
    }
}
