using Library1.HelpersInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.Helpers {
    public class NumberWriter : INumberWriter {

        public void WriteNumber(int i) {
            Console.WriteLine("It is number " + i);
        }
    }
}
