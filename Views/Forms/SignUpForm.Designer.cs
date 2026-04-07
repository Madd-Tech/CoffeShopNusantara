namespace CoffeShopNusantara.Views.Forms
{
    partial class SignUpForm
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
            label1 = new Label();
            textName = new TextBox();
            textPhone = new TextBox();
            label2 = new Label();
            textEmail = new TextBox();
            label3 = new Label();
            textUsername = new TextBox();
            label4 = new Label();
            textPassword = new TextBox();
            label5 = new Label();
            textConfirmPassword = new TextBox();
            label6 = new Label();
            textAddress = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textName
            // 
            textName.Location = new Point(55, 81);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(262, 46);
            textName.TabIndex = 1;
            textName.TextChanged += textBox1_TextChanged;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(452, 81);
            textPhone.Multiline = true;
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(262, 46);
            textPhone.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(452, 46);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 3;
            label2.Text = "Phone";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(55, 198);
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(262, 46);
            textEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 163);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(452, 198);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(262, 46);
            textUsername.TabIndex = 6;
            textUsername.TextChanged += textPhoneAlt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(452, 163);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 7;
            label4.Text = "Username";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(55, 315);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(262, 46);
            textPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 280);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.Location = new Point(452, 315);
            textConfirmPassword.Multiline = true;
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.Size = new Size(262, 46);
            textConfirmPassword.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(452, 280);
            label6.Name = "label6";
            label6.Size = new Size(204, 32);
            label6.TabIndex = 11;
            label6.Text = "Confirm Password";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(55, 436);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(659, 189);
            textAddress.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(55, 401);
            label7.Name = "label7";
            label7.Size = new Size(98, 32);
            label7.TabIndex = 13;
            label7.Text = "Address";
            // 
            // button1
            // 
            button1.Location = new Point(55, 662);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(226, 662);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 15;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 762);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textAddress);
            Controls.Add(label6);
            Controls.Add(textConfirmPassword);
            Controls.Add(label5);
            Controls.Add(textPassword);
            Controls.Add(label4);
            Controls.Add(textUsername);
            Controls.Add(label3);
            Controls.Add(textEmail);
            Controls.Add(label2);
            Controls.Add(textPhone);
            Controls.Add(textName);
            Controls.Add(label1);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private TextBox textPhone;
        private Label label2;
        private TextBox textEmail;
        private Label label3;
        private TextBox textUsername;
        private Label label4;
        private TextBox textPassword;
        private Label label5;
        private TextBox textConfirmPassword;
        private Label label6;
        private TextBox textAddress;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}