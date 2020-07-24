using Blog.Core.IRepository.BASE;
using Blog.Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Core.IRepository
{
    public interface IAdvertisementRepository : IBaseRepository<Advertisement>
    {
        int Sum(int i, int j);
  
    }
}
