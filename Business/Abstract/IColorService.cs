﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();

        List<Color> GetColorsByColorId(int id);

        void Add(Color color);


    }
}