﻿// ----------------------------------------------------------
// 系统名称：EasySoft PssS
// 项目名称：领域服务类库
// 创 建 人：刘年超
// 创建时间：2017-01-14
// ----------------------------------------------------------
// 修改记录：
// 
// 
// ----------------------------------------------------------
// 版权所有：易则科技工作室 
// ----------------------------------------------------------
namespace EasySoft.PssS.Domain.Service
{
    using Core.Persistence.RepositoryImplement;
    using Core.Util;
    using EasySoft.PssS.DbRepository;
    using EasySoft.PssS.Domain.Entity;
    using EasySoft.PssS.Domain.ValueObject;
    using EasySoft.PssS.Repository;
    using System;
    using System.Collections.Generic;
    using System.Data.Common;

    /// <summary>
    /// 采购领域服务类
    /// </summary>
    public class PurchaseService
    {
        #region 变量

        private IPurchaseRepository purchaseRepository = null;
        private ICostRepository costRepository = null;

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public PurchaseService()
        {
            this.purchaseRepository = new PurchaseRepository();
            this.costRepository = new CostRepository();
        }

        #endregion

        #region 方法

        /// <summary>
        /// 新增采购记录
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="category">分类</param>
        /// <param name="item">项</param>
        /// <param name="quantity">数量</param>
        /// <param name="unit">单位</param>
        /// <param name="supplier">供应方</param>
        /// <param name="remark">备注</param>
        /// <param name="costs">成本</param>
        /// <param name="creator">创建人</param>
        public void Add(DateTime date, string category, string item, decimal quantity, string unit, string supplier, string remark, Dictionary<string, decimal> costs, string creator)
        {
            using (DbConnection conn = DbHelper.CreateConnection())
            {
                DbTransaction trans = null;
                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    if (trans == null)
                    {
                        throw new ArgumentNullException("DbTransaction");
                    }

                    Purchase entity = new Purchase();
                    entity.Create(date, category, item, quantity, unit, supplier, remark, creator);

                    foreach (KeyValuePair<string, decimal> cost in costs)
                    {
                        Cost cost1 = new Cost();
                        cost1.Create(entity.Id, CostItemCategory.Purchase, cost.Key, cost.Value);
                        entity.AddCost(cost.Value);
                        this.costRepository.Insert(trans, cost1);
                    }

                    this.purchaseRepository.Insert(trans, entity);

                    trans.Commit();
                }
                catch
                {
                    if (trans != null)
                    {
                        trans.Rollback();
                    }
                    throw;
                }
            }
        }

        /// <summary>
        /// 删除采购记录
        /// </summary>
        /// <param name="id">Id</param>
        public void Delete(string id)
        {
            using (DbConnection conn = DbHelper.CreateConnection())
            {
                DbTransaction trans = null;
                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    if (trans == null)
                    {
                        throw new ArgumentNullException("DbTransaction");
                    }

                    Purchase oldEntity = this.Select(trans, id);
                    if (oldEntity.Status != PurchaseStatus.None)
                    {
                        throw new EasySoftException(BusinessResource.Common_NotAllowDelete);
                    }
                    this.costRepository.DeleteByRecordId(trans, id);
                    this.purchaseRepository.Delete(trans, id);

                    trans.Commit();
                }
                catch
                {
                    if (trans != null)
                    {
                        trans.Rollback();
                    }
                    throw;
                }
            }
        }

        /// <summary>
        /// 查询采购表信息，用于列表分页显示
        /// </summary>
        /// <param name="category">产品分类</param>
        /// <param name="item">产品项</param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">数据源中每页要显示的行的数目</param>
        /// <param name="totalCount">数据源总记录数</param>
        /// <returns>返回数据表</returns>
        public List<Purchase> Search(string category, string item, int pageIndex, int pageSize, ref int totalCount)
        {
            return this.purchaseRepository.Search(category, item, pageIndex, pageSize, ref totalCount);
        }

        /// <summary>
        /// 查询可交付的采购数据
        /// </summary>
        /// <param name="category">产品分类</param>
        /// <param name="item">产品项</param>
        /// <returns>返回采购数据集合</returns>
        public List<Purchase> GetDeliverable(string category)
        {
            return this.purchaseRepository.GetDeliverable(category);
        }

        /// <summary>
        /// 根据Id查找一条数据
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>返回采购记录</returns>
        public Purchase Select(string id)
        {
            return this.Select(null, id);
        }

        #endregion

        #region 受保护的方法

        /// <summary>
        /// 根据Id查找一条数据
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>返回采购记录</returns>
        internal Purchase Select(DbTransaction trans, string id)
        {
            Purchase entity = this.purchaseRepository.Select(trans, id);
            if (entity == null)
            {
                throw new EasySoftException(BusinessResource.Purchase_NoFoundById);
            }
            return entity;
        }

        /// <summary>
        /// 更新采购信息
        /// </summary>
        /// <param name="trans">数据库事务</param>
        /// <param name="entity">数据实体对象</param>
        internal void Update(DbTransaction trans, Purchase entity)
        {
            this.purchaseRepository.Update(trans, entity);
        }

        #endregion
    }
}
