using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTcms.Web.Models
{
    public class sys_Page
    {
        #region 翻页参数

        int centSize = 5;

        private int _curpage;
        /// <summary>
        /// //当前页
        /// </summary>
        public int curPage
        {
            get { return (_curpage == 0 ? 1 : _curpage); }
            set { _curpage = value; }
        }

        private int _pagesize;
        /// <summary>
        ///  //条数
        /// </summary>
        public int PageSize
        {
            get { return _pagesize == 0 ? 6 : _pagesize; }
            set { _pagesize = value; }
        }
        /// <summary>
        /// 索引开始值
        /// </summary>
        public int Start
        {
            get { return PageSize * (curPage - 1) + 1; }
        }
        /// <summary>
        /////索引结束值 
        /// </summary>
        public int End
        {
            get { return PageSize * curPage; }
        }
        /// <summary>
        /// //总条数
        /// </summary>
        public int TotalRecordCount { get; set; }
        /// <summary>
        /// //总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalRecordCount / PageSize); ;
            }
        }
        public int firstNum
        {
            get { return curPage - centSize < 1 ? 1 : curPage - centSize; }

        }
        public int lastNum
        {
            get { return curPage + centSize > PageCount ? PageCount : curPage + centSize; }
        }
        public int prev
        {
            get { return curPage > 1 ? curPage - 1 : 1; }
        }
        public int next
        {
            get { return curPage < PageCount ? curPage + 1 : curPage; }
        }
        /// <summary>
        /// /搜索关键词
        /// </summary>
        public string key { get; set; }


        #endregion
    }
}