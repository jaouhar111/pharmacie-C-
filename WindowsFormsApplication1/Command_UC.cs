using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Crud;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Command_UC : UserControl
    {
        public Command_UC()
        {
            InitializeComponent();
        }

        BindingSource dbn = new BindingSource();
        Class1 c = new Class1();
        SqlCommand cmd;
        private void Command_UC_Load(object sender, EventArgs e)
        {
            int p=0;
            int np=0;

            c.da4.Fill(c.ds, "cmd");
            int cm = c.ds.Tables["cmd"].Rows.Count;
            dbn.DataSource = c.ds.Tables["cmd"];
            bunifuCustomDataGrid1.DataSource = dbn;
            for (var i = 0; i <= c.ds.Tables["cmd"].Rows.Count - 1; i++)
            {
                if(c.ds.Tables["cmd"].Rows[i][6].ToString()=="Payé")
                {
                    p += 1;
                }

                if (c.ds.Tables["cmd"].Rows[i][6].ToString() == "Non Payé")
                {
                    np += 1;
                }


            }
            

            
            totalcmd.Text = cm.ToString();
            ttcmdp.Text = p.ToString();
            ttcmdnp.Text = np.ToString();
            bunifuCircleProgressbar3.Value = 100;
            bunifuCircleProgressbar2.Value = 100/cm*p;
            bunifuCircleProgressbar1.Value = 100/cm*np;
        }

        AjouterC uc = null;
        private void button4_Click(object sender, EventArgs e)
        {
            uc = new AjouterC();
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        ModifierC mc = null;
        private void button3_Click(object sender, EventArgs e)
        {   //Modifier Commande
            mc = new ModifierC();
            this.Controls.Clear();
            this.Controls.Add(mc);
            mc.comboBox3.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            mc.Qtc.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            mc.DatePicker1.Value = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString());
            //mc.DatePicker1.Value = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString());
            mc.comboBox1.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            mc.label1.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez Vous Supprimer Cette Commande ?", "Supprission d'une Commande", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {

                int nb = int.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString());
                cmd = new SqlCommand("delete Commande where idCommande=@numc", c.cn);
                cmd.Parameters.AddWithValue("@numc", nb);


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                //cmd = new SqlCommand("delete produits where idProduit=@numc", c.cn);
                //cmd.Parameters.AddWithValue("@numc", nb);


                //cmd.Connection.Open();
                //cmd.ExecuteNonQuery();
                //cmd.Connection.Close();


                //c.ds.Tables["prd"].Clear();
                //c.da.Fill(c.ds, "prd");
                //dbn.DataSource = c.ds.Tables["prd"];
                //dataGridView1.DataSource = dbn;
                //dataGridView1.Refresh();

                dbn.RemoveCurrent();
                MessageBox.Show("Supression avec succès ...");

            }
        }
    }
}
