using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService:IBusinessRepository<Brand>
    {
        Brand GetCarsByBrandId(int id);
    }
}
