using AutomaticRegisterServicesProject.Abstracts;
using System.Reflection;

namespace AutomaticRegisterServicesProject.Extensions
{
    public static class ServicesRegistratr
    {
        public static void RegisterServices(this IServiceCollection services, Assembly assembly)
        {
            var concretes = assembly.GetTypes().Where(x => x.GetInterfaces().Contains(typeof(IConcrete)) && !x.IsAbstract);

            foreach (var concrete in concretes)
            {
                var @abstract = concrete.GetInterfaces().Where(x => x.IsAssignableTo(typeof(IAbstract)) && x.FullName != typeof(IAbstract).FullName).FirstOrDefault();

                if (@abstract == null)
                {
                    if (concrete.IsAssignableTo(typeof(ISingletonConcrete)))
                        services.AddSingleton(concrete);
                    else if (concrete.IsAssignableTo(typeof(IScopedConcrete)))
                        services.AddScoped(concrete);
                    else if (concrete.IsAssignableTo(typeof(ITransientConcrete)))
                        services.AddTransient(concrete);
                }
                else
                {
                    if (concrete.IsAssignableTo(typeof(ISingletonConcrete)))
                        services.AddSingleton(@abstract, concrete);
                    else if (concrete.IsAssignableTo(typeof(IScopedConcrete)))
                        services.AddScoped(@abstract, concrete);
                    else if (concrete.IsAssignableTo(typeof(ITransientConcrete)))
                        services.AddTransient(@abstract, concrete);
                }
            }
        }
    }
}
