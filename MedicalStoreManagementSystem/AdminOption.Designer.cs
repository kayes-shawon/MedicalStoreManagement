namespace MedicalStoreManagementSystem
{
    partial class AdminOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOption));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dealerManagementButton = new System.Windows.Forms.Button();
            this.medicineManagementButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.signoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 82);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medical Store Management";
            // 
            // dealerManagementButton
            // 
            this.dealerManagementButton.Location = new System.Drawing.Point(39, 147);
            this.dealerManagementButton.Name = "dealerManagementButton";
            this.dealerManagementButton.Size = new System.Drawing.Size(129, 23);
            this.dealerManagementButton.TabIndex = 1;
            this.dealerManagementButton.Text = "Dealer Management";
            this.dealerManagementButton.UseVisualStyleBackColor = true;
            this.dealerManagementButton.Click += new System.EventHandler(this.dealerManagementButton_Click);
            // 
            // medicineManagementButton
            // 
            this.medicineManagementButton.Location = new System.Drawing.Point(39, 206);
            this.medicineManagementButton.Name = "medicineManagementButton";
            this.medicineManagementButton.Size = new System.Drawing.Size(129, 23);
            this.medicineManagementButton.TabIndex = 2;
            this.medicineManagementButton.Text = "Medicine Management";
            this.medicineManagementButton.UseVisualStyleBackColor = true;
            this.medicineManagementButton.Click += new System.EventHandler(this.medicineManagementButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Location = new System.Drawing.Point(39, 268);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(129, 23);
            this.salesButton.TabIndex = 3;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(190, 147);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(75, 23);
            this.purchaseButton.TabIndex = 4;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(190, 206);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 5;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // signoutButton
            // 
            this.signoutButton.Location = new System.Drawing.Point(190, 268);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(75, 23);
            this.signoutButton.TabIndex = 6;
            this.signoutButton.Text = "Signout";
            this.signoutButton.UseVisualStyleBackColor = true;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 167);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AdminOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signoutButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.medicineManagementButton);
            this.Controls.Add(this.dealerManagementButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminOption";
            this.Text = "AdminOption";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dealerManagementButton;
        private System.Windows.Forms.Button medicineManagementButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button signoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}