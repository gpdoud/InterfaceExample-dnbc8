using System;
using System.Collections.Generic;

namespace InterfaceExample {
    class Program {
        static void Main(string[] args) {

            var english = new HelloInEnglish();
            var spanish = new HelloInSpanish();

            var hello = new Hello(english);
            hello.Speak();
            var hello2 = new Hello(spanish);
            hello2.Speak();

            var hellofr = new Hello(new HelloInFrench());
            hellofr.Speak();

            (new Hello(new HelloInLatin())).Speak();

        }
        static void TestInterfaceWidgets() { 

            var w1 = new Widget();
            var aw = new AdvWidget();
            var sw = new SuperWidget();

            var widgets = new List<IPrintable>();
            widgets.Add(w1);
            widgets.Add(aw);
            widgets.Add(sw);

            foreach(var widget in widgets) {
                widget.Print();
            }

        }
    }
}
