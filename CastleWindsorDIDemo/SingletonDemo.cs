using System;
using System.Collections.Generic;
using System.Text;

namespace CastleWindsorDIDemo
{
    public class SingletonDemo : ISingletonDemo
    {
        public SingletonDemo()
        {
            ObjectId = Guid.NewGuid();
        }

        public Guid ObjectId { get; }
    }
}
