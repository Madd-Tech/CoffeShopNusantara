using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoffeShopNusantara.Models;
using CoffeShopNusantara.Repos;

namespace CoffeShopNusantara.Views.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            MemberRepo memberRepo = new MemberRepo();
            Member member = new Member
            {
                Code = "MBR-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                FullName = textName.Text,
                Email = textEmail.Text,
                Password = textPassword.Text,
                Phone = textPhone.Text,
                Username = textUsername.Text,
                IsDeleted = "0",
            };
            await memberRepo.CreateAsync(member);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhoneAlt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
