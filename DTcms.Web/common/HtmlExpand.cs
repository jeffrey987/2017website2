using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web.Mvc
{
    public static class HtmlExpand
    {

        public static IHtmlString GetContent(this HtmlHelper heper, string summary, string content, int len)
        {

            string str = string.Empty;
            if (summary.Trim() != "")
                str = DTcms.Common.Utils.CutString(summary, len);
            else
                str = DTcms.Common.Utils.CutString(content, len);
            return MvcHtmlString.Create(str);
        }
      
    }
}