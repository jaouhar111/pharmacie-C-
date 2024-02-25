using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        Class1 c = new Class1();
        SqlCommand cmd;
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }


        public String s;
        public String s1;
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_Click_1(object sender, EventArgs e)
        {
            Boolean trouver = false;
            for (int i = 0; i < c.ds.Tables["client"].Rows.Count; i++)
            {
                if (login.Text == c.ds.Tables["client"].Rows[i][1].ToString() && Password.Text == c.ds.Tables["client"].Rows[i][2].ToString())
                {
                    trouver = true;
                    s = c.ds.Tables["client"].Rows[i][3].ToString();
                    s1 = c.ds.Tables["client"].Rows[i][4].ToString();
                    break;
                }
            }
            
            if (trouver)
            {
                Form1 f1 = new Form1();
                f1.label3.Text = s;
                f1.label2.Text = s1;
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Identifiant ou Mot de Passe Incorrecte... ");
            }

            


            
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            c.da9.Fill(c.ds, "client");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
