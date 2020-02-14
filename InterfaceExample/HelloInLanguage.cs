using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {
    abstract class HelloInLanguage : ISpeakable {

        protected Dictionary<int, string> messages = new Dictionary<int, string> {
            [9999] = "Message number not found"
        };

        protected abstract void InitDictionary();
        
        public virtual string GetMessage(int MessageNumber) {
            if(!messages.ContainsKey(MessageNumber)) {
                return messages[9999];
            }
            return messages[MessageNumber];
        }

        public HelloInLanguage() {
            InitDictionary();
        }

    }
}
