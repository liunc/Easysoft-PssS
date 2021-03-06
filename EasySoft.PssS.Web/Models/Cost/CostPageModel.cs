﻿// ----------------------------------------------------------
// 系统名称：EasySoft PssS
// 项目名称：Web
// 创 建 人：刘年超
// 创建时间：2017-01-15
// ----------------------------------------------------------
// 修改记录：
// 
// 
// ----------------------------------------------------------
// 版权所有：易则科技工作室 
// ----------------------------------------------------------
namespace EasySoft.PssS.Web.Models.Cost
{
    /// <summary>
    /// 成本项视图模型类
    /// </summary>
    public class CostPageModel
    {
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public string Id { get; set; } 

        /// <summary>
        /// 获取或设置成本项代码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 获取或设置成本项代码
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 获取或设置金额
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// 获取或设置排序号
        /// </summary>
        public short OrderNumber { get; set; }

    }
}