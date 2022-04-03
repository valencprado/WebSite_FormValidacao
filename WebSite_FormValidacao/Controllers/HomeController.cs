using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_FormValidacao.Models;

namespace WebSite_FormValidacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Questionario()
        {
            return View();
        }
        public ActionResult Obrigado() 
        {

            return View();
       }
        [HttpPost]
        public ActionResult Questionario(QuestionarioModel resposta)
        {
            try
            {
                return RedirectToAction("Obrigado");
            }
            catch
            {
                return View();

            }
        }
    }
}