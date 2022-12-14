using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pontvadasz_E0QALC
{
    public partial class NewOutfitForm : Form
    {
        public NewOutfitForm()
        {
            InitializeComponent();
        }

        private bool CheckNewOutfitName(string name)
        {
            return !string.IsNullOrEmpty(name);

            Regex r = new Regex("[a-zA-Z]");
            return r.IsMatch(name);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void textBoxNewName_Validating(object sender, CancelEventArgs e)
        {
            if(!CheckNewOutfitName(textBoxNewName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNewName, "A név nem felel meg a követelményeknek! Nem lehet üresen hagyni, és csak betűk szerepelhetnek benne!");
            }
        }

        private void textBoxNewName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNewName, "");
        }
    }
}
