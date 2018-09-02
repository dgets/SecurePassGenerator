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
            { { "alphaLower", true }, { "alphaUpper", false }, 
              { "numbers", true }, { "symbols", false } };        

        public bool debugging = false;

        public PWGMain() {        
            InitializeComponent();

            //GUI init
            initClbCharOpts();

            //just for debugging
            if (debugging) {
                //longer passwords mean more data to work with
                nudCharNums.Value = 128;
            }
        }

        private void initClbCharOpts() {
            foreach (string charOption in charOpts.Keys) {
                clbCharOpts.Items.Add(charOption, charOpts[charOption]);
            }
        }

        private void btnGo_OnClick(object sender, EventArgs e) {
            probeNSetPWSet();

            Generator pwEngine = new Generator();

            //lblPWField.Text = pwEngine.getNewPW((int)nudCharNums.Value);
            tbxPWField.Text = pwEngine.getNewPW((int)nudCharNums.Value);
        }

        private void probeNSetPWSet() {
            /*foreach (string charOption in charOpts.Keys) {
                charOpts[charOption] = clbCharOpts.GetItemChecked(
                    clbCharOpts.Items.IndexOf(charOption));
            }*/

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

        private void btnCopyToClipboard_Click(object sender, EventArgs e) {
            //has a password been generated?
            if (tbxPWField.Text.Equals("Your new password will soon be here")) {
                MessageBox.Show("You must first generate a new password!",
                    "No Password Created", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Clipboard.SetText(tbxPWField.Text);
            MessageBox.Show("Your password has been copied to the clipboard!",
                "Copied to clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
