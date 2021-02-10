
namespace COE131L_PROJECT
{
    partial class ShoppingList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingList));
            this.dataGridViewShoppingList = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShoppingList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShoppingList
            // 
            this.dataGridViewShoppingList.AllowUserToAddRows = false;
            this.dataGridViewShoppingList.AllowUserToDeleteRows = false;
            this.dataGridViewShoppingList.AllowUserToOrderColumns = true;
            this.dataGridViewShoppingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShoppingList.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShoppingList.Name = "dataGridViewShoppingList";
            this.dataGridViewShoppingList.ReadOnly = true;
            this.dataGridViewShoppingList.RowHeadersWidth = 51;
            this.dataGridViewShoppingList.RowTemplate.Height = 24;
            this.dataGridViewShoppingList.Size = new System.Drawing.Size(758, 482);
            this.dataGridViewShoppingList.TabIndex = 0;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Lime;
            this.buttonReturn.Location = new System.Drawing.Point(645, 500);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(125, 30);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "RETURN";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewShoppingList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShoppingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShoppingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShoppingList;
        private System.Windows.Forms.Button buttonReturn;
    }
}