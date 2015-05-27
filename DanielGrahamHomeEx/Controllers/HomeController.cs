using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using DanielGrahamHomeEx.Models;

namespace DanielGrahamHomeEx.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignupSuccess()
        {
            return View();
        }

        //prefer to bring in the web api nuget package and use IHttpActionResults here
        [HttpPost]
        public JsonResult PostSignup(SignupViewModel model)
        {
            if (model == null) return Json(null);
            if(ModelState.IsValid)
            {
                model.SaveModel();
                var jsonResult = Json(model, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;
            }
            else
            {
                return Json(null);
            }
        }

        //prefer to bring in the web api nuget package and use IHttpActionResults here
        [HttpGet]
        public JsonResult GetSignup(Guid id)
        {
            var model = SignupViewModel.GetModel(id);
            if(model != null)
            {
                var jsonResult = Json(model, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                return jsonResult;
            }
            else
            {
                return Json(null);
            }
        }
    }
}