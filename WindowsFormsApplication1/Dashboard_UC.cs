using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Dashboard_UC : UserControl
    {
        public Dashboard_UC()
        {
            InitializeComponent();
        }
        BindingSource dbn = new BindingSource();
        Class1 c = new Class1();
        private void Dashboard_UC_Load(object sender, EventArgs e)
        {
            int s = 0;
            c.da3.Fill(c.ds, "cmd");
            c.da4.Fill(c.ds, "cmds");
            c.da7.Fill(c.ds, "char");
            dbn.DataSource = c.ds.Tables["cmd"];
            bunifuCustomDataGrid1.DataSource = dbn;
            int co = c.ds.Tables["cmd"].Rows.Count;
            label5.Text = co.ToString();
            c.da.Fill(c.ds, "prd");
            int pr = c.ds.Tables["prd"].Rows.Count;
            label4.Text = pr.ToString();
            for (var i = 0; i <= c.ds.Tables["cmds"].Rows.Count - 1; i++)
            {
                s += int.Parse(c.ds.Tables["cmds"].Rows[i][3].ToString());
            }

            label3.Text = s + " DH";
            label6.Text = "En " + DateTime.Now.ToString("MMMM");


            LoadChart();
        }


      
        private void LoadChart()
        {
            
            float s;
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);
           
            
            String d;

            for (int i = 0; i <= 6; i++)
            {
               int s1 = int.Parse(c.ds.Tables["char"].Rows[i][1].ToString());
               s = float.Parse(c.ds.Tables["char"].Rows[i][0].ToString());
              
                d = DateTime.Now.AddDays(i+2).ToString("ddd");
                
               
               
                    dataPoint.addLabely(d, s.ToString());
                
               
            }

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Black);
            bunifuDataViz1.Render(cnv);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
