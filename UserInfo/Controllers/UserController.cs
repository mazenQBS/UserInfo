using Microsoft.AspNetCore.Mvc;
using Registry.Data.Repository;
using UserInfo.Models;

namespace UserInfo.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult CreatUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatUser(User user)
        {
            _userRepository.Create(user);
            return View(user);
        }
    }
}

