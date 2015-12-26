namespace MedicalStoreManagementSystem
{
    partial class ReportOption
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
            this.dealerButton = new System.Windows.Forms.Button();
            this.medicineButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dealerButton
            // 
            this.dealerButton.Location = new System.Drawing.Point(223, 185);
            this.dealerButton.Name = "dealerButton";
            this.dealerButton.Size = new System.Drawing.Size(137, 23);
            this.dealerButton.TabIndex = 0;
            this.dealerButton.Text = "Dealer Report";
            this.dealerButton.UseVisualStyleBackColor = true;
            this.dealerButton.Click += new System.EventHandler(this.dealerButton_Click);
            // 
            // medicineButton
            // 
            this.medicineButton.Location = new System.Drawing.Point(223, 276);
            this.medicineButton.Name = "medicineButton";
            this.medicineButton.Size = new System.Drawing.Size(137, 23);
            this.medicineButton.TabIndex = 0;
            this.medicineButton.Text = "Medicine Report";
            this.medicineButton.UseVisualStyleBackColor = true;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(531, 185);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(137, 23);
            this.sellButton.TabIndex = 0;
            this.sellButton.Text = "Sell Report";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(531, 276);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(137, 23);
            this.purchaseButton.TabIndex = 0;
            this.purchaseButton.Text = "Purchase Report";
            this.purchaseButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 82);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(213, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medical Store Management";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ReportOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.medicineButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.dealerButton);
            this.Name = "ReportOption";
            this.Text = "ReportOption";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealerButton;
        private System.Windows.Forms.Button medicineButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}