using COE131L_PROJECT.Classes;
using COE131L_PROJECT.Forms;
using System;
using System.Windows.Forms;

namespace COE131L_PROJECT
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            SQLiteConnectionClass.DatabaseCheck();
        }

        private void buttonViewInventory_Click(object sender, EventArgs e)
        {
            InventoryForm temp = new InventoryForm();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }

        private void buttonDataRawMaterials_Click(object sender, EventArgs e)
        {
            DataRawMats temp = new DataRawMats();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }

        private void buttonShoppingList_Click(object sender, EventArgs e)
        {
            ShoppingList temp = new ShoppingList();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }

        private void buttonOtherExpenses_Click(object sender, EventArgs e)
        {
            DataExpenses temp = new DataExpenses();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }

        private void buttonPriceList_Click(object sender, EventArgs e)
        {
            PriceList temp = new PriceList();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }
    }
}
