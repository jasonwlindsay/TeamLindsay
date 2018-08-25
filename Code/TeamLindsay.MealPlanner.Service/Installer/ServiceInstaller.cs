using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TeamLindsay.Structure.Interface;

namespace TeamLindsay.MealPlanner.Service.Installer
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                .BasedOn<IService>()
                .WithServiceAllInterfaces()
                .WithServiceSelf()
                .LifestyleTransient());
        }
    }
}
