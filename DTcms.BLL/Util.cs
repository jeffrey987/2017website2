using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTcms.BLL
{
    public partial class Util
    {
        private readonly Model.siteconfig siteConfig = new BLL.siteconfig().loadConfig(); //获得系统配置信息
        private readonly DAL.Util dal;

        public Util()
        {
            dal = new DAL.Util(siteConfig.sysdatabaseprefix);
        }

        public List<Model.v_products> SearchIsPro(string key)
        {     
            var dt= dal.SearchIsPro(key);
            return new BLL.v_products().DataTableToList(dt);
        }
    }
}
