using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DTcms.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {



            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.Add("DomainRoute", new DomainRoute(
            //        "{fxpy}.juyingonline.com",     // Domain with parameters 
            //        "{fxpy}/{action}/{id}",    // URL with parameters 
            // new {  fxpy = "", controller = "fenxiao", action = "index" }  // Parameter defaults 
            //    ));



            //错误页面
            routes.MapRoute(null, "error", new { controller = "home", action = "error" }, namespaces: new[] { "DTcms.Web.Controllers" });

            #region 管理类联考
            routes.MapRoute("管联-文章页", "{call_index}/{id}.html", new { Controller = "GuanLian", Action = "Details" }, new { call_index = "mba|mpa|mpacc|mta|mem|maud|mlis" });
            //routes.MapRoute("管联-栏目-学校-专业", "{call_index}/{category}-{school}-{subject_id}", new { Controller = "GuanLian", Action = "List" },new { call_index = "mba|mpa|mpacc|mta|mem|maud|mlis" });
            routes.MapRoute("管联-栏目-专业", "{call_index}/{category}", new { Controller = "GuanLian", Action = "List" }, new { call_index = "mba|mpa|mpacc|mta|mem|maud|mlis" });
            //routes.MapRoute("管联-栏目-学校", "{call_index}/{category}-{school}", new { Controller = "GuanLian", Action = "List" },new { call_index = "mba|mpa|mpacc|mta|mem|maud|mlis" });
            routes.MapRoute("管联-栏目", "{call_index}/{category}", new { Controller = "GuanLian", Action = "List", category = UrlParameter.Optional }, new { call_index = "mba|mpa|mpacc|mta|mem|maud|mlis" });
            //routes.MapRoute("管联", "{call_index}", new { Controller = "GuanLian", Action = "Index" },new { call_index = "mba|mpa|mpacc|mta|mem|maud|mlis" });
            #endregion
            //网课  
            routes.MapRoute("", "video/play", new { controller = "video", action = "play" });
            routes.MapRoute("", "video/{category}/{subid}", new { controller = "video", action = "list" });
            routes.MapRoute("", "video/{category}", new { controller = "video", action = "list" });

            //分校
            routes.MapRoute("", "fenxiao/{fxpy}", new { controller = "fenxiao", action = "index" });

            routes.MapRoute("", "info/beikao", new { controller = "info", action = "beikao" });
            routes.MapRoute("", "{category}/{school}-{college}", new { controller = "info", action = "index" }, new { category = "baolubi|shumu|mulu|jianzhang|fenshu|zhenti|daoshi|zhuanye|dagang|fushi|tiaoji|yanxun" });//报录比
            routes.MapRoute("", "{category}", new { controller = "info", action = "index" }, new { category = "zsxx|baolubi|shumu|mulu|jianzhang|fenshu|zhenti|daoshi|zhuanye|dagang|fushi|tiaoji|yanxun" });//报录比

            //qqqun
            //routes.MapRoute("", "qqgroup-{province}-{school_id}-{colleges}#!{p}", new { controller = "company", action = "qqgroup" });
            routes.MapRoute("", "qqgroup-{province}-{school_id}-{colleges}", new { controller = "company", action = "qqgroup" });
            //专业课
            routes.MapRoute("", "zy", new { controller = "Zhuanye", action = "index" });
            routes.MapRoute("", "zy/{id}", new { controller = "Zhuanye", action = "zhuanyeTB" }, new { id = @"^\d+$" });

            //下载中心
            routes.MapRoute("", "down/{category}/{school}-{xueyuan}", new { controller = "down", action = "index" });
            routes.MapRoute("", "down/{category}", new { controller = "down", action = "list" });

            //产品中心
            //routes.MapRoute("", "fudaoban/{category}-{school}", new { controller = "fudaoban", action = "index" });//辅导班
            routes.MapRoute("", "fudaoban/details/{id}_{sku}", new { controller = "fudaoban", action = "details" });
            routes.MapRoute("", "fudaoban/{category}", new { controller = "fudaoban", action = "index" });
            // routes.MapRoute("", "fudaoban/{category}", new { controller = "fudaoban", action = "list" });//辅导班列表页 2017/1/17停用
            routes.MapRoute("", "ziliao/details/{id}_{sku}", new { controller = "ziliao", action = "details" });
            routes.MapRoute("", "ziliao/zlSearch", new { controller = "ziliao", action = "zlSearch" });//资料
            routes.MapRoute("", "ziliao/{category1}-{school}-{xueyuan}", new { controller = "ziliao", action = "index" });//资料

            //routes.MapRoute("", "ziliao/{category}", new { controller = "ziliao", action = "list" });//资料列表页 已停用


            //新闻中心
            routes.MapRoute("", "news/{id}.html", new { controller = "news", action = "details" }, new { id = @"^\d+$" });
            routes.MapRoute("", "news/{category}", new { controller = "news", action = "list", category = UrlParameter.Optional });

            //学校
            // routes.MapRoute("", "school/Index_old", new { controller = "school", action = "Index_old" });//new page

            routes.MapRoute("", "school/", new { controller = "school", action = "all" });//院校库
            routes.MapRoute("", "school/{province}-{lx}-{xx}-{xz}", new { controller = "school", action = "all", province = "0", lx = "0", xx = "0", xz = "0" });//院校库
            routes.MapRoute("", "school/{id}.html", new { controller = "school", action = "details" }, new { id = @"^\d+$" });//信息详细页
            routes.MapRoute("", "school/result", new { controller = "school", action = "result" });//搜索结果
            routes.MapRoute("", "school/{py}", new { controller = "school", action = "index" });//学校
            routes.MapRoute("", "school/{py}/yx-{id}-{category}", new { controller = "school", action = "yx_category" }, new { id = @"^\d+$" });//院系/栏目
            routes.MapRoute("", "school/{py}/yx-{id}", new { controller = "school", action = "yx" }, new { id = @"^\d+$" });//院系
            routes.MapRoute("", "school/{py}/{category}-{xueyuan}", new { controller = "school", action = "list" });//信息列表页


            //硕士专业目录查询
            routes.MapRoute("", "zy/school/{province}-{ml}-{xk}-{xx1}-{xx2}-{xx3}", new { controller = "zy", action = "school" }, new { province = @"^\d+$" });//信息列表页
            routes.MapRoute("", "zy/query/{province}-{ml}-{xk}-{zy}", new { controller = "zy", action = "query" }, new { province = @"^\d+$" });//信息列表页



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "DTcms.Web.Controllers" }
            );
        }
    }
}
