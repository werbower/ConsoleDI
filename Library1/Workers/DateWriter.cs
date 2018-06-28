using Library1.HelpersInterfaces;
using Library1.WorkersInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.Workers {
    public class DateWriter : IDateWriter {
        private IStringWriter _writer;

        public DateWriter(IStringWriter writer) {
            _writer = writer;
        }
        public void DoWork() {
            Console.WriteLine("hello from DateWriter!");

            _writer.Write(DateTime.Today.ToShortDateString());
        }
    }
}
