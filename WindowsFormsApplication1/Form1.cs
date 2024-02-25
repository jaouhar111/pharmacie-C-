using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Login_Form l = new Login_Form();
        private void bunifuUserControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            
            Dashboard_UC uc = new Dashboard_UC();
            show_control.Controls.Add(uc);
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void movePanel(Control btn)
        {
            panel3.Top = btn.Top+21;
            panel3.Height = btn.Height;
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            movePanel(dashboard);
            Dashboard_UC uc = new Dashboard_UC();
            show_control.Controls.Clear();
            show_control.Controls.Add(uc);
        }

        private void produits_Click(object sender, EventArgs e)
        {
            movePanel(produits);
            Produit_UC uc = new Produit_UC();
            show_control.Controls.Clear();
            show_control.Controls.Add(uc);
        }

        private void prices_Click(object sender, EventArgs e)
        {
            movePanel(prices);
            Price_UC uc = new Price_UC();
            show_control.Controls.Clear();
            show_control.Controls.Add(uc);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            movePanel(button7);
            Command_UC uc = new Command_UC();
            show_control.Controls.Clear();
            show_control.Controls.Add(uc);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            movePanel(button8);
            Client_UC uc = new Client_UC();
            show_control.Controls.Clear();
            show_control.Controls.Add(uc);
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
