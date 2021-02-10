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

namespace COE131L_PROJECT.Forms
{
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
            reloadPage();
        }
        public void reloadPage()
        {
            dataGridViewPriceList.DataSource = null;
            dataGridViewPriceList.DataSource = SQLitePriceListClass.getData((float)numericUpDownMarkup.Value).Tables[0];
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            reloadPage();
        }

        private void numericUpDownMarkup_ValueChanged(object sender, EventArgs e)
        {
            reloadPage();
        }
    }
}
