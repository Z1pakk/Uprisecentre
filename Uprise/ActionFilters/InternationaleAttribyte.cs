using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Uprise.ActionFilters
{
    public class InternationalizationAttribute : ActionFilterAttribute
    {
        private readonly IList<string> _supportedLocales;
        private readonly string _defaultLang;

        public InternationalizationAttribute()
        {
            _supportedLocales = Utils.LocalizationHelper.GetSupportedLocales();
            _defaultLang = _supportedLocales[0];
        }
        private void SetLang(string lang)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string lang = (string)filterContext.RouteData.Values["lang"] ?? _defaultLang;
            if (!_supportedLocales.Contains(lang))
            {
                lang = _defaultLang;
            }
            SetLang(lang);
            //base.OnActionExecuting(filterContext);
        }



    }
}