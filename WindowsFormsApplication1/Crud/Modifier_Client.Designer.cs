namespace WindowsFormsApplication1.Crud
{
    partial class Modifier_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier_Client));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.DatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.adr = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cni = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(375, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 560);
            this.panel1.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Date Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "CNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nom et prénom";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(83, 414);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(161, 44);
            this.save.TabIndex = 53;
            this.save.Text = "  Enregistré";
            this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
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
            this.DatePicker1.Location = new System.Drawing.Point(19, 353);
            this.DatePicker1.MinimumSize = new System.Drawing.Size(296, 32);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(296, 32);
            this.DatePicker1.TabIndex = 51;
            // 
            // adr
            // 
            this.adr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adr.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adr.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adr.HintForeColor = System.Drawing.Color.DimGray;
            this.adr.HintText = "Quantité";
            this.adr.isPassword = false;
            this.adr.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.adr.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.adr.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.adr.LineThickness = 1;
            this.adr.Location = new System.Drawing.Point(19, 253);
            this.adr.Margin = new System.Windows.Forms.Padding(4);
            this.adr.MaxLength = 32767;
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(296, 33);
            this.adr.TabIndex = 50;
            this.adr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nom
            // 
            this.nom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nom.HintForeColor = System.Drawing.Color.DimGray;
            this.nom.HintText = "Prix";
            this.nom.isPassword = false;
            this.nom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nom.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nom.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nom.LineThickness = 1;
            this.nom.Location = new System.Drawing.Point(19, 165);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.MaxLength = 32767;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(296, 33);
            this.nom.TabIndex = 49;
            this.nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cni
            // 
            this.cni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cni.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cni.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cni.HintForeColor = System.Drawing.Color.DimGray;
            this.cni.HintText = "Produit";
            this.cni.isPassword = false;
            this.cni.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.cni.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.cni.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.cni.LineThickness = 1;
            this.cni.Location = new System.Drawing.Point(19, 77);
            this.cni.Margin = new System.Windows.Forms.Padding(4);
            this.cni.MaxLength = 32767;
            this.cni.Name = "cni";
            this.cni.Size = new System.Drawing.Size(296, 33);
            this.cni.TabIndex = 48;
            this.cni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Modifier_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.DatePicker1);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.cni);
            this.Name = "Modifier_Client";
            this.Size = new System.Drawing.Size(715, 560);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        public Bunifu.UI.WinForms.BunifuDatePicker DatePicker1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox adr;
        public Bunifu.Framework.UI.BunifuMaterialTextbox nom;
        public Bunifu.Framework.UI.BunifuMaterialTextbox cni;
    }
}
