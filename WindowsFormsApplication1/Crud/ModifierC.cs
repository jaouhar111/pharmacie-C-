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
    public partial class ModifierC : UserControl
    {
        public ModifierC()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        SqlCommand cmd;
        private void ModifierC_Load(object sender, EventArgs e)
        {
            ChargerCombo();
        }

        private void ChargerCombo()
        {
            c.da5.Fill(c.ds, "client");
            comboBox3.DataSource = c.ds.Tables["client"];
            comboBox3.DisplayMember = "nomPrenom";
            comboBox3.ValueMember = "ID";


            c.da.Fill(c.ds, "Produit");
            comboBox1.DataSource = c.ds.Tables["Produit"];
            comboBox1.DisplayMember = "Produits";
            comboBox1.ValueMember = "Id";

            //c.da5.Fill(c.ds, "ps1");
            //comboBox1.DataSource = c.ds.Tables["ps1"];
            //comboBox1.DisplayMember = "Nom_Produit";
            //comboBox1.ValueMember = "Produit_id";

            ////comboBox1.Text = label8.Text;
            //comboBox2.Text = label9.Text;


        }

        private void save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez Vous Modifier cette Commande ?", "Modifier d'une Commande", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                cmd = new SqlCommand("select prix from Produits where idProduit=@idp", c.cn);
                cmd.Parameters.AddWithValue("@idp", int.Parse(comboBox1.SelectedValue.ToString()));
                cmd.Connection.Open();
                object Obj = cmd.ExecuteScalar();
                float idp = float.Parse(Obj.ToString());
                cmd.Connection.Close();

                float s = idp * float.Parse(Qtc.Text);


                // Modifier La commande
                cmd = new SqlCommand("UPDATE detail   SET     [idProduit] = @idp  ,[Qte] = @Qtc   ,[Somme] = @s  ,[DateCom] = @dateC WHERE [idCommand]=@idc", c.cn);
                cmd.Parameters.AddWithValue("@idc", int.Parse(label1.Text));
                //cmd.Parameters.AddWithValue("@nom", nomP.Text);
                cmd.Parameters.AddWithValue("@s", s);
                cmd.Parameters.AddWithValue("@Qtc", int.Parse(Qtc.Text));
                cmd.Parameters.AddWithValue("@dateC", DatePicker1.Value);
                cmd.Parameters.AddWithValue("@idp", int.Parse(comboBox1.SelectedValue.ToString()));

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                
                //Update in commande
                cmd = new SqlCommand("Update Commande set[idUser]=@idus,[Status]=@stat where [idCommande]=@idc", c.cn);
                cmd.Parameters.AddWithValue("@idc", int.Parse(label1.Text));
                cmd.Parameters.AddWithValue("@idus", int.Parse(comboBox3.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@stat", comboBox2.Text);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();


                MessageBox.Show("Modification avec succès ...");

                Command_UC uc = new Command_UC();
                this.Controls.Clear();
                this.Controls.Add(uc);
                
            }
        }
    }
}
