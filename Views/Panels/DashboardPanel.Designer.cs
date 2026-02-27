namespace CoffeShopNusantara.Views.Panels
{
    partial class DashboardPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            counterMember = new Panel();
            label2 = new Label();
            label1 = new Label();
            counterStock = new Panel();
            label4 = new Label();
            counterTrx = new Panel();
            label6 = new Label();
            counterRecipe = new Panel();
            label8 = new Label();
            label9 = new Label();
            label3 = new Label();
            label5 = new Label();
            counterMember.SuspendLayout();
            counterStock.SuspendLayout();
            counterTrx.SuspendLayout();
            counterRecipe.SuspendLayout();
            SuspendLayout();
            // 
            // counterMember
            // 
            counterMember.BackColor = Color.DarkCyan;
            counterMember.BorderStyle = BorderStyle.FixedSingle;
            counterMember.Controls.Add(label2);
            counterMember.Controls.Add(label1);
            counterMember.Location = new Point(75, 71);
            counterMember.Name = "counterMember";
            counterMember.Size = new Size(328, 196);
            counterMember.TabIndex = 0;
            counterMember.Paint += counterMember_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(226, 143);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans HK Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(169, 29);
            label1.TabIndex = 4;
            label1.Text = "Jumlah Member";
            // 
            // counterStock
            // 
            counterStock.BackColor = Color.DarkGoldenrod;
            counterStock.BorderStyle = BorderStyle.FixedSingle;
            counterStock.Controls.Add(label9);
            counterStock.Controls.Add(label4);
            counterStock.Location = new Point(75, 328);
            counterStock.Name = "counterStock";
            counterStock.Size = new Size(328, 196);
            counterStock.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(226, 129);
            label4.Name = "label4";
            label4.Size = new Size(26, 30);
            label4.TabIndex = 7;
            label4.Text = "0";
            // 
            // counterTrx
            // 
            counterTrx.BackColor = Color.MediumPurple;
            counterTrx.BorderStyle = BorderStyle.FixedSingle;
            counterTrx.Controls.Add(label3);
            counterTrx.Controls.Add(label6);
            counterTrx.Location = new Point(545, 71);
            counterTrx.Name = "counterTrx";
            counterTrx.Size = new Size(328, 196);
            counterTrx.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(217, 143);
            label6.Name = "label6";
            label6.Size = new Size(26, 30);
            label6.TabIndex = 9;
            label6.Text = "0";
            // 
            // counterRecipe
            // 
            counterRecipe.BackColor = Color.Brown;
            counterRecipe.BorderStyle = BorderStyle.FixedSingle;
            counterRecipe.Controls.Add(label5);
            counterRecipe.Controls.Add(label8);
            counterRecipe.Location = new Point(545, 328);
            counterRecipe.Name = "counterRecipe";
            counterRecipe.Size = new Size(328, 196);
            counterRecipe.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(217, 129);
            label8.Name = "label8";
            label8.Size = new Size(26, 30);
            label8.TabIndex = 11;
            label8.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Noto Sans HK Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Info;
            label9.Location = new Point(18, 24);
            label9.Name = "label9";
            label9.Size = new Size(121, 29);
            label9.TabIndex = 6;
            label9.Text = "Total Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans HK Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(27, 31);
            label3.Name = "label3";
            label3.Size = new Size(183, 29);
            label3.TabIndex = 8;
            label3.Text = "Jumlah Transaksi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Noto Sans HK Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(27, 24);
            label5.Name = "label5";
            label5.Size = new Size(131, 29);
            label5.TabIndex = 10;
            label5.Text = "Total Recipe";
            // 
            // DashboardPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(counterRecipe);
            Controls.Add(counterTrx);
            Controls.Add(counterStock);
            Controls.Add(counterMember);
            Name = "DashboardPanel";
            Size = new Size(1305, 836);
            counterMember.ResumeLayout(false);
            counterMember.PerformLayout();
            counterStock.ResumeLayout(false);
            counterStock.PerformLayout();
            counterTrx.ResumeLayout(false);
            counterTrx.PerformLayout();
            counterRecipe.ResumeLayout(false);
            counterRecipe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel counterMember;
        private Label label2;
        private Label label1;
        private Panel counterStock;
        private Label label4;
        private Panel counterTrx;
        private Label label6;
        private Panel counterRecipe;
        private Label label8;
        private Label label9;
        private Label label3;
        private Label label5;
    }
}
