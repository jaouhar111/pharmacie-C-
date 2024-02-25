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
    public partial class Modifier_Client : UserControl
    {
        public Modifier_Client()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        Class1 c = new Class1();
        private void save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez Vous Modifier ce Client ?", "Modifier Client", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                cmd = new SqlCommand("UPDATE Connexion   SET     [cni] = @cni  ,[NomPrenom] = @prp   ,[Adresse] = @adr  ,[dateNaissance] = @datep WHERE [id]=@nump", c.cn);
                cmd.Parameters.AddWithValue("@nump", int.Parse(label6.Text));
                cmd.Parameters.AddWithValue("@prp", nom.Text);
                cmd.Parameters.AddWithValue("@adr", adr.Text);
                cmd.Parameters.AddWithValue("@datep", DatePicker1.Value);
                cmd.Parameters.AddWithValue("@cni", cni.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();


                


                MessageBox.Show("Modification avec succès ...");
                

            }
            Client_UC uc = new Client_UC();
            this.Controls.Clear();
            this.Controls.Add(uc);
        }
    }
}
