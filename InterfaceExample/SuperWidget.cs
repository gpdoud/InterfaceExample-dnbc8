using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {
    
    class SuperWidget : IPrintable {

        public void Print() {
            Console.WriteLine("SuperWidget");

        }
    }
}
