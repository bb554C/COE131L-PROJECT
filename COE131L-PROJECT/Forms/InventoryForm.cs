using System;
using System.Windows.Forms;
using COE131L_PROJECT.Classes;

namespace COE131L_PROJECT.Forms
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
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
            if (SQLiteInventoryClass.CountInventoryTable() != 0)
            {
                dataGridView.DataSource = SQLiteInventoryClass.GetDataInventory().Tables[0];
            }
            numericUpDownQty.Value = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(SQLiteInventoryClass.getCurrentStock(comboBoxType.SelectedValue.ToString())-Convert.ToInt32(numericUpDownQty.Value) >= 0 )
            {
                SQLiteInventoryClass.updateStock(-Convert.ToInt32(numericUpDownQty.Value), comboBoxType.SelectedValue.ToString());
                SQLiteInventoryClass.InsertSalesItem(comboBoxType.SelectedValue.ToString(), Convert.ToInt32(numericUpDownQty.Value), dateTimePicker.Value.ToString("MM/dd/yyyy"));
                reloadPage();
            }
            else
            {
                MessageBox.Show("ERROR: Stock can't be a negative number","Inventory ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
