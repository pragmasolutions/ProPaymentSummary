using ProPaymentSummary.Data.Repository;
using ProPaymentSummary.Entities;
using ProPaymentSummary.Service.Data;
using ProPaymentSummary.Service.Dto;
using ProPaymentSummary.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPaymentSummary.Service
{
    public class ProfessionalService : IProfessionalService
    {
        public ProfessionalDto Get(string id)
        {
            var repo = new EFRepository<Professional>();
            var prof = repo.Get(p => p.ProfessionalId == id);
            if (prof != null)
            {
                return new ProfessionalDto
                {
                    Address = prof.Address,
                    City = prof.City,
                    CUIT = prof.CUIT,
                    DNI = prof.DNI,
                    FirstName = prof.FirstName,
                    LastName = prof.LastName,
                    MN = prof.MN,
                    MP = prof.MP,
                    Phone = prof.Phone,
                    Id = prof.ProfessionalId,
                    ProvinceId = prof.ProvinceId
                };
            }
            return null;
        }
    }
}
