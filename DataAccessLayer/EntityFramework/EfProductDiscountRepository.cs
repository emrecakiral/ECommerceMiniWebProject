﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using MVCCoreProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDiscountRepository : GenericRepository<ProductDiscount>, IProductDiscountDal
    {
    }
}
