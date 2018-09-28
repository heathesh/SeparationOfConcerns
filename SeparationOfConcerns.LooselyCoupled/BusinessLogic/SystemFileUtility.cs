using System.IO;
using SeparationOfConcerns.LooselyCoupled.Interface;

namespace SeparationOfConcerns.LooselyCoupled.BusinessLogic
{
    public class SystemFileUtility : IFileUtility
    {
        public void WriteToFile(string filename, string text)
        {
            var file = new FileInfo(filename);

            var fileStream = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            using (var streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine(text);
                streamWriter.Close();
            }
        }
    }
}
