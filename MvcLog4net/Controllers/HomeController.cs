using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLog4net.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            DateTime dtNow = DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1);
            if (dtNow > dt)
            {

            }
            else
            {
 
            }
            dtNow = ConvertUtcTime(dtNow);
            dtNow = ConvertStandardTime(dtNow);
            LogHelper.Debug("Debug");
            LogHelper.Error("Error");
            LogHelper.Info("Info");
            LogHelper.Warn("Warn");
            return View();
        }

        /// <summary>
        /// 本地时间转成UTC 时间
        /// </summary>
        /// <param name="dtNow"></param>
        /// <returns></returns>
        public DateTime ConvertUtcTime(DateTime dtNow)
        {
            return dtNow.ToUniversalTime();
        }

        /// <summary>
        /// UTC时间转成本地时间
        /// </summary>
        /// <param name="dtUtc">UTC时间</param>
        /// <returns></returns>
        public DateTime ConvertStandardTime(DateTime dtUtc)
        {
            return dtUtc.ToLocalTime();
        }
    }
}
