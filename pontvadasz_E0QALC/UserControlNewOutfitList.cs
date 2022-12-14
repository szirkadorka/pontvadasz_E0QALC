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
    public partial class UserControlNewOutfitList : UserControl
    {
        OutfitContext context = new OutfitContext();
        public UserControlNewOutfitList()
        {
            InitializeComponent();
        }

        private void textBoxOutfit_TextChanged(object sender, EventArgs e)
        {
            FilterOutfits();

        }

        public class OutfitListDetail
        {
            public int OutfitListSk { get; set; }

            public string ClothesName { get; set; }
        }

        private void FilterOutfits()
        {
            var outfits = from x in context.Outfits
                          where x.OutfitName.Contains(textBoxOutfit.Text)
                          select x;

            listBoxOutfit.DataSource = outfits.ToList();
            listBoxOutfit.DisplayMember = "OutfitName";
        }

        private void textBoxClothes_TextChanged(object sender, EventArgs e)
        {
            FilterClothes();
        }

        private void FilterClothes()
        {
            var clothes = from x in context.Clothes
                          where x.ClothesName.Contains(textBoxClothes.Text)
                          select x;

            listBoxClothes.DataSource = clothes.ToList();
            listBoxClothes.DisplayMember = "ClothesName";
        }

        private void listBoxOutfit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOutfitList();
        }

        private void ListOutfitList()
        {
            var selectedOutfit = (Outfit)listBoxOutfit.SelectedValue;

            var outfitlist = from x in context.OutfitLists
                             where x.OutfitFk == selectedOutfit.OutfitId
                             select new OutfitListDetail
                             {
                                 OutfitListSk = x.OutfitListSk,
                                 ClothesName = x.ClothesFkNavigation.ClothesName
                             };
            listBoxOutfitList.DataSource = outfitlist.ToList();
            listBoxOutfitList.DisplayMember = "ClothesName";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var selectedOutfit = (Outfit)listBoxOutfit.SelectedItem;
            var selectedClothes = (Clothe)listBoxClothes.SelectedItem;

            OutfitList newOutfitList = new OutfitList();
            newOutfitList.OutfitFk = selectedOutfit.OutfitId;
            newOutfitList.ClothesFk = selectedClothes.ClothesId;

            context.OutfitLists.Add(newOutfitList);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListOutfitList();


        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var selectedOutfitList = (OutfitListDetail)listBoxOutfitList.SelectedItem;

            var outfitListToBeDeleted = (from x in context.OutfitLists
                                         where x.OutfitListSk == selectedOutfitList.OutfitListSk
                                         select x).FirstOrDefault();

            context.OutfitLists.Remove(outfitListToBeDeleted);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListOutfitList();
        }
    }
}
