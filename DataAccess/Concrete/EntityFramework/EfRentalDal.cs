using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {

        //public List<RentalDetailDto> GetRentalDetails()
        //{
        //    using (RentCarContext context = new RentCarContext())
        //    {
        //        var result = from r in context.Rentals
        //                     join cu in context.Customers
        //                         on cu.CustomerId equals r.CustomerId
        //                     join c in context.Cars
        //                          on c.Id equals c.Id



        //                     select new RentalDetailDto
        //                     {
        //                         CustomerName = u.FirstName

        //                     };
        //        return result.ToList();
        //    }
        //}
    }
}
