using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePassGenerator {
    class Generator {
        public Dictionary<string, string> charSets = new Dictionary<string, string>
            { { "alphaLower", null }, { "alphaUpper", null }, { "symbols", null },
              { "numbers", null } };
        
        private string sourceChars = "";
        private PWGMain mainForm = (PWGMain) Application.OpenForms[0];

        public Generator() {   //should this be in the constructor?
            //global level init
            charSets["alphaLower"] = "abcdefghijklmnopqrstuvwxyz";
            charSets["alphaUpper"] = charSets["alphaLower"].ToUpper();
            charSets["symbols"] = "`~!@#$%^&*()_-+={}[]\\|:;\"'<>,.?/";
            charSets["numbers"] = "0123456789";

            foreach (string ouah in charSets.Keys) {
                if (mainForm.charOpts[ouah] == true) {
                    sourceChars += charSets[ouah];
                }
            }
        }

        public string getNewPW(int totalChars) {
            Random rGen = new Random();
            
            string newPw = "";
            int setLen = sourceChars.Length;

            for (int cntr = 0; cntr < totalChars; cntr++) {
                newPw += sourceChars.ElementAt(rGen.Next(setLen));
            }

            if (mainForm.debugging) {
                MessageBox.Show("Generated '" + newPw + "'");
            }

            return newPw;
        }
    }
}
