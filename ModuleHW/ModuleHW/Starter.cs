using Microsoft.Extensions.DependencyInjection;

namespace ModuleHW
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ApplicationContext>()
                .BuildServiceProvider();

            var applicationContext = serviceProvider.GetService<ApplicationContext>();
            applicationContext.SaveChanges();
        }
    }
}
