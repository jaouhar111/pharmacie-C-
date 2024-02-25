using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Price_UC : UserControl
    {
        public Price_UC()
        {
            InitializeComponent();
        }

        Class1 c = new Class1();
        private void Price_UC_Load(object sender, EventArgs e)
        {
            c.da7.Fill(c.ds, "char");
            c.da10.Fill(c.ds, "paye");

            for (int i = 0; i <= c.ds.Tables["paye"].Rows.Count-1; i++)
            { 
                if(i==0)
                {
                    label9.Text = c.ds.Tables["paye"].Rows[i][0].ToString() + " DH";
                }
                else
                    label6.Text = c.ds.Tables["paye"].Rows[i][0].ToString()+" DH";
            }
        }

        private void LoadChart()
        {

            int s;
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);


            String d;

            for (int i = 0; i <= 6; i++)
            {
                int s1 = int.Parse(c.ds.Tables["char"].Rows[i][1].ToString());
                s = int.Parse(c.ds.Tables["char"].Rows[i][0].ToString());

                d = DateTime.Now.AddDays(i).ToString("ddd");
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

    }
}
