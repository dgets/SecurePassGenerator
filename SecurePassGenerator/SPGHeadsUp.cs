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
        private Dictionary<string, bool> charOpts;

        public PWGMain() {
            //global level init
            charOpts = new Dictionary<string, bool> { { "alphabetic", true }, 
                { "upper", false }, { "numeric", true }, { "symbolic", false } };

            //GUI init
            initClbCharOpts(charOpts);

            InitializeComponent();
        }

        //public static Dictionary<string, bool> CharOpts { get => charOpts; set => charOpts = value; }

        private void initClbCharOpts(Dictionary<string, Boolean> optsSet) {
            foreach (string charOption in charOpts.Keys) {
                if (charOpts[charOption] == true) {
                    clbCharOpts.Items.Add(charOption, true);
                } else {
                    clbCharOpts.Items.Add(charOption, false);
                }
            }
        }
    }
}
