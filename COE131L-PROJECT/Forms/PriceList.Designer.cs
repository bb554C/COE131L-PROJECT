
namespace COE131L_PROJECT.Forms
{
    partial class PriceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceList));
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dataGridViewPriceList = new System.Windows.Forms.DataGridView();
            this.numericUpDownMarkup = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarkup)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Lime;
            this.buttonReturn.Location = new System.Drawing.Point(645, 511);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(125, 30);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "RELOAD";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // dataGridViewPriceList
            // 
            this.dataGridViewPriceList.AllowUserToAddRows = false;
            this.dataGridViewPriceList.AllowUserToDeleteRows = false;
            this.dataGridViewPriceList.AllowUserToOrderColumns = true;
            this.dataGridViewPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPriceList.Location = new System.Drawing.Point(12, 17);
            this.dataGridViewPriceList.Name = "dataGridViewPriceList";
            this.dataGridViewPriceList.ReadOnly = true;
            this.dataGridViewPriceList.RowHeadersWidth = 51;
            this.dataGridViewPriceList.RowTemplate.Height = 24;
            this.dataGridViewPriceList.Size = new System.Drawing.Size(758, 482);
            this.dataGridViewPriceList.TabIndex = 3;
            // 
            // numericUpDownMarkup
            // 
            this.numericUpDownMarkup.DecimalPlaces = 2;
            this.numericUpDownMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMarkup.Location = new System.Drawing.Point(201, 517);
            this.numericUpDownMarkup.Name = "numericUpDownMarkup";
            this.numericUpDownMarkup.Size = new System.Drawing.Size(124, 27);
            this.numericUpDownMarkup.TabIndex = 5;
            this.numericUpDownMarkup.ValueChanged += new System.EventHandler(this.numericUpDownMarkup_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Markup Percentage";
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMarkup);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewPriceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PriceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PriceList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarkup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.DataGridView dataGridViewPriceList;
        private System.Windows.Forms.NumericUpDown numericUpDownMarkup;
        private System.Windows.Forms.Label label1;
    }
}