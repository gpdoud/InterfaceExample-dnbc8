using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {

    class HelloInFrench : HelloInLanguage {

        protected override void InitDictionary() {
            this.messages.Add(0, "Prêt");
            this.messages.Add(1, "Bonjour");
            this.messages.Add(2, "Auvoir");
            this.messages[9999] = "";
        }

        public HelloInFrench() : base() {
        }        
    }
}
