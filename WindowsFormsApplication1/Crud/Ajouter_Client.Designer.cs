namespace WindowsFormsApplication1.Crud
{
    partial class Ajouter_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_Client));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cni = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adr = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cni
            // 
            this.cni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cni.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cni.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cni.HintForeColor = System.Drawing.Color.Gray;
            this.cni.HintText = "CNI";
            this.cni.isPassword = false;
            this.cni.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.cni.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.cni.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.cni.LineThickness = 1;
            this.cni.Location = new System.Drawing.Point(403, 121);
            this.cni.Margin = new System.Windows.Forms.Padding(4);
            this.cni.MaxLength = 32767;
            this.cni.Name = "cni";
            this.cni.Size = new System.Drawing.Size(296, 33);
            this.cni.TabIndex = 31;
            this.cni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
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
            this.DatePicker1.Location = new System.Drawing.Point(403, 292);
            this.DatePicker1.MinimumSize = new System.Drawing.Size(296, 32);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(296, 32);
            this.DatePicker1.TabIndex = 34;
            // 
            // nom
            // 
            this.nom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nom.HintForeColor = System.Drawing.Color.Gray;
            this.nom.HintText = "Nom et Prenom";
            this.nom.isPassword = false;
            this.nom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nom.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nom.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nom.LineThickness = 1;
            this.nom.Location = new System.Drawing.Point(403, 178);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.MaxLength = 32767;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(296, 33);
            this.nom.TabIndex = 33;
            this.nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adr
            // 
            this.adr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adr.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adr.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adr.HintForeColor = System.Drawing.Color.Gray;
            this.adr.HintText = "Adresse";
            this.adr.isPassword = false;
            this.adr.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.adr.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.adr.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.adr.LineThickness = 1;
            this.adr.Location = new System.Drawing.Point(403, 235);
            this.adr.Margin = new System.Windows.Forms.Padding(4);
            this.adr.MaxLength = 32767;
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(296, 33);
            this.adr.TabIndex = 32;
            this.adr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.save.Location = new System.Drawing.Point(460, 367);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(164, 44);
            this.save.TabIndex = 36;
            this.save.Text = "Enregistré";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 560);
            this.panel1.TabIndex = 41;
            // 
            // Ajouter_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cni);
            this.Controls.Add(this.DatePicker1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.save);
            this.Name = "Ajouter_Client";
            this.Size = new System.Drawing.Size(715, 560);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuDatePicker DatePicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adr;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel1;
    }
}
