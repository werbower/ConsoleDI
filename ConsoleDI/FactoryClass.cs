using Autofac;
using Library1.Workers;
using Library1.WorkersInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI {
    public class FactoryClass {
        private ILifetimeScope _scope;
        public FactoryClass(ILifetimeScope scope) {
            _scope = scope;
        }
        public IWorker CreateWorker(String typeName) {
            IWorker result = null;
            Type t = null;
            if (typeName == nameof(DateWriter)) {
                t= typeof(DateWriter);
            } else {
                t = typeof(SpecialWorker);
            }

            using(var container = _scope.BeginLifetimeScope()) {
                result = container.Resolve(t) as IWorker;
            }
            return result;
        }
    }
}
