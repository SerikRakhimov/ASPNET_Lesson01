﻿using InternetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetShop.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Users()
        {
            using (var context = new Context())
            {
                ViewBag.Users = context.Users.ToList();
            }

            return View();
        }
        public new ActionResult User(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var context = new Context())
            {
                var user = context.Users.FirstOrDefault(p => p.Id == id);
                if (user == null)
                {
                    return HttpNotFound();
                }

                ViewBag.User = user;
            }

            return View();
        }

    }
}