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
using WindowsFormsApplication1.Crud;

namespace WindowsFormsApplication1
{
    public partial class Client_UC : UserControl
    {
        public Client_UC()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        BindingSource dbn = new BindingSource();
        SqlCommand cmd;
        private void Client_UC_Load(object sender, EventArgs e)
        {
            c.da8.Fill(c.ds, "client");
            dbn.DataSource = c.ds.Tables["client"];
            bunifuCustomDataGrid1.DataSource = dbn;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez Vous Supprimer Ce Client ?", "Supprission Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {

                int nb = int.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString());
                cmd = new SqlCommand("delete connexion where id=@numc", c.cn);
                cmd.Parameters.AddWithValue("@numc", nb);


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                

                dbn.RemoveCurrent();
                MessageBox.Show("Supression avec succès ...");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ajouter_Client uc = new Ajouter_Client();
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        Modifier_Client uc = new Modifier_Client();
        private void button3_Click(object sender, EventArgs e)
        {
            uc.adr.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            uc.nom.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            uc.DatePicker1.Value = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString());
            
            uc.cni.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            uc.label6.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();


            
            this.Controls.Clear();
            this.Controls.Add(uc);
        }
    }
}
