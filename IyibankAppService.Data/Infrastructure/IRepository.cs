using System.Collections.Generic;

namespace IyibankAppService.Data.Infrastructure
{
    /// <summary>
    /// 数据操作泛型接口，对于泛型实例的CRUD操作所有的仓储类型都需要实现此接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 添加一个实体
        /// </summary>
        /// <param name="entity">要创建的实体</param>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        bool Add(T entity, string connectionString = null);

        /// <summary>
        /// 根据主键Id获取一个实体
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        T GetById(int id, string connectionString = null);

        /// <summary>
        /// 获取所有实体
        /// </summary>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        IEnumerable<T> GetAll(string connectionString = null);

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">要修改的实体</param>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        bool Modify(T entity, string connectionString = null);

        /// <summary>
        /// 根据主键Id删除一个实体
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <param name="connectionString">链接字符串</param>
        /// <returns></returns>
        bool Delete(int id, string connectionString = null);
    }
}
