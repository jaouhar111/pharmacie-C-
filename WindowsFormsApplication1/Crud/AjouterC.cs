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
    public partial class AjouterC : UserControl
    {
        public AjouterC()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        Class1 c = new Class1();
        private void AjouterC_Load(object sender, EventArgs e)
        {
            ChargerCombo();
        }

        private void ChargerCombo()
        {
            c.da5.Fill(c.ds, "client");
            comboBox1.DataSource = c.ds.Tables["client"];
            comboBox1.DisplayMember = "nomPrenom";
            comboBox1.ValueMember = "ID";


            c.da.Fill(c.ds, "Produit");
            comboBox3.DataSource = c.ds.Tables["Produit"];
            comboBox3.DisplayMember = "Produits";
            comboBox3.ValueMember = "Id";

            //c.da5.Fill(c.ds, "ps1");
            //comboBox1.DataSource = c.ds.Tables["ps1"];
            //comboBox1.DisplayMember = "Nom_Produit";
            //comboBox1.ValueMember = "Produit_id";

            ////comboBox1.Text = label8.Text;
            //comboBox2.Text = label9.Text;


        }

        Command_UC uc = null;
        private void save_Click(object sender, EventArgs e)
        {
            //Insert in commande
            cmd = new SqlCommand("insert into Commande(idUser,Status)values(@idcl,@stat); SELECT SCOPE_IDENTITY();", c.cn); 
            cmd.Parameters.AddWithValue("@idcl", int.Parse(comboBox1.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@stat", comboBox2.Text);
            cmd.Connection.Open();
            object returnObj = cmd.ExecuteScalar();
            int id = int.Parse(returnObj.ToString());
            cmd.Connection.Close();

            //Insert Somme in detail
            cmd = new SqlCommand("select prix from Produits where idProduit=@idp", c.cn);
            cmd.Parameters.AddWithValue("@idp", int.Parse(comboBox3.SelectedValue.ToString()));
            cmd.Connection.Open();
            object Obj = cmd.ExecuteScalar();
            float prix = float.Parse(Obj.ToString());
            cmd.Connection.Close();

            float s = prix * float.Parse(Qtc.Text);



            //Insert in detail
            cmd = new SqlCommand("insert into detail(idCommand,idProduit,Qte,Somme,DateCom)values(@idc,@idp,@Qte,@somme,@datec)", c.cn);
            cmd.Parameters.AddWithValue("@idc", id);
            cmd.Parameters.AddWithValue("@idp", int.Parse(comboBox3.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@Qte", int.Parse(Qtc.Text));
            cmd.Parameters.AddWithValue("@Somme", s);
            cmd.Parameters.AddWithValue("@datec", DatePicker1.Value);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            MessageBox.Show("Enregistrement avec Succées");



            uc = new Command_UC();
            this.Controls.Clear();
            this.Controls.Add(uc);
        }
    }
}
