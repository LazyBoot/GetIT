using System;
using System.IO;

namespace StartList
{
    public class Output : IDisposable
    {
        public StreamWriter StreamWriter { get; }

        public Output(StreamWriter streamWriter)
        {
            StreamWriter = streamWriter;
        }

        public void WriteLine(string str)
        {
            StreamWriter.WriteLine(str);
            Console.WriteLine(str);
        }

        public void Dispose()
        {
            StreamWriter.Close();
        }
    }
}
