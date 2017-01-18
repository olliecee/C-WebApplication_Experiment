using System.Linq;
using CourseProjectApp.Models;
using CourseProjectApp.Repository;
using CourseProjectApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseProjectApp.Controllers
{
    public class LoggedInController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProfileRepository _profileRepository;

        public LoggedInController(UserManager<ApplicationUser> userManager, IProfileRepository profileRepository)
        {
            _userManager = userManager;
            _profileRepository = profileRepository;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);

            var hobbies = _profileRepository.GetHobbyList(userId);

            var individual = _profileRepository.GetIndividualList(userId);

            var organization = _profileRepository.GetOrganizationList(userId);

            var model = new DashboardViewModel
            {
                Individuals = individual,
                Organization = organization,
                Hobby = hobbies

            };

            return View(model);
        }

    }
}
