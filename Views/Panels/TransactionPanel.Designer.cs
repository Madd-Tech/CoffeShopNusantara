namespace CoffeShopNusantara.Views.Panels
{
    partial class TransactionPanel
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
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(453, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(67, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(451, 178);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(314, 31);
            dateTimePicker2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(768, 97);
            button1.Name = "button1";
            button1.Size = new Size(160, 34);
            button1.TabIndex = 3;
            button1.Text = "New Transaction";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(816, 175);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Proceed";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 150);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 5;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 150);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 6;
            label2.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 97);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 7;
            label3.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(899, 229);
            dataGridView1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(633, 97);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 9;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TransactionPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Name = "TransactionPanel";
            Size = new Size(1305, 836);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button3;
    }
}
