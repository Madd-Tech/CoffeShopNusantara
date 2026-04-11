using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoffeShopNusantara.Models;
using CoffeShopNusantara.Repos;
using CoffeShopNusantara.Utility;

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
           
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var validation = new Validation();
                validation.isValidTexts(textUsername.Text, textPassword.Text);
                validation.isMatchTexts(textPassword.Text, textConfirmPassword.Text);


                var memberRepo = new MemberRepo();
                var member = new Member
                {
                
                    FullName = textName.Text,
                    Email = textEmail.Text,
                    Password = textPassword.Text,
                    Phone = textPhone.Text,
                    Username = textUsername.Text,
                    IsDeleted = "0",
                    LastUpdate = DateTime.Now,
                    Code = "MBR-" + Guid.NewGuid().ToString("N").Substring(0, 8)
                };
                var id = await memberRepo.CreateAsync(member);
                if (id > 0)
                {
                    MessageBox.Show("Sign Up Success");
                    this.Hide();
                    var form1 = new Form1();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Sign Up Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhoneAlt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
