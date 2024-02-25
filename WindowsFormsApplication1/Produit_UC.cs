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
    public partial class Produit_UC : UserControl
    {
        public Produit_UC()
        {
            InitializeComponent();
        }

        BindingSource dbn = new BindingSource();
        Class1 c = new Class1();
        SqlCommand cmd;
        private void Produit_UC_Load(object sender, EventArgs e)
        {
            produitCat();

            c.da.Fill(c.ds, "prd");
            dbn.DataSource = c.ds.Tables["prd"];
            bunifuCustomDataGrid1.DataSource = dbn;
            
            //bunifuCustomDataGrid1.DataSource = dbn;

            c.da2.Fill(c.ds, "cat");
            //dbn.DataSource = c.ds.Tables["cat"];

            int co = 0;

            for (var i = 0; i <= c.ds.Tables["cat"].Rows.Count-1; i++)
            {
                if(i==0)
                {
                co = int.Parse(c.ds.Tables["cat"].Rows[i][0].ToString());
                label4.Text = c.ds.Tables["cat"].Rows[i][2].ToString();
                bunifuProgressBar1.Value = co;
                label16.Text = co.ToString()+"%";
                }

                if (i == 1)
                {
                    co = int.Parse(c.ds.Tables["cat"].Rows[i][0].ToString());
                    label5.Text = c.ds.Tables["cat"].Rows[i][2].ToString();
                    bunifuProgressBar2.Value = co;
                    label17.Text = co.ToString() + "%";
                }

                if (i == 2)
                {
                    co = int.Parse(c.ds.Tables["cat"].Rows[i][0].ToString());
                    label6.Text = c.ds.Tables["cat"].Rows[i][2].ToString();
                    bunifuProgressBar3.Value = co;
                    label18.Text = co.ToString() + "%";
                }

                if (i == 3)
                {
                    co = int.Parse(c.ds.Tables["cat"].Rows[i][0].ToString());
                    label7.Text = c.ds.Tables["cat"].Rows[i][2].ToString();
                    bunifuProgressBar4.Value = co;
                    label19.Text = co.ToString() + "%";
                }

                if (i ==4)
                {
                    co = int.Parse(c.ds.Tables["cat"].Rows[i][0].ToString());
                    label8.Text = c.ds.Tables["cat"].Rows[i][2].ToString();
                    bunifuProgressBar5.Value = co;
                    label20.Text = co.ToString() + "%";
                }

                if (i == 5)
                {
                    co = int.Parse(c.ds.Tables["cat"].Rows[i][0].ToString());
                    label9.Text = c.ds.Tables["cat"].Rows[i][2].ToString();
                    bunifuProgressBar6.Value = co;
                    label21.Text = co.ToString() + "%";
                }
                
                 
            }
                





                //break;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        AjouterP uc = null;
        ModifierP mp = null;
        private void button4_Click(object sender, EventArgs e)
        {
            
            //AjouterP p = new AjouterP();
           
            //f.show_control.Controls.Add(p);
            uc = new AjouterP();
            this.Controls.Clear();
            this.Controls.Add(uc);
            //Produit_UC p = new Produit_UC();
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Modifier Produits
            mp = new ModifierP();
            this.Controls.Clear();
            this.Controls.Add(mp);
            mp.nomP.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            mp.Qte.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            mp.Prix.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            mp.DatePicker1.Value =DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString());
            mp.comboBox1.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            mp.label6.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez Vous Supprimer Ce Produit ?", "Supprission du Produit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {

                int nb = int.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString());
                cmd = new SqlCommand("delete detail where idProduit=@numc", c.cn);
                cmd.Parameters.AddWithValue("@numc", nb);


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                cmd = new SqlCommand("delete produits where idProduit=@numc", c.cn);
                cmd.Parameters.AddWithValue("@numc", nb);


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();


                //c.ds.Tables["prd"].Clear();
                //c.da.Fill(c.ds, "prd");
                //dbn.DataSource = c.ds.Tables["prd"];
                //dataGridView1.DataSource = dbn;
                //dataGridView1.Refresh();

                dbn.RemoveCurrent();
                MessageBox.Show("Supression avec succès ...");

            }
        }

        public void produitCat()
        {
            
            
            c.da6.Fill(c.ds, "prq");
            for (var i = 0; i <= c.ds.Tables["prq"].Rows.Count -1; i++)
            {
                String nm = c.ds.Tables["prq"].Rows[i][0].ToString();
                int q = int.Parse(c.ds.Tables["prq"].Rows[i][1].ToString());

                if(int.Parse(c.ds.Tables["prq"].Rows[i][1].ToString())<=5 && i==0)
                {
                    label10.Visible = true; bunifuTileButton1.Visible = true;
                    label10.Text="Approvisionner "+nm+" reste "+q;
                    bunifuTileButton1.color = Color.Orange;

                }
                if (int.Parse(c.ds.Tables["prq"].Rows[i][1].ToString()) <= 5 && i==1)
                {
                    label11.Visible = true; bunifuTileButton2.Visible = true;
                    label11.Text = "Approvisionner " + nm + " reste " + q;
                    bunifuTileButton2.color = Color.Orange;

                }
                if (int.Parse(c.ds.Tables["prq"].Rows[i][1].ToString()) <= 5 && i == 2)
                {
                    label12.Visible = true; bunifuTileButton3.Visible = true;
                    label12.Text = "Approvisionner " + nm + " reste " + q;
                    bunifuTileButton3.color = Color.Orange;

                }

                if (int.Parse(c.ds.Tables["prq"].Rows[i][1].ToString()) <= 5 && i == 4)
                {
                    label13.Visible = true; bunifuTileButton4.Visible = true;
                    label13.Text = "Approvisionner " + nm + " reste " + q;
                    bunifuTileButton4.color = Color.Orange;

                }

                if (int.Parse(c.ds.Tables["prq"].Rows[i][1].ToString()) <= 5 && i == 5)
                {
                    label14.Visible = true; bunifuTileButton5.Visible = true;
                    label14.Text = "Approvisionner " + nm + " reste " + q;
                    bunifuTileButton5.color = Color.Orange;

                }
                if (int.Parse(c.ds.Tables["prq"].Rows[i][1].ToString()) <= 5 && i == 6)
                {
                    label15.Visible = true; bunifuTileButton6.Visible = true;
                    label15.Text = "Approvisionner " + nm + " reste " + q;
                    bunifuTileButton6.color = Color.Orange;

                }
                
            }

        }
    }
}
