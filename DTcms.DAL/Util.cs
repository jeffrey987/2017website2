using System;
using System.Collections.Generic;
using DTcms.Model;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DTcms.DBUtility;
using System.Linq;

namespace DTcms.DAL
{
    public class Util
    {
        private string databaseprefix; //数据库表名前缀
        public Util(string _databaseprefix)
        {
            databaseprefix = _databaseprefix;
        }

        public DataTable SearchIsPro(string key)
        {
            DataTable result = new DataTable();
            DataSet ds = new DataSet();

            string strSql = "";
            List<string> key_list = key.Split(' ').ToList();
            if (!string.IsNullOrEmpty(key))
            {
                strSql = string.Format("select * from v_products where title like '%{0}%'", key);
                ds = DbHelperSQL.Query(strSql);
                result = AddRange(result, ds.Tables[0]);
            }
            if (key_list.Count > 0)
            {
                foreach (var key_item in key_list)
                {
                    strSql = string.Format("select * from v_products where title like '%{0}%'", key_item);
                    ds = DbHelperSQL.Query(strSql);
                    result = AddRange(result, ds.Tables[0]);
                }
            }
            return result;
        }

        private DataTable AddRange(DataTable oldTable, DataTable newTable)
        {
            try
            {
                foreach (DataRow item in newTable.Rows)
                {

                    DataRow newrow = oldTable.NewRow();
                    newrow = item;
                    oldTable.Rows.Add(newrow);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return oldTable;
        }


    }
}