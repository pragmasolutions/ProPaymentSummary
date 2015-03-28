using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPaymentSummary.Data.Interfaces
{
    public interface IUowFactory
    {
        T Create<T>();
    }
}
