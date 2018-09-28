using SeparationOfConcerns.TightlyCoupled.BusinessLogic;

namespace SeparationOfConcerns.TightlyCoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.DoWork();
        }
    }
}
