using System;
using System.IO;

namespace TestDataWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fStream = new FileStream(@"D:\test.txt", FileMode.OpenOrCreate))
            {
                using var writer = new StreamWriter(fStream);
                var userId = Guid.NewGuid();
                for (int i = 1; i < 100000001; i++)
                {
                    writer.WriteLine(@$"{i},1,1,0,0,'TestFile.docx',0,0,0,'{userId}',2021-08-04 12:40:17,'{userId}',2021-08-04 12:40:17,1,\N,\N,\N,0,0,0");
                }

                writer.Flush();
                fStream.Flush();
            }
        }
    }
}
