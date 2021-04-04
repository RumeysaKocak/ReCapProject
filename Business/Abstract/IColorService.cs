﻿using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int ColorId);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);

    }
}
