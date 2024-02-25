using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Crud
{
    public partial class Ajouter_Client : UserControl
    {
        public Ajouter_Client()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        SqlCommand cmd;
        private void save_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Connexion(CNI,NomPrenom,Adresse,dateNaissance,Role)values(@cni,@nom,@adr,@dateN,@role)", c.cn);
            cmd.Parameters.AddWithValue("@cni", cni.Text);
            cmd.Parameters.AddWithValue("@nom", nom.Text);
            cmd.Parameters.AddWithValue("@adr", adr.Text);
            cmd.Parameters.AddWithValue("@dateN", DatePicker1.Value);
            cmd.Parameters.AddWithValue("@role", "Client");


            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



            MessageBox.Show("Enregistrement avec Succées");

            Client_UC uc = new Client_UC();
            this.Controls.Clear();
            this.Controls.Add(uc);
        }
    }
}
