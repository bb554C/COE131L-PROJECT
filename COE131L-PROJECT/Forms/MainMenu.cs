using COE131L_PROJECT.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COE131L_PROJECT
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonViewInventory_Click(object sender, EventArgs e)
        {

        }

        private void buttonDataRawMaterials_Click(object sender, EventArgs e)
        {

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
