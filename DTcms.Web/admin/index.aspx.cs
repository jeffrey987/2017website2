using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTcms.Common;
using System.Data;
namespace DTcms.Web.admin
{
    public partial class index : Web.UI.ManagePage
    {
        protected Model.manager admin_info; //管理员信息

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                admin_info = GetAdminInfo();



            
            }
        }

        //安全退出
        protected void lbtnExit_Click(object sender, EventArgs e)
        {
            Session["is_lokk"] =null;
            Session[DTKeys.SESSION_ADMIN_INFO] = null;
            Utils.WriteCookie("AdminName", "DTcms", -14400);
            Utils.WriteCookie("AdminPwd", "DTcms", -14400);
            Response.Redirect("login.aspx");
        }

    }
}