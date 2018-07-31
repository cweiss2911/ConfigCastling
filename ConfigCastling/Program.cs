using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using ConfigCastling.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigCastling
{
    public class Program
    {
        static void Main(string[] args)
        {
            FromAppConfig();
            Fluent();

            Console.ReadLine();
        }

        private static void FromAppConfig()
        {
            WindsorContainer container = new WindsorContainer();
            container.Install(Configuration.FromAppConfig());

            Resolve(container);
        }

        private static void Resolve(WindsorContainer container)
        {
            IClass c = container.Resolve<IClass>();
            c.SaySomething();
        }

        private static void Fluent()
        {
            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<IClass>().ImplementedBy<ClassA>());

            Resolve(container);
        }

    }
}
