using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COE131L_PROJECT.Classes;

namespace COE131L_PROJECT
{
    public partial class ShoppingList : Form
    {
        public ShoppingList()
        {
            InitializeComponent();
            reloadPage();
        }
        public void reloadPage()
        {
            dataGridViewShoppingList.DataSource = SQLiteShoppingClass.getData().Tables[0];

        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
