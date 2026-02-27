using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoffeShopNusantara.Views.Panels;

namespace CoffeShopNusantara.Views.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new DashboardPanel());

        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new RecipePanel());
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new DashboardPanel());
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new MemberPanel());
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new TransactionPanel());
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new StockPanel());
        }
    }
}
