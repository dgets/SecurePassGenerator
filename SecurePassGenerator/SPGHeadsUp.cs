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
        //settings
        private Dictionary<string, bool> charOpts = new Dictionary<string, bool>
            { { "alphabetic", true }, { "upper", false }, { "numeric", true }, 
              { "symbolic", false } };

        public PWGMain() {
            InitializeComponent();

            //global level init
            //GUI init
            initClbCharOpts();
        }

        private void initClbCharOpts() {
            foreach (string charOption in charOpts.Keys) {
                clbCharOpts.Items.Add(charOption, charOpts[charOption]);
            }
        }
    }
}
