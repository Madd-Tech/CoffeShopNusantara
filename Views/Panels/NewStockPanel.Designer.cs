namespace CoffeShopNusantara.Views.Panels
{
    partial class NewStockPanel
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 78);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Item Code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 106);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 46);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 189);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(55, 217);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 46);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 311);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 4;
            label3.Text = "Measurement";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 426);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 6;
            label4.Text = "Qty";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(55, 454);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 46);
            textBox4.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pieces", "Gram", "Mililiter" });
            comboBox1.Location = new Point(55, 339);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 33);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(55, 551);
            button1.Name = "button1";
            button1.Size = new Size(131, 44);
            button1.TabIndex = 9;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(216, 551);
            button2.Name = "button2";
            button2.Size = new Size(131, 44);
            button2.TabIndex = 10;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(403, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(548, 489);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // NewStockPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "NewStockPanel";
            Size = new Size(1121, 789);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
