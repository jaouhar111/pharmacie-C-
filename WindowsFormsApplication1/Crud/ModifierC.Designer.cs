namespace WindowsFormsApplication1.Crud
{
    partial class ModifierC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierC));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.Qtc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Location = new System.Drawing.Point(364, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 33);
            this.panel4.TabIndex = 39;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(7, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(281, 25);
            this.comboBox3.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Location = new System.Drawing.Point(364, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 33);
            this.panel3.TabIndex = 40;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Payé";
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Payé",
            "Non Payé"});
            this.comboBox2.Location = new System.Drawing.Point(7, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 25);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.Text = "Payé";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.Location = new System.Drawing.Point(449, 407);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(125, 35);
            this.save.TabIndex = 41;
            this.save.Text = "Enregistré";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(364, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 33);
            this.panel2.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 25);
            this.comboBox1.TabIndex = 27;
            // 
            // DatePicker1
            // 
            this.DatePicker1.BorderRadius = 1;
            this.DatePicker1.Color = System.Drawing.Color.Transparent;
            this.DatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.DatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.DatePicker1.DisplayWeekNumbers = false;
            this.DatePicker1.DPHeight = 0;
            this.DatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePicker1.FillDatePicker = false;
            this.DatePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.DatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("DatePicker1.Icon")));
            this.DatePicker1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.DatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DatePicker1.Location = new System.Drawing.Point(364, 198);
            this.DatePicker1.MinimumSize = new System.Drawing.Size(296, 32);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(296, 32);
            this.DatePicker1.TabIndex = 37;
            // 
            // Qtc
            // 
            this.Qtc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Qtc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Qtc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Qtc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qtc.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qtc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Qtc.HintForeColor = System.Drawing.Color.Empty;
            this.Qtc.HintText = "Quantité";
            this.Qtc.isPassword = false;
            this.Qtc.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Qtc.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Qtc.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Qtc.LineThickness = 1;
            this.Qtc.Location = new System.Drawing.Point(364, 140);
            this.Qtc.Margin = new System.Windows.Forms.Padding(4);
            this.Qtc.MaxLength = 32767;
            this.Qtc.Name = "Qtc";
            this.Qtc.Size = new System.Drawing.Size(296, 33);
            this.Qtc.TabIndex = 36;
            this.Qtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 560);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // ModifierC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DatePicker1);
            this.Controls.Add(this.Qtc);
            this.Name = "ModifierC";
            this.Size = new System.Drawing.Size(715, 560);
            this.Load += new System.EventHandler(this.ModifierC_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox comboBox3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Qtc;
        public Bunifu.UI.WinForms.BunifuDatePicker DatePicker1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
