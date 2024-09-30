using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;

namespace MVC3
{
    public static class MyHelper
    {
        public static IHtmlString Button(this HtmlHelper helper,string value)
        {
            TagBuilder tag = new TagBuilder("input");
            tag.Attributes.Add("type", "submit");
            tag.Attributes.Add("value", value);
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString Image(this HtmlHelper helper, string value, string src, string alt)
        {
            
            return new MvcHtmlString($"<img src = '{src}' alt = '{alt}'");
        }
    }
}