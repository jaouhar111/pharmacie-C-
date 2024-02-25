namespace WindowsFormsApplication1.Crud
{
    partial class ModifierP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierP));
            this.save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.Qte = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Prix = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nomP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.save.Location = new System.Drawing.Point(73, 489);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(161, 44);
            this.save.TabIndex = 35;
            this.save.Text = "  Enregistré";
            this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(26, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 33);
            this.panel2.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 5);
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
            this.DatePicker1.Location = new System.Drawing.Point(31, 429);
            this.DatePicker1.MinimumSize = new System.Drawing.Size(296, 32);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(296, 32);
            this.DatePicker1.TabIndex = 33;
            // 
            // Qte
            // 
            this.Qte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Qte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Qte.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Qte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qte.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Qte.HintForeColor = System.Drawing.Color.DimGray;
            this.Qte.HintText = "Quantité";
            this.Qte.isPassword = false;
            this.Qte.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Qte.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Qte.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Qte.LineThickness = 1;
            this.Qte.Location = new System.Drawing.Point(31, 253);
            this.Qte.Margin = new System.Windows.Forms.Padding(4);
            this.Qte.MaxLength = 32767;
            this.Qte.Name = "Qte";
            this.Qte.Size = new System.Drawing.Size(296, 33);
            this.Qte.TabIndex = 32;
            this.Qte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Prix
            // 
            this.Prix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Prix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Prix.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Prix.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Prix.HintForeColor = System.Drawing.Color.DimGray;
            this.Prix.HintText = "Prix";
            this.Prix.isPassword = false;
            this.Prix.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Prix.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Prix.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Prix.LineThickness = 1;
            this.Prix.Location = new System.Drawing.Point(31, 165);
            this.Prix.Margin = new System.Windows.Forms.Padding(4);
            this.Prix.MaxLength = 32767;
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(296, 33);
            this.Prix.TabIndex = 31;
            this.Prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nomP
            // 
            this.nomP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nomP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nomP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nomP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomP.Enabled = false;
            this.nomP.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomP.HintForeColor = System.Drawing.Color.DimGray;
            this.nomP.HintText = "Produit";
            this.nomP.isPassword = false;
            this.nomP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nomP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nomP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nomP.LineThickness = 1;
            this.nomP.Location = new System.Drawing.Point(31, 77);
            this.nomP.Margin = new System.Windows.Forms.Padding(4);
            this.nomP.MaxLength = 32767;
            this.nomP.Name = "nomP";
            this.nomP.Size = new System.Drawing.Size(296, 33);
            this.nomP.TabIndex = 30;
            this.nomP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nom de Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Categorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Valable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(351, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 560);
            this.panel1.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ModifierP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DatePicker1);
            this.Controls.Add(this.Qte);
            this.Controls.Add(this.Prix);
            this.Controls.Add(this.nomP);
            this.Name = "ModifierP";
            this.Size = new System.Drawing.Size(715, 560);
            this.Load += new System.EventHandler(this.ModifierP_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox nomP;
        public System.Windows.Forms.ComboBox comboBox1;
        public Bunifu.UI.WinForms.BunifuDatePicker DatePicker1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Qte;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Prix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
