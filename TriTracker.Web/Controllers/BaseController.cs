using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TriTracker.Web.DataContexts;
using TriTracker.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace TriTracker.Web.Controllers
{
    public class BaseController : Controller
    {
        protected ApplicationDb db = new ApplicationDb();

        public Athlete Athlete
        {
            get
            {
                var id = User.Identity.GetUserId();
                return db.Athletes.SingleOrDefault<Athlete>(u => u.AspNetUserId == id);
                //return new User();
            }
        }
    }
}