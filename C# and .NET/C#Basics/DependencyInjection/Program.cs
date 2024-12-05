using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection().AddTransient<IShape,Square>().BuildServiceProvider();
            var Service = serviceProvider.GetRequiredService<IShape>();
            Service.PrintArea();
        }
    }
}
