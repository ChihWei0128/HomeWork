﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeWork.Models.ViewModels;

namespace HomeWork.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel pageData)
        {
            if (ModelState.IsValid)
            {
                pageData.Message = $"您使用{pageData.Account}登入成功。";
            }
            return View(pageData);
        }
    }
}