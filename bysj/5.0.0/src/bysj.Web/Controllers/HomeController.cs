﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace bysj.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : bysjControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}