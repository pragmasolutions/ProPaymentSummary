using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProPaymentSummary.Entities;

namespace ProPaymentSummary.Data.Interfaces
{
    public interface IProPaymentSummaryUow : IDisposable
    {
        IRepository<AspNetRole> AspNetRoles { get; }
        IRepository<AspNetUser> AspNetUsers { get; }
        IRepository<HealthInsuranceProvider> HealthInsuranceProviders { get; }
        IRepository<Order> Orders { get; }
        IRepository<Practice> Practices { get; }
        IRepository<PracticeOrder> PracticeOrders { get; }
        IRepository<Professional> Professionals { get; }
        IRepository<Province> Provinces { get; }

        void Commit();
    }
}
