using DesignPattern.Entity.StructuralPatterns.ProxyPattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BLL.StructuralPatterns.ProxyPattern
{
    public class ProxyWriter : IWriter
    {
        private Writer _consoleWriter;
        private TextWriter _writer;
        public ProxyWriter(WriterType writerType)
        {
            switch (writerType)
            {
                case WriterType.File:
                    _writer = new StreamWriter("tmp.txt");
                    break;
                case WriterType.Console:
                    _writer = Console.Out;
                    break;
                default:
                    break;
            }
        }
        public void Write(string message)
        {
            if(_consoleWriter == null)
            {
                _consoleWriter = new Writer(_writer);
            }
            _consoleWriter.Write(message);
            _writer.Flush();
        }
    }
}
