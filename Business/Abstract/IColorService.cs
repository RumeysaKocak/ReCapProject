﻿using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int ColorId);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);

    }
}
