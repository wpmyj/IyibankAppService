using System;
using System.Collections.Generic;
using System.Text;

namespace IyibankAppService.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
