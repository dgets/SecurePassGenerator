using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurePassGenerator
{
    public partial class PWGMain : Form {
        public PWGMain() {
            //init
            Dictionary<string, bool> charOpts = 
                new Dictionary<string, bool> { { "alphabetic", true }, 
                    { "upper", false }, { "numeric", true }, 
                    { "symbolic", false } };

            InitializeComponent();

            //GUI init
            initClbCharOpts(charOpts);
        }

        //public static Dictionary<string, bool> CharOpts { get => charOpts; set => charOpts = value; }

        private void initClbCharOpts(Dictionary<string, Boolean> optsSet) {
            foreach (string charOption in optsSet.Keys) {
                if (optsSet[charOption] == true) {
                    clbCharOpts.Items.Add(charOption, true);
                } else {
                    clbCharOpts.Items.Add(charOption, false);
                }
            }
        }
    }
}
