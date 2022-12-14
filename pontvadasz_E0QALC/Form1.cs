namespace pontvadasz_E0QALC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNewOutfitList_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlNewOutfitList userControlNewOutfitList = new UserControlNewOutfitList();
            panel1.Controls.Add(userControlNewOutfitList);
            panel1.Dock = DockStyle.Fill;
        }

        private void buttonNewOutfitName_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlNewOutfitName userControlNewOutfitName = new UserControlNewOutfitName();
            panel1.Controls.Add(userControlNewOutfitName);
            panel1.Dock = DockStyle.Fill;
        }
    }
}