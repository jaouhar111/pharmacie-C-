namespace WindowsFormsApplication1
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dashboard = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this.dashboard;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard.Location = new System.Drawing.Point(548, 249);
            this.dashboard.Name = "dashboard";
            this.dashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dashboard.Size = new System.Drawing.Size(247, 45);
            this.dashboard.TabIndex = 25;
            this.dashboard.Text = "  Sign In";
            this.dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(951, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Password
            // 
            this.Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.HintForeColor = System.Drawing.Color.Gray;
            this.Password.HintText = "password";
            this.Password.isPassword = true;
            this.Password.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.Password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Password.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.Password.LineThickness = 1;
            this.Password.Location = new System.Drawing.Point(548, 182);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(247, 33);
            this.Password.TabIndex = 24;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // login
            // 
            this.login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.login.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.login.BackColor = System.Drawing.Color.White;
            this.login.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.HintForeColor = System.Drawing.Color.Gray;
            this.login.HintText = "Login";
            this.login.isPassword = false;
            this.login.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.login.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.login.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.login.LineThickness = 1;
            this.login.Location = new System.Drawing.Point(548, 115);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(247, 33);
            this.login.TabIndex = 23;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(615, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sign In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 50;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 50;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(845, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 24);
            this.button4.TabIndex = 28;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 470);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button dashboard;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Button button4;
    }
}