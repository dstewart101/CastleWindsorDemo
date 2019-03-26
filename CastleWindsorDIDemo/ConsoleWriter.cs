using System;
using System.Collections.Generic;
using System.Text;

namespace CastleWindsorDIDemo
{
    public class ConsoleWriter : IConsoleWriter
    {

        private readonly ISingletonDemo _singletonDemo;

        public ConsoleWriter(ISingletonDemo singletonDemo)
        {
            _singletonDemo = singletonDemo;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("ConsoleWrite.LogMessage: singletonDemo.ObjectId = {0}"
                , _singletonDemo.ObjectId);
            Console.WriteLine(message);
        }
    }
}
