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
    public partial class AjouterP : UserControl
    {
        public AjouterP()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        SqlCommand cmd;
        
        private void AjouterP_Load(object sender, EventArgs e)
        {
            ChargerCombo();
        }

        Produit_UC uc = null;
       

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

        private void save_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Produits(NomProduit,Prix,Qte,idCategorie,DateExpire)values(@nomp,@prp,@Qte,@idc,@datep)", c.cn);
            cmd.Parameters.AddWithValue("@nomp", nomP.Text);
            cmd.Parameters.AddWithValue("@prp", float.Parse(prP.Text));
            cmd.Parameters.AddWithValue("@Qte", int.Parse(qteP.Text));
            cmd.Parameters.AddWithValue("@idc", int.Parse(comboBox1.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@datep", DatePicker1.Value);


            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



            MessageBox.Show("Enregistrement avec Succées");
            uc = new Produit_UC();
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void prP_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void qteP_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void DatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nomP_OnValueChanged(object sender, EventArgs e)
        {

        }


        

        
    }
}
