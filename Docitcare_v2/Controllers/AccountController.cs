using Docitcare_v2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Docitcare_v2.Core.Domain;
using System.Web.Security;


namespace Docitcare_v2.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Account
        //[Route("{id?}")]

        public ActionResult Login(string id)
        
        {
            return View();
        }
        [HttpPost]
        //[Route("Login/{id?}")]
        public ActionResult Login(UltraUsers UserCredentials, string returnUrl)
        {
            var isValid = _unitOfWork.UltraUser.ValidateCredentails(UserCredentials);
            if (isValid != null)
            {
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    FormsAuthentication.SetAuthCookie(isValid.UserName, false);
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Entity", new { area = "UltraAdmin" });
                }
            }
            ModelState.AddModelError("", "Invalid Credentials");
            return View();

        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Response.Cookies[0].Expires.AddDays(-1);
            Session.Abandon();//Abandon session
            string url = "https://" + Request.Url.Authority + "/Login/Lotushospitals";
            return Redirect(url);
        }
    }
}