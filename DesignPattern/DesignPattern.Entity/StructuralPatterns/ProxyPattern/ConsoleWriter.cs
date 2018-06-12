using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.StructuralPatterns.ProxyPattern
{
    public class Writer : IWriter
    {
        private TextWriter _writer;
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
