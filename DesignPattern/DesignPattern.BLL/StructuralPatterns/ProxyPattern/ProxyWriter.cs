using System;
using System.IO;
using DesignPattern.Entity.StructuralPatterns.ProxyPattern;

namespace DesignPattern.BLL.StructuralPatterns.ProxyPattern
{
    public class ProxyWriter : IWriter
    {
        private readonly TextWriter _writer;
        private Writer _consoleWriter;

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
            if (_consoleWriter == null) _consoleWriter = new Writer(_writer);
            _consoleWriter.Write(message);
            _writer.Flush();
        }
    }
}