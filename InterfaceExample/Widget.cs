using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {
    
    class Widget : IPrintable {

        public void Print() {
            Console.WriteLine("Widget");
        }
    }
}
