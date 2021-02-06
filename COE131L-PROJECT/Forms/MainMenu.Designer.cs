
namespace COE131L_PROJECT
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonViewInventory = new System.Windows.Forms.Button();
            this.buttonShoppingList = new System.Windows.Forms.Button();
            this.buttonPriceList = new System.Windows.Forms.Button();
            this.buttonOtherExpenses = new System.Windows.Forms.Button();
            this.buttonDataRawMaterials = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BRAMPS RESTAURANT INVENTORY AND PRICING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(277, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonViewInventory
            // 
            this.buttonViewInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewInventory.Location = new System.Drawing.Point(277, 456);
            this.buttonViewInventory.Name = "buttonViewInventory";
            this.buttonViewInventory.Size = new System.Drawing.Size(200, 50);
            this.buttonViewInventory.TabIndex = 2;
            this.buttonViewInventory.Text = "VIEW INVENTORY";
            this.buttonViewInventory.UseVisualStyleBackColor = true;
            this.buttonViewInventory.Click += new System.EventHandler(this.buttonViewInventory_Click);
            // 
            // buttonShoppingList
            // 
            this.buttonShoppingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShoppingList.Location = new System.Drawing.Point(389, 284);
            this.buttonShoppingList.Name = "buttonShoppingList";
            this.buttonShoppingList.Size = new System.Drawing.Size(200, 50);
            this.buttonShoppingList.TabIndex = 3;
            this.buttonShoppingList.Text = "RECCOMMENDED SHOPPING LIST";
            this.buttonShoppingList.UseVisualStyleBackColor = true;
            this.buttonShoppingList.Click += new System.EventHandler(this.buttonShoppingList_Click);
            // 
            // buttonPriceList
            // 
            this.buttonPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPriceList.Location = new System.Drawing.Point(389, 370);
            this.buttonPriceList.Name = "buttonPriceList";
            this.buttonPriceList.Size = new System.Drawing.Size(200, 50);
            this.buttonPriceList.TabIndex = 4;
            this.buttonPriceList.Text = "RECCOMMENDED PRICE LIST";
            this.buttonPriceList.UseVisualStyleBackColor = true;
            this.buttonPriceList.Click += new System.EventHandler(this.buttonPriceList_Click);
            // 
            // buttonOtherExpenses
            // 
            this.buttonOtherExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtherExpenses.Location = new System.Drawing.Point(163, 370);
            this.buttonOtherExpenses.Name = "buttonOtherExpenses";
            this.buttonOtherExpenses.Size = new System.Drawing.Size(200, 50);
            this.buttonOtherExpenses.TabIndex = 5;
            this.buttonOtherExpenses.Text = "INPUT DATA OTHER EXPENSES";
            this.buttonOtherExpenses.UseVisualStyleBackColor = true;
            this.buttonOtherExpenses.Click += new System.EventHandler(this.buttonOtherExpenses_Click);
            // 
            // buttonDataRawMaterials
            // 
            this.buttonDataRawMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataRawMaterials.Location = new System.Drawing.Point(163, 284);
            this.buttonDataRawMaterials.Name = "buttonDataRawMaterials";
            this.buttonDataRawMaterials.Size = new System.Drawing.Size(200, 50);
            this.buttonDataRawMaterials.TabIndex = 6;
            this.buttonDataRawMaterials.Text = "INPUT DATA RAW MATERIALS";
            this.buttonDataRawMaterials.UseVisualStyleBackColor = true;
            this.buttonDataRawMaterials.Click += new System.EventHandler(this.buttonDataRawMaterials_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buttonDataRawMaterials);
            this.Controls.Add(this.buttonOtherExpenses);
            this.Controls.Add(this.buttonPriceList);
            this.Controls.Add(this.buttonShoppingList);
            this.Controls.Add(this.buttonViewInventory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonViewInventory;
        private System.Windows.Forms.Button buttonShoppingList;
        private System.Windows.Forms.Button buttonPriceList;
        private System.Windows.Forms.Button buttonOtherExpenses;
        private System.Windows.Forms.Button buttonDataRawMaterials;
    }
}