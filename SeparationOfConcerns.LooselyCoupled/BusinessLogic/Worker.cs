using System;
using SeparationOfConcerns.LooselyCoupled.Interface;

namespace SeparationOfConcerns.LooselyCoupled.BusinessLogic
{
    public class Worker : IWorker
    {
        private readonly IFileUtility _fileUtility;

        public Worker(IFileUtility fileUtility)
        {
            _fileUtility = fileUtility;
        }

        public void DoWork()
        {
            var fileName = $"{DateTime.Now:yyyyMMddHHmmss}.log";
            _fileUtility.WriteToFile(fileName, "LOOSELY COUPLED - This is a test");
        }
    }
}
