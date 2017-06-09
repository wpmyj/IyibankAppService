using Dapper;
using IyibankAppService.Data.Config;
using IyibankAppService.Data.Infrastructure;
using IyibankAppService.Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IyibankAppService.Data.Repository
{
    /// <summary>
    /// 用户仓储
    /// </summary>
    /// <typeparam name="User"></typeparam>
    public class ShopRepository : IShopRepository
    {
        /// <summary>
        /// 创建一个用户
        /// </summary>
        /// <param name="entity">用户</param>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        public bool Add(Shop entity, string connectionString = null)
        {
            using (IDbConnection conn = DbFactory.GetNewConnection())
            {
                string insertSql = @"INSERT INTO [dbo].[User]
                                           ([UserName]
                                           ,[Password]
                                           ,[Gender]
                                           ,[Birthday]
                                           ,[CreateUserId]
                                           ,[CreateDate]
                                           ,[UpdateUserId]
                                           ,[UpdateDate]
                                           ,[IsDeleted])
                                     VALUES
                                           (@UserName
                                           ,@Password
                                           ,@Gender
                                           ,@Birthday
                                           ,@CreateUserId
                                           ,@CreateDate
                                           ,@UpdateUserId
                                           ,@UpdateDate
                                           ,@IsDeleted)";
                return conn.Execute(insertSql, entity) > 0;
            }
        }

        /// <summary>
        /// 根据主键Id删除一个用户
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        public bool Delete(int id, string connectionString = null)
        {
            using (IDbConnection conn = DbFactory.GetNewConnection())
            {
                string deleteSql = @"DELETE FROM [dbo].[User]
                                            WHERE Id = @Id";
                return conn.Execute(deleteSql, new { Id = id }) > 0;
            }
        }

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        public IEnumerable<Shop> GetAll(string connectionString = null)
        {
            using (IDbConnection conn = DbFactory.GetNewConnection())
            {
                string querySql = @"SELECT *
                                      FROM shops";
                return conn.Query<Shop>(querySql);
            }
        }

        /// <summary>
        /// 根据主键Id获取一个用户
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        public Shop GetById(int id, string connectionString = null)
        {
            using (IDbConnection conn = DbFactory.GetNewConnection())
            {
                string querySql = @"SELECT [Id]
                                          ,[UserName]
                                          ,[Password]
                                          ,[Gender]
                                          ,[Birthday]
                                          ,[CreateUserId]
                                          ,[CreateDate]
                                          ,[UpdateUserId]
                                          ,[UpdateDate]
                                          ,[IsDeleted]
                                      FROM [dbo].[User]
                                     WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Shop>(querySql, new { Id = id });
            }
        }

        /// <summary>
        /// 修改一个用户
        /// </summary>
        /// <param name="entity">要修改的用户</param>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        public bool Modify(Shop entity, string connectionString = null)
        {
            using (IDbConnection conn = DbFactory.GetNewConnection())
            {
                string updateSql = @"UPDATE [dbo].[User]
                                       SET [UserName] = @UserName
                                          ,[Password] = @Password
                                          ,[Gender] = @Gender
                                          ,[Birthday] = @Birthday
                                          ,[UpdateUserId] = @UpdateUserId
                                          ,[UpdateDate] = @UpdateDate
                                          ,[IsDeleted] = @IsDeleted
                                     WHERE Id = @Id";
                return conn.Execute(updateSql, entity) > 0;
            }
        }
    }


    public interface IShopRepository : IRepository<Shop>
    {
    }
}
