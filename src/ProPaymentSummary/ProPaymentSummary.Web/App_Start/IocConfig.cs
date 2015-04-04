using System.Web.Http;
using Framework.Ioc;
using Ninject;
using ProPaymentSummary.Service;
using ProPaymentSummary.Service.Interfaces;

namespace ProPaymentSummary.Web
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(); 

            RegisterServices(kernel);

            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IPatientService>().To<PatientService>();
        }
    }
}