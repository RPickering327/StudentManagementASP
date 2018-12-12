using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.ViewModels;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginViewModel loginViewModel)
        {

            //If the login details are valid
            if (ModelState.IsValid)
            {
                //Create a new user
                var user = new IdentityUser()
                { UserName = loginViewModel.UserName };

                var result =
                    await _userManager.CreateAsync
                    (user, loginViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(loginViewModel);

        }




        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {

            //Check if the data is valid from the view model.
            if (!ModelState.IsValid)
            {

                return View(loginViewModel);
            }

            //Search if we have a user with the name provided from the login view model.
            var user = await
                _userManager.FindByNameAsync(loginViewModel.UserName);


            //If it returns a user then try to sign in the user
            if (user != null)
            {

                var result = await
                    _signInManager.PasswordSignInAsync
                        (user, loginViewModel.Password, false, false);


                //If it works redirect the user to the home page.
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

            }

            ModelState.AddModelError("", "User name or password was not found in the database.");
            return View(loginViewModel);

        }



        [HttpPost]
        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }
    }
}
