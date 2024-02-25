namespace WindowsFormsApplication1.Crud
{
    partial class AjouterP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterP));
            this.DatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.prP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.qteP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nomP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.DatePicker1.Location = new System.Drawing.Point(393, 273);
            this.DatePicker1.MinimumSize = new System.Drawing.Size(296, 32);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(296, 32);
            this.DatePicker1.TabIndex = 23;
            this.DatePicker1.ValueChanged += new System.EventHandler(this.DatePicker1_ValueChanged);
            // 
            // prP
            // 
            this.prP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.prP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.prP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.prP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prP.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prP.HintForeColor = System.Drawing.Color.Empty;
            this.prP.HintText = "Quantité";
            this.prP.isPassword = false;
            this.prP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.prP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.prP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.prP.LineThickness = 1;
            this.prP.Location = new System.Drawing.Point(393, 159);
            this.prP.Margin = new System.Windows.Forms.Padding(4);
            this.prP.MaxLength = 32767;
            this.prP.Name = "prP";
            this.prP.Size = new System.Drawing.Size(296, 33);
            this.prP.TabIndex = 22;
            this.prP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prP.OnValueChanged += new System.EventHandler(this.prP_OnValueChanged);
            // 
            // qteP
            // 
            this.qteP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.qteP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.qteP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.qteP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qteP.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qteP.HintForeColor = System.Drawing.Color.Empty;
            this.qteP.HintText = "Prix";
            this.qteP.isPassword = false;
            this.qteP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.qteP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.qteP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.qteP.LineThickness = 1;
            this.qteP.Location = new System.Drawing.Point(393, 216);
            this.qteP.Margin = new System.Windows.Forms.Padding(4);
            this.qteP.MaxLength = 32767;
            this.qteP.Name = "qteP";
            this.qteP.Size = new System.Drawing.Size(296, 33);
            this.qteP.TabIndex = 21;
            this.qteP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.qteP.OnValueChanged += new System.EventHandler(this.qteP_OnValueChanged);
            // 
            // nomP
            // 
            this.nomP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nomP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nomP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nomP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomP.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomP.HintForeColor = System.Drawing.Color.Empty;
            this.nomP.HintText = "Produit";
            this.nomP.isPassword = false;
            this.nomP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nomP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nomP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.nomP.LineThickness = 1;
            this.nomP.Location = new System.Drawing.Point(393, 102);
            this.nomP.Margin = new System.Windows.Forms.Padding(4);
            this.nomP.MaxLength = 32767;
            this.nomP.Name = "nomP";
            this.nomP.Size = new System.Drawing.Size(296, 33);
            this.nomP.TabIndex = 19;
            this.nomP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nomP.OnValueChanged += new System.EventHandler(this.nomP_OnValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 25);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(393, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 33);
            this.panel2.TabIndex = 28;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
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
            this.save.Location = new System.Drawing.Point(454, 411);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(164, 44);
            this.save.TabIndex = 29;
            this.save.Text = "Enregistré";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 560);
            this.panel1.TabIndex = 31;
            // 
            // AjouterP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DatePicker1);
            this.Controls.Add(this.prP);
            this.Controls.Add(this.qteP);
            this.Controls.Add(this.nomP);
            this.Name = "AjouterP";
            this.Size = new System.Drawing.Size(715, 560);
            this.Load += new System.EventHandler(this.AjouterP_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDatePicker DatePicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox qteP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nomP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
