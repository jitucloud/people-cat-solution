using Autofac;
using PeopleCAT.API.Online.Interface;
using PeopleCAT.API.Online.Manager;

namespace PeopleCAT.API.Online
{
    /// <summary>
    /// Service Registry to Dependency Injection for all resources
    /// </summary>
    public class ServicesRegistry
    {
        public void Register(ContainerBuilder builder)
        {
            builder.RegisterInstance<ICatManager>(new CatManager());
        }
    }
}