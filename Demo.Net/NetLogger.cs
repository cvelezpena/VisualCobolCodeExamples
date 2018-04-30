using System;
using Demo.Cobol.Interfaces;

namespace Demo.Net
{
    public class NetLogger : ICobolLogger
    {
        private int _errorCounter;

        public string UserId { get; set; }

        public NetLogger()
        {
            _errorCounter = 0;
        }

        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public void Warning(string msg)
        {
            Console.WriteLine("WARN  {0}({1}): {2}", _errorCounter, UserId, msg);
        }

        public void Error(string msg)
        {
            _errorCounter++;
            Console.WriteLine("ERROR {0}({1}): {2}", _errorCounter, UserId, msg);
        }
    }
}