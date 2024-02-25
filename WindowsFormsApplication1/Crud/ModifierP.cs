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
    public partial class ModifierP : UserControl
    {
        public ModifierP()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        Class1 c = new Class1();
        Produit_UC uc = null;
        private void save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez Vous Modifier ce Produit ?", "Modifier un Produit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                cmd = new SqlCommand("UPDATE Produits   SET     [DateExpire] = @datep  ,[prix] = @prp   ,[Qte] = @qte  ,[idCategorie] = @nums WHERE [idProduit]=@nump", c.cn);
                cmd.Parameters.AddWithValue("@nump", int.Parse(label6.Text));
                //cmd.Parameters.AddWithValue("@nom", nomP.Text);
                cmd.Parameters.AddWithValue("@prp", float.Parse(Prix.Text));
                cmd.Parameters.AddWithValue("@qte", int.Parse(Qte.Text));
                cmd.Parameters.AddWithValue("@datep", DatePicker1.Value); 
                cmd.Parameters.AddWithValue("@nums", int.Parse(comboBox1.SelectedValue.ToString()));

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();


                //c.ds.Tables["prd"].Clear();
                //c.da.Fill(c.ds, "prd");
                //dbn.DataSource = c.ds.Tables["prd"];
                //dataGridView1.DataSource = dbn;
                //dataGridView1.Refresh();


                MessageBox.Show("Modification avec succès ...");
                //panel7.Visible = false;
                //dataGridView1.Visible = true;

            }
            uc = new Produit_UC();
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        private void ModifierP_Load(object sender, EventArgs e)
        {
            ChargerCombo();
        }

        private void ChargerCombo()
        {
            c.da1.Fill(c.ds, "cmd");
            comboBox1.DataSource = c.ds.Tables["cmd"];
            comboBox1.DisplayMember = "NomCategorie";
            comboBox1.ValueMember = "idCategorie";



            //comboBox3.DataSource = c.ds.Tables["Employee"];
            //comboBox3.DisplayMember = "Nom_Complet";
            //comboBox3.ValueMember = "id";

            //c.da5.Fill(c.ds, "ps1");
            //comboBox1.DataSource = c.ds.Tables["ps1"];
            //comboBox1.DisplayMember = "Nom_Produit";
            //comboBox1.ValueMember = "Produit_id";

            ////comboBox1.Text = label8.Text;
            //comboBox2.Text = label9.Text;


        }
    }
}
