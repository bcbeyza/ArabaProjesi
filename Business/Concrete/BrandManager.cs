﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public List<Brand> GetAll()
        {
            return  _brandDal.GetAll();
        }

        public List<Brand> GetBrandsByBrandId(int id)
        {
            return _brandDal.GetAll(b => b.Id == id);
        }
    }
}
