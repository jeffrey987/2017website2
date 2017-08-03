using System;
using System.Collections.Generic;
using System.Text;

namespace DTcms.Common
{
    public class DTEnums
    {
        /// <summary>
        /// 统一管理操作枚举
        /// </summary>
        public enum ActionEnum
        {
            /// <summary>
            /// 所有
            /// </summary>
            All,
            /// <summary>
            /// 显示
            /// </summary>
            Show,
            /// <summary>
            /// 查看
            /// </summary>
            View,
            /// <summary>
            /// 添加
            /// </summary>
            Add,
            /// <summary>
            /// 修改
            /// </summary>
            Edit,
            /// <summary>
            /// 删除
            /// </summary>
            Delete,
            /// <summary>
            /// 审核
            /// </summary>
            Audit,
            /// <summary>
            /// 回复
            /// </summary>
            Reply,
            /// <summary>
            /// 确认
            /// </summary>
            Confirm,
            /// <summary>
            /// 取消
            /// </summary>
            Cancel,
            /// <summary>
            /// 作废
            /// </summary>
            Invalid,
            /// <summary>
            /// 生成
            /// </summary>
            Build,
            /// <summary>
            /// 安装
            /// </summary>
            Instal,
            /// <summary>
            /// 卸载
            /// </summary>
            UnLoad,
            /// <summary>
            /// 登录
            /// </summary>
            Login,
            /// <summary>
            /// 备份
            /// </summary>
            Back,
            /// <summary>
            /// 还原
            /// </summary>
            Restore,
            /// <summary>
            /// 替换
            /// </summary>
            Replace,
            /// <summary>
            /// 复制
            /// </summary>
            Copy
        }

        /// <summary>
        /// 系统导航菜单类别枚举
        /// </summary>
        public enum NavigationEnum
        {
            /// <summary>
            /// 系统后台菜单
            /// </summary>
            System,
            /// <summary>
            /// 会员中心导航
            /// </summary>
            Users,
            /// <summary>
            /// 网站主导航
            /// </summary>
            WebSite
        }

        /// <summary>
        /// 用户生成码枚举
        /// </summary>
        public enum CodeEnum
        {
            /// <summary>
            /// 注册验证
            /// </summary>
            RegVerify,
            /// <summary>
            /// 邀请注册
            /// </summary>
            Register,
            /// <summary>
            /// 取回密码
            /// </summary>
            Password
        }

        /// <summary>
        /// 金额类型枚举
        /// </summary>
        public enum AmountTypeEnum
        {
            /// <summary>
            /// 系统赠送
            /// </summary>
            SysGive,
            /// <summary>
            /// 在线充值
            /// </summary>
            Recharge,
            /// <summary>
            /// 用户消费
            /// </summary>
            Consumption,
            /// <summary>
            /// 购买商品
            /// </summary>
            BuyGoods,
            /// <summary>
            /// 积分兑换
            /// </summary>
            Convert
        }

        /// <summary>
        /// 学校资讯类别
        /// </summary>
        public enum InfoTypeEnum
        {
            参考书目 = 52, 报录比 = 53, 招生目录 = 54, 招生简章 = 55, 历年分数 = 56, 历年真题 = 57, 导师介绍 = 58, 专业介绍 = 59,
            院系信息 = 60, 院校研训 = 65, 考试大纲 = 69, 复试信息 = 74, 调剂信息 = 75
        }
        /// <summary>
        /// 网站资讯类别
        /// </summary>
        public enum NewsTypeEnum
        {
            经验分享 = 61, 考研数学 = 62, 考研英语 = 63, 考研政治 = 64, 考研专业课 = 68, 考研常识 = 70, 网站公告 = 71,
            考研政策 = 72, 媒体报道 = 73, 复试经验 = 85, 调剂经验 = 86, 在职考研专业介绍 = 92, 在职考研招生信息 = 93,
            在职考研专业课 = 94, 在职考研联考综合 = 95, 专业硕士 = 103, 分校资讯 = 101, 热门专业 = 102
        }/// <summary>
         /// 
         /// </summary>
        public enum DownTypeEnum
        {
            考研英语 = 88, 考研政治 = 89, 考研数学 = 90, 考研专业课 = 91
        }/// <summary>
         /// 
         /// </summary>
        public enum ProductTypeEnum
        {
            考研辅导班 = 83, 考研图书资料 = 84, 圆梦卡系列辅导班 = 80, 一对一系列辅导班 = 81, 协议保过系列辅导班 = 82,
            历年真题 = 67, 全真模拟 = 76, 三十天30题 = 77, 冲刺指南 = 78, 复习全书 = 79
        }
        public enum lkzhTypeEnum
        {
            写作 = 110, 逻辑 = 109, 初等数学 = 108
        }

        public enum bkzyTypeEnum
        {
            法律硕士 = 107, 翻译硕士 = 106, 金融硕士 = 105, 会计硕士 = 104
        }
        public enum ggk_kemuEnum
        {
            英语 = 101, 数学 = 102, 政治 = 103, 英语数学 = 104, 英语政治 = 105, 政治数学 = 106, 政治英语数学 = 107
        }
        public enum zyk_kemuEnum
        {
            专业课150分 = 201, 专业课300分 = 202, 翻译硕士 = 203, 工商管理硕士 = 204, 会计专硕 = 205, 管理类联考 = 206, 法硕联考 = 207
        }
        public enum ziliao_typeEnum
        {
            复习全书 = 301, 历年真题解析 = 302, 全真模拟题 = 303, 全书and模拟题 = 304
        }
        public enum fenshuEnum
        {
            十分 = 401, 二十分 = 402, 三十分 = 403, 四十分 = 404, 五十分 = 405
        }
    }
}
