using Microsoft.EntityFrameworkCore;
using RentalApp.Core;
using RentalApp.Core.Dto;
using RentalApp.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface IHomeProductService
    {
       Task <IEnumerable<Product>> GetAllProducts();
    }
}
