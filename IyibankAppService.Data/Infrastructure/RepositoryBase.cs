using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IyibankAppService.Data.Infrastructure
{
    /// <summary>
    /// 数据操作抽象类，实现泛型接口的操作
    /// 所有的仓储类型都需要继承此抽象类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class RepositoryBase<T> where T : class
    {

    }
}
