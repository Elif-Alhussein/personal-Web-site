﻿using KisiselWebSite.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSite.Controllers
{
    public class LoginController1 : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.kullaniciAdi == ad.kullaniciAdi && x.sifre == ad.sifre);
            if (bilgiler != null)
            {
                /*FormsAuthentication.SetAuthCookie(bilgiler.kullaniciAdi, false);
                Session["kullaniciAdi"] = bilgiler.kullaniciAdi.ToString();*/
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}
