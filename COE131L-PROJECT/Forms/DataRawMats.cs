using COE131L_PROJECT.Classes;
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
    public partial class DataRawMats : Form
    {
        public DataRawMats()
        {
            InitializeComponent();
        }
        private void reloadPage()
        {
            if (SQLiteRawMatsClass.CountMenuItemTable() != 0)
            {
                comboBoxType.DataSource = null;
                comboBoxType.Items.Clear();
                comboBoxType.DataSource = SQLiteRawMatsClass.GetMenuItemList();
            }
            if (SQLiteRawMatsClass.CountRawMatsTable() != 0)
            {
                dataGridView1.DataSource = SQLiteRawMatsClass.GetDataRawMats().Tables[0];
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            RawMats temp = new RawMats();
            temp.ShowDialog();
            this.Show();
            reloadPage();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string tempDate = dateTimePicker.Value.ToString();
            SQLiteRawMatsClass.InsertDataRawMats(comboBoxType.SelectedValue.ToString(), tempDate, Convert.ToDecimal(numericUpDownPrice.Value), Convert.ToInt32(numericUpDownQty.Value));
            reloadPage();
            
             if (string.IsNullOrEmpty(comboBoxType.Text))
            {
                MessageBox.Show("Please enter a value in all fields");
            }
            else if(numericUpDownPrice.Value == 0)
            {
                MessageBox.Show("Please enter the price");
            }
            else if(numericUpDownQty.Value == 0)
            {
                MessageBox.Show("Please enter the quantity");
            }
            else
            {
                string tempDate = dateTimePicker.Value.ToString();
                SQLiteExpensesClass.InsertDataExpense(comboBoxType.SelectedValue.ToString(), tempDate, Convert.ToDecimal(numericUpDownPrice.Value), Convert.ToInt32(numericUpDownQty.Value));
                reloadPage();
            }
        
        }
    }
}
