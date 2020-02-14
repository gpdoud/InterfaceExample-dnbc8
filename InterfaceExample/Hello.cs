using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {

    public class Hello {

        ISpeakable Language;

        public void Speak() {
            Console.WriteLine($"Ready:   {Language.GetMessage(0)}");
            Console.WriteLine($"Hello:   {Language.GetMessage(1)}");
            Console.WriteLine($"GoodBye: {Language.GetMessage(2)}");
            Console.WriteLine($"BadMsg:  {Language.GetMessage(3)}");
        }

        public Hello(ISpeakable language) {
            Language = language;
        }
    }
}
