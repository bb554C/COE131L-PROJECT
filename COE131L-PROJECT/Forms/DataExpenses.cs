﻿using COE131L_PROJECT.Classes;
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
            reloadPage();
        }
        private void reloadPage()
        {
            if (SQLiteExpensesClass.CountDataExpenseTable() != 0)
            {
                comboBoxType.DataSource = null;
                comboBoxType.Items.Clear();
                comboBoxType.DataSource = SQLiteExpensesClass.GetExpenseTypeList();
            }
            if (SQLiteExpensesClass.CountExpenseTypeTable() != 0)
            {
                dataGridView1.DataSource = SQLiteExpensesClass.GetDataExpenses().Tables[0];
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ExpenseType temp = new ExpenseType();
            temp.ShowDialog();
            this.Show();
            reloadPage();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string tempDate = dateTimePicker.Value.ToString();
            SQLiteExpensesClass.InsertDataExpense(comboBoxType.SelectedValue.ToString(), tempDate, Convert.ToDecimal(numericUpDownPrice.Value), Convert.ToInt32(numericUpDownQty.Value));
            reloadPage();
        }
    }
}