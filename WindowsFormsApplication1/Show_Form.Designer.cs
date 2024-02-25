namespace WindowsFormsApplication1
{
    partial class Show_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularProgress1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(39, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pharmacy Agdal";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(43, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenue sur Pharmacy Solution";
            this.label2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.label5.Location = new System.Drawing.Point(87, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Qu\'est-ce que le Lorem Ipsum?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularProgress1
            // 
            this.circularProgress1.animated = true;
            this.circularProgress1.animationIterval = 5;
            this.circularProgress1.animationSpeed = 300;
            this.circularProgress1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgress1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularProgress1.BackgroundImage")));
            this.circularProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circularProgress1.ForeColor = System.Drawing.Color.SeaGreen;
            this.circularProgress1.LabelVisible = false;
            this.circularProgress1.LineProgressThickness = 3;
            this.circularProgress1.LineThickness = 2;
            this.circularProgress1.Location = new System.Drawing.Point(35, 425);
            this.circularProgress1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circularProgress1.MaxValue = 100;
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circularProgress1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.circularProgress1.Size = new System.Drawing.Size(48, 48);
            this.circularProgress1.TabIndex = 18;
            this.circularProgress1.Value = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 50;
            this.bunifuElipse3.TargetControl = this;
            // 
            // Show_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Form";
            this.Load += new System.EventHandler(this.Show_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circularProgress1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}