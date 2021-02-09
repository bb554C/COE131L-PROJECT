using COE131L_PROJECT.Classes;
using System;
using System.Windows.Forms;

namespace COE131L_PROJECT.Forms
{
    public partial class RawMats : Form
    {
        public RawMats()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SQLiteRawMatsClass.InsertMenuItem(textBoxExpenseType.Text.ToString());
            this.Close();
        }
    }
}
