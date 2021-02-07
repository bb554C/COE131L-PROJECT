using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COE131L_PROJECT.Forms
{
    public partial class DataExpenses : Form
    {
        public DataExpenses()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ExpenseType temp = new ExpenseType();
            temp.ShowDialog();
            this.Show();
        }
    }
}
