using COE131L_PROJECT.Classes;
using System;
using System.Windows.Forms;

namespace COE131L_PROJECT.Forms
{
    public partial class DataRawMats : Form
    {
        public DataRawMats()
        {
            InitializeComponent();
            reloadPage();
        }
        private void reloadPage()
        {
            dateTimePicker.MaxDate = DateTime.Today;
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
            comboBoxType.SelectedIndex = 0;
            numericUpDownPrice.Value = 0;
            numericUpDownQty.Value = 0;
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
            string tempDate = dateTimePicker.Value.ToString("MM/dd/yyyy");
            SQLiteRawMatsClass.InsertDataRawMats(comboBoxType.SelectedValue.ToString(), tempDate, Convert.ToDecimal(numericUpDownPrice.Value), Convert.ToInt32(numericUpDownQty.Value));
            SQLiteInventoryClass.updateStock(Convert.ToInt32(numericUpDownQty.Value), comboBoxType.SelectedValue.ToString());
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
