using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Repository;
using Blog.Core.Services.BASE;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Core.Services
{
    public class AdvertisementServices : BaseServices<Advertisement> , IAdvertisementServices
    {
        IAdvertisementRepository dal = new AdvertisementRepository();

 
        public int Sum(int i, int j)
        {
            return dal.Sum(i, j);
        }

    
    }
}
