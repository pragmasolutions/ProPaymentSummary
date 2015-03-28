using System;
using System.Data.Entity;
using ProPaymentSummary.Entities;

namespace ProPaymentSummary.Data.Repository
{
    /// <summary>
    /// The EF-dependent, base repository for data access
    /// </summary>
    public class EFBaseRepository
    {
        public EFBaseRepository()
        {
            CreateDbContext();
        }

        public EFBaseRepository(DbContext dbContext)
        {
            if (dbContext == null) 
                throw new ArgumentNullException("dbContext");
            DbContext = dbContext;
            ProPaymentSummaryEntities = dbContext as ProPaymentSummaryEntities;
            if (ProPaymentSummaryEntities !=null)
                ProPaymentSummaryEntities.Database.CommandTimeout = 1000;
        }

        protected void CreateDbContext()
        {
            DbContext = new ProPaymentSummaryEntities();
            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ValidateOnSaveEnabled = false;
            
            ProPaymentSummaryEntities = DbContext as ProPaymentSummaryEntities;
            if (ProPaymentSummaryEntities != null)
                ProPaymentSummaryEntities.Database.CommandTimeout = 1000;
        }
        
        protected DbContext DbContext { get; set; }

        public ProPaymentSummaryEntities ProPaymentSummaryEntities { get; set; }
    }
}
