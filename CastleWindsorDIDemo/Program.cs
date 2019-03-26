﻿using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;

namespace CastleWindsorDIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            container.Register(
                Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>()
            );

            container.Register(
                Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>()
            );

            //container.Register(
            //    Component.For<ISingletonDemo>().ImplementedBy<SingletonDemo>()
            //);

            // This line is not a mistake.  Its intent is to contrast 
            // registering a component as Transient vs. Singleton.
            //
            // The prior example registered this type as a singleton,
            // now we're registering this type as a Transient so the 
            // output will show that new instances of ISingletonDemo are
            // created each time the dependency is fulfilled.

            container.Register(Component.For<ISingletonDemo>().ImplementedBy<SingletonDemo>().LifestyleTransient());


            var root = container.Resolve<ICompositionRoot>();


            root.LogMessage("hello from the first resolved class");

            Console.ReadLine();

        }
    }
}
