using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePassGenerator {
    class Generator {
        public Dictionary<string, string> charSets = new Dictionary<string, string>
            { { "alphaLower", null }, { "alphaUpper", null }, { "symbols", null },
              { "numbers", null } };
        private string sourceChars = "";

        public Generator() {   //should this be in the constructor?
            //global level init
            charSets["alphaLower"] = "abcdefghijklmnopqrstuvwxyz";
            charSets["alphaUpper"] = charSets["alphaLower"].ToUpper();
            charSets["symbols"] = "`~!@#$%^&*()_-+={}[]\\|:;\"'<>,.?/";
            charSets["numbers"] = "0123456789";

            foreach (string ouah in charSets.Keys) {
                if (PWGMain.charOpts[ouah] == true) {
                    
                }
            }
        }
    }
}
