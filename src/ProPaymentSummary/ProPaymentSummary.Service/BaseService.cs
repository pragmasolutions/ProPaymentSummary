using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Dto;
using ProPaymentSummary.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProPaymentSummary.Data.Interfaces;

namespace ProPaymentSummary.Service
{
    public class BaseService
    {
        protected IProPaymentSummaryUow Uow { get; set; }
    }
}
