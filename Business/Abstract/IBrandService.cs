﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {

        List<Brand> GetAll();
        List<Brand> GetBrandsByBrandId(int id);

        void Add(Brand brand);

    }
}
