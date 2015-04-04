using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProPaymentSummary.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ProPaymentSummary.Web.Models;

namespace ProPaymentSummary.Web.Configuration
{
    public class CurrentContext
    {
        //private static AspNetUser _user;
        private static Professional _professional;
        //public static AspNetUser User 
        //{
        //    get 
        //    {
        //        if (_user == null)
        //        {
        //            var repo = new EFRepository<AspNetUser>();
        //            _user = repo.Get(u => u.Id == HttpContext.Current.User.Identity.GetUserId());
        //        }
        //        return _user;
        //    }
        //}

        //public static Professional Professional
        //{
        //    get
        //    {
        //        if (_professional == null)
        //        {
        //            var repo = new EFRepository<Professional>();
        //            _professional = repo.Get(p => p.ProfessionalId == HttpContext.Current.User.Identity.GetUserId());
        //        }
        //        return _professional;
        //    }
        //}
    }
}