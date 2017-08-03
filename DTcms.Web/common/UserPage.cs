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
    public partial class UserPage : BasePage
    {
     

        /// <summary>
        /// 重写父类的虚方法,此方法将在Init事件前执行
        /// </summary>
        protected override void ShowPage()
        {
           
        }

        /// <summary>
        /// OnInit事件,检查用户是否登录
        /// </summary>
   
        /// <summary>
        /// 构建一个虚方法，供子类重写
        /// </summary>
        protected virtual void InitPage()
        {
            //无任何代码
        }
    }
}