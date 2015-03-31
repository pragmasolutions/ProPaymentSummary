using System;
using ProPaymentSummary.Data.Helpers;
using ProPaymentSummary.Data.Interfaces;
using ProPaymentSummary.Entities;

namespace ProPaymentSummary.Data
{
    public class ProPaymentSummaryUow : IProPaymentSummaryUow
    {
        public ProPaymentSummaryUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        // Repositories
        public IRepository<AspNetRole> AspNetRoles { get { return GetStandardRepo<AspNetRole>(); } }
        public IRepository<AspNetUser> AspNetUsers { get { return GetStandardRepo<AspNetUser>(); } }
        public IRepository<HealthInsuranceProvider> HealthInsuranceProviders { get { return GetStandardRepo<HealthInsuranceProvider>(); } }
        public IRepository<Order> Orders { get { return GetStandardRepo<Order>(); } }
        public IRepository<Practice> Practices { get { return GetStandardRepo<Practice>(); } }
        public IRepository<PracticeOrder> PracticeOrders { get { return GetStandardRepo<PracticeOrder>(); } }
        public IRepository<Professional> Professionals { get { return GetStandardRepo<Professional>(); } }
        public IRepository<Province> Provinces { get { return GetStandardRepo<Province>(); } }
        //public ITituloRepository Titulos { get { return GetRepo<ITituloRepository>(); } }

        public bool IsDisposed { get; private set; }

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        protected void CreateDbContext()
        {
            DbContext = new ProPaymentSummaryEntities();

            // Do NOT enable proxied entities, else serialization fails
            DbContext.Configuration.ProxyCreationEnabled = false;

            // Load navigation properties explicitly (avoid serialization trouble)
            DbContext.Configuration.LazyLoadingEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            DbContext.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need 
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
        }

        protected IRepositoryProvider RepositoryProvider { get; set; }

        private IRepository<T> GetStandardRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        private ProPaymentSummaryEntities DbContext { get; set; }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }

            IsDisposed = true;
        }

        #endregion


        
    }
}
