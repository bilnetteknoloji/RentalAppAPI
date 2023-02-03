using RentalApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Service.Impl
{
    public interface ICurrenciesService
    {
        ParaBirimler GetParaBirimlerById(int BirimId);
        IList<ParaBirimler> GetAllParaBirimler(int BirimId);
        bool DeleteParaBirimler(ParaBirimler paraBirimler);
        ParaBirimler UpdateParaBirimler(ParaBirimler paraBirimler);
        bool InsertParaBirimler(ParaBirimler paraBirimler);
        IList<ParaBirimler> GetAllParaBirimlers();
    }
}
