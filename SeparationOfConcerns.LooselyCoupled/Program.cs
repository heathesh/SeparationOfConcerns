using Microsoft.Extensions.DependencyInjection;
using SeparationOfConcerns.LooselyCoupled.BusinessLogic;
using SeparationOfConcerns.LooselyCoupled.Interface;

namespace SeparationOfConcerns.LooselyCoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IWorker, Worker>()
                .AddSingleton<IFileUtility, SystemFileUtility>()
                .BuildServiceProvider();

            var worker = serviceProvider.GetService<IWorker>();
            worker.DoWork();
        }
    }
}
