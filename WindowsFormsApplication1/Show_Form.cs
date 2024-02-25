using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Show_Form : Form
    {
        public Show_Form()
        {
            InitializeComponent();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgress1.Value += 2;
            //if (circularProgress1.Value == 100) 
            //{
            //    new IdentificationForm().Show();
            //    timer1.Enabled = false;
            //    this.Hide();
            //}
            label5.Text = "Reading modules..." + circularProgress1.Value + "%";
            if (this.circularProgress1.Value == 10)
            {
                label5.Text = "Reading modules...10%";

                //lblWelcome.Text = "Welcome To Kemodos PIMS";
            }
            label5.Text = "Preparing on modules..." + circularProgress1.Value + "%";
            if (this.circularProgress1.Value == 20)
            {
                label5.Text = "Preparing on modules...20%";
                label1.Visible = true;

            }

            else if (this.circularProgress1.Value == 30)
            {
                label5.Text = "Getting Started on modules...30%";
                label2.Visible = true;
            }
            else if (this.circularProgress1.Value == 40)
            {
                label5.Text = "Loading Started modules....40%";
                //label3.Visible = true;
            }
            else if (this.circularProgress1.Value == 50)
            {
                label5.Text = "Standing on Loading modules...50%";
            }
            else if (this.circularProgress1.Value == 60)
            {
                label5.Text = "Turning on modules...60%";
            }
            else if (this.circularProgress1.Value == 70)
            {
                label5.Text = "Starting modules...70%";

            }
            else if (this.circularProgress1.Value == 80)
            {
                label5.Text = "Loading modules...80%";
                //label4.Visible = true;

            }
            else if (this.circularProgress1.Value == 90)
            {
                label5.Text = "Done Loading modules...90%";

            }
            else if (this.circularProgress1.Value == 100)
            {
                Login_Form ln = new Login_Form();
                ln.Show();
                //new IdentificationForm().Show();
                timer1.Enabled = false;
                this.Hide();
            }

        }

        private void Show_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
