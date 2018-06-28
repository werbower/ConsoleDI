using Library1.HelpersInterfaces;
using Library1.WorkersInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.Workers {
    public class SpecialWorker:ISpecialWorker {
        private IStringWriter _stringWriter;
        private INumberWriter _numberWriter;

        public SpecialWorker(IStringWriter stringWriter,INumberWriter numberWriter) {
            _stringWriter = stringWriter;
            _numberWriter = numberWriter;

        }

        public void DoWork() {
            _stringWriter.Write("From Special worker: hello");
            _numberWriter.WriteNumber(1000);
        }
    }
}
