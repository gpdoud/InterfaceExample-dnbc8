using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {

    class HelloInLatin : HelloInLanguage {

        protected override void InitDictionary() {
            this.messages.Add(0, "Paratus");
            this.messages.Add(1, "Salve");
            this.messages.Add(2, "Vale");
        }

        public HelloInLatin() : base() {
        }
    }
}
