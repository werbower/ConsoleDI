using Library1.HelpersInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.Helpers {
    public class StringWriter : IStringWriter {

        public void Write(string content) {
            Console.WriteLine(content);
        }
    }
}
