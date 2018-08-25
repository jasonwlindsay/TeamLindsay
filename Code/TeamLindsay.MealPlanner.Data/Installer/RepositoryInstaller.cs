using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TeamLindsay.Structure.Interface;

namespace TeamLindsay.MealPlanner.Data.Installer
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                .BasedOn<IRepository>()
                .WithServiceAllInterfaces()
                .WithServiceSelf()
                .LifestyleTransient());
        }
    }
}
