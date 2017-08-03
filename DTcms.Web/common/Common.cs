using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTcms.Web.common
{
    public static class Common
    {
        public static string GetFileSize(int size)
        {
            string res = string.Empty;

            if (size > 1024)
            {
                res = (size / 1024f).ToString("#") + "MB";
            }
            else
            {
                res = size + "KB";
            }
            return res;
        }
    }

}