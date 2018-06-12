using System.IO;

namespace DesignPattern.Entity.StructuralPatterns.ProxyPattern
{
    public class Writer : IWriter
    {
        private readonly TextWriter _writer;

        public Writer(TextWriter writer)
        {
            _writer = writer;
        }

        public void Write(string message)
        {
            _writer.WriteLine(message);
        }
    }
}