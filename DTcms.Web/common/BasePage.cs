using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Configuration;
using DTcms.Common;

namespace DTcms.Web.UI
{
    public partial class BasePage : System.Web.UI.Page
    {
        protected internal Model.siteconfig config = new BLL.siteconfig().loadConfig();
        protected internal Model.userconfig uconfig = new BLL.userconfig().loadConfig();
        protected internal Model.channel_site site = new Model.channel_site();
        /// <summary>
        /// 父类的构造函数
        /// </summary>
        public BasePage()
        {
            //是否关闭网站
            if (config.webstatus == 0)
            {
                //HttpContext.Current.Response.Redirect(linkurl("error", "?msg=" + Utils.UrlEncode(config.webclosereason)));
                return;
            }
            //取得站点信息
            //site = GetSiteModel();
            //抛出一个虚方法给继承重写
            ShowPage();
        }

        /// <summary>
        /// 页面处理虚方法
        /// </summary>
        protected virtual void ShowPage()
        {
            //虚方法代码
        }


        

        #region 辅助方法(私有)========================================

        /// <summary>
        /// 替换扩展名
        /// </summary>
        private string GetUrlExtension(string urlPage, string staticExtension)
        {
            return Utils.GetUrlExtension(urlPage, staticExtension);
        }

        #endregion
    }
}
