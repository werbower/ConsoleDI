using Autofac;
using Library1.Helpers;
using Library1.HelpersInterfaces;
using Library1.Workers;
using Library1.WorkersInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI {
    class Program {
        private static IContainer Container { get; set; }

        static void Main(string[] args) {
            var builder = new ContainerBuilder();

            builder.RegisterType<FactoryClass>().AsSelf();
            builder.RegisterType<StringWriter>().AsSelf().As<IStringWriter>();
            builder.RegisterType<NumberWriter>().As<INumberWriter>();

            builder.RegisterType<DateWriter>().AsSelf().As<IDateWriter>();
            builder.RegisterType<SpecialWorker>()
                .AsSelf()
                .As<ISpecialWorker>();


            Container = builder.Build();
            //
            MainWrite();

        }

        static void MainWrite() {
            IWorker worker1 = null;
            IWorker worker2 = null;
            using (var container = Container.BeginLifetimeScope()) {
                var factory = container.Resolve<FactoryClass>();

                worker1 = factory.CreateWorker(nameof(SpecialWorker));
                worker2 = factory.CreateWorker(nameof(DateWriter));

            }
            worker1?.DoWork();
            Console.WriteLine("================================");
            worker2?.DoWork();

        }
    }
}
