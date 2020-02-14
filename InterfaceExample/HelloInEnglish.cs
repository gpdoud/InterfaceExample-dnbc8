using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {
    class HelloInEnglish : HelloInLanguage {

        protected override void InitDictionary() {
            this.messages.Add(0, "Ready!");
            this.messages.Add(1, "Hello");
            this.messages.Add(2, "Goodbye");
        }

        public HelloInEnglish() : base() {
        }
    }
}
