using System;
using System.Collections.Generic;
using System.Text;

namespace CastleWindsorDIDemo
{
    public class CompositionRoot : ICompositionRoot
    {

        private readonly IConsoleWriter _consoleWriter;
        private readonly ISingletonDemo _singletonDemo;

        public CompositionRoot(
            IConsoleWriter consoleWriter,
            ISingletonDemo singletonDemo
            
            )
        {
            _singletonDemo = singletonDemo;
            _consoleWriter = consoleWriter;
            _consoleWriter.LogMessage("Hello from CompositionRoot Constructor!");
        }

        public void LogMessage(string message)
        {
            var msg = $"CompositionRoot.LogMessage:  singletonDemo.ObjectId={_singletonDemo.ObjectId}";
            _consoleWriter.LogMessage(msg);
            _consoleWriter.LogMessage(message);
        }
    }
}
