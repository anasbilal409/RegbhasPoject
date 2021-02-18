using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.IO;
using Regbhas.Models;
using Regbhas.Models.UserMgt;
using HomeDecor.Common;

namespace Regbhas.Controllers
{
    public class UserController:Controller
    {

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult UserLogin(LoginModel model)
        //{
        //    UsersHandler usersHandler = new UsersHandler();
        //    Userregistration currentUser = usersHandler.GetUsers(model.LoginId, model.Password);
        //    if (currentUser != null)
        //    {
        //        HttpContext.Session.Set<Userregistration>(WebUtil.CURRENT_USER, currentUser);

        //        if (currentUser.Role.Id == WebUtil.ADMIN_ROLE)
        //        {
        //            return RedirectToAction("AdminIndex", "Admin");
        //        }

        //        else if (currentUser.Role.Id == WebUtil.USER_ROLE)
        //        {
        //            return RedirectToAction("Index", "Home");
        //        }

        //        else
        //        {
        //            return RedirectToAction("UserLogin", "User");
        //        }
        //    }
        //    return View();
        //}


        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            //TempData.Add()
            return RedirectToAction("Index", "Home");
        }
    }
}
