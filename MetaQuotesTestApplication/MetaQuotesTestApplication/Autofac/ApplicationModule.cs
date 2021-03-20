using Autofac;
using MetaQuotes.TestApplication.Data;
using System.Reflection;
using Module = Autofac.Module;

namespace MetaQuotes.TestApplication.Autofac
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Регистрируем все типы в сборке по дефолту PerDependency
            var dataAccess = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(dataAccess)
                   .AsImplementedInterfaces();

            // Регистрируем поставщика данных как синглтон с автоактивацией на старте приложения
            builder.RegisterType<DataStorage>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
