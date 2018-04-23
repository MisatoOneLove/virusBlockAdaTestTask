using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using BusinessLogic.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using virusBlockadaTestTask.Assemblers;
using virusBlockadaTestTask.ViewModels;

namespace virusBlockadaTestTask.Controllers
{
    public class AccountController : Controller
    {
        private IUserService UserService => HttpContext.GetOwinContext().GetUserManager<IUserService>();

        private IAuthenticationManager AuthenticationManager => HttpContext.GetOwinContext().Authentication;

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userModel = UserViewModelAssembler.FromViewModelToModel(user);
                ClaimsIdentity claim = await UserService.Authenticate(userModel);
                if (claim == null)
                {
                    ModelState.AddModelError("", "Неверный логин или пароль.");
                }
                else
                {
                    AuthenticationManager.SignOut();
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(user);
        }

        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userModel = UserViewModelAssembler.FromViewModelToModel(user);
                OperationDetails operationDetails = await UserService.Create(userModel);
                if (operationDetails.Succedeed)
                {
                    TempData["Sucess"]="Регистрация прошла успешно";
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError(operationDetails.Property, operationDetails.Message);
            }
            return View(user);
        }
    }
}