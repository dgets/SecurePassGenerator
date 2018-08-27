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
        public Dictionary<string, bool> charOpts = new Dictionary<string, bool>
            { { "alphabetic", true }, { "upper", false }, { "numeric", true },
              { "symbolic", false } };        

        public bool debugging = false;

        public PWGMain() {        
            InitializeComponent();

            //GUI init
            initClbCharOpts();
        }

        private void initClbCharOpts() {
            foreach (string charOption in charOpts.Keys) {
                clbCharOpts.Items.Add(charOption, charOpts[charOption]);
            }
        }

        private void clbCharOpts_OnClick(object sender, EventArgs e) {
            System.Collections.IEnumerator clbCharOptsIterator = 
                clbCharOpts.Items.GetEnumerator();

            while (clbCharOptsIterator.MoveNext()) {
                if (debugging) {
                    MessageBox.Show(clbCharOptsIterator.Current.ToString());
                }

                //it may be a good idea to have a slightly more efficient algorithm here
                if (clbCharOpts.GetItemCheckState(clbCharOpts.Items.IndexOf(
                        clbCharOptsIterator.Current)) == CheckState.Checked) {
                    charOpts[clbCharOptsIterator.Current.ToString()] = true;
                } else {
                    charOpts[clbCharOptsIterator.Current.ToString()] = false;
                }
            }
        }

        private void btnGo_OnClick(object sender, EventArgs e) {
            Generator pwEngine = new Generator();


        }
    }
}
