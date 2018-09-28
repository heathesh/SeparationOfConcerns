using System;
using System.IO;

namespace SeparationOfConcerns.TightlyCoupled.BusinessLogic
{
    public class Worker
    {
        public void DoWork()
        {
            var fileName = $"{DateTime.Now:yyyyMMddHHmmss}.log";
            var file = new FileInfo(fileName);

            var fileStream = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            using (var streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine("TIGHTLY COUPLED - This is a test");
                streamWriter.Close();
            }
        }
    }
}
