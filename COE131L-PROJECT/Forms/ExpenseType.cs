using COE131L_PROJECT.Classes;
using System;
using System.Windows.Forms;

namespace COE131L_PROJECT.Forms
{
    public partial class ExpenseType : Form
    {
        public ExpenseType()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxExpenseType.TextLength != 0)
            {
                SQLiteExpensesClass.InsertExpenseType(textBoxExpenseType.Text.ToString());
                this.Close();
            }
        }
    }
}
