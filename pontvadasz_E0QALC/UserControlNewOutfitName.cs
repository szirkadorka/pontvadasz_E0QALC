using pontvadasz_E0QALC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pontvadasz_E0QALC
{
    public partial class UserControlNewOutfitName : UserControl
    {
        OutfitContext context = new OutfitContext();
        public UserControlNewOutfitName()
        {
            InitializeComponent();
        }

        private void UserControlNewOutfitName_Load(object sender, EventArgs e)
        {
            outfitBindingSource.DataSource = context.Outfits.ToList();
        }

        private void buttonAddNewName_Click(object sender, EventArgs e)
        {
            NewOutfitForm newOutfitForm = new NewOutfitForm();

            if(newOutfitForm.ShowDialog() == DialogResult.OK)
            {
                Outfit outfit = new Outfit();
                outfit.OutfitName = newOutfitForm.textBoxNewName.Text;
                context.Add(outfit);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                outfitBindingSource.DataSource = context.Outfits.ToList();
            }
            else
            {
                MessageBox.Show("Nem történt új adatfelvétel!");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
