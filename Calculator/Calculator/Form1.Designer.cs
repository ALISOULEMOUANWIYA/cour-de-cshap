namespace Calculator
{
    partial class Andy
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Andy));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalculatorSimple = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCovertiseur = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalculatorSci = new Guna.UI2.WinForms.Guna2Button();
            this.imageSlider = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnMin = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelheurMinute = new System.Windows.Forms.Label();
            this.labelSeconde = new System.Windows.Forms.Label();
            this.labelJour = new System.Windows.Forms.Label();
            this.labelMoisDateAnne = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.uC_CalculeSci1 = new Calculator.UserControls.UC_CalculeSci();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnCalculatorSimple);
            this.panelMenu.Controls.Add(this.BtnCovertiseur);
            this.panelMenu.Controls.Add(this.btnCalculatorSci);
            this.panelMenu.Controls.Add(this.imageSlider);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(92, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 20;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.Checked = true;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnHome.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnHome.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.CheckedState.Image")));
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(7, 277);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(72, 39);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseTransparentBackground = true;
            this.btnHome.CheckedChanged += new System.EventHandler(this.btnCalculatorSimple_CheckedChanged);
            // 
            // btnCalculatorSimple
            // 
            this.btnCalculatorSimple.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculatorSimple.BorderRadius = 15;
            this.btnCalculatorSimple.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCalculatorSimple.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCalculatorSimple.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCalculatorSimple.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculatorSimple.CheckedState.Image")));
            this.btnCalculatorSimple.CheckedState.Parent = this.btnCalculatorSimple;
            this.btnCalculatorSimple.CustomImages.Parent = this.btnCalculatorSimple;
            this.btnCalculatorSimple.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCalculatorSimple.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalculatorSimple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCalculatorSimple.HoverState.Parent = this.btnCalculatorSimple;
            this.btnCalculatorSimple.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculatorSimple.Image")));
            this.btnCalculatorSimple.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCalculatorSimple.Location = new System.Drawing.Point(7, 330);
            this.btnCalculatorSimple.Name = "btnCalculatorSimple";
            this.btnCalculatorSimple.ShadowDecoration.Parent = this.btnCalculatorSimple;
            this.btnCalculatorSimple.Size = new System.Drawing.Size(72, 39);
            this.btnCalculatorSimple.TabIndex = 5;
            this.btnCalculatorSimple.UseTransparentBackground = true;
            this.btnCalculatorSimple.CheckedChanged += new System.EventHandler(this.btnCalculatorSimple_CheckedChanged);
            // 
            // BtnCovertiseur
            // 
            this.BtnCovertiseur.BackColor = System.Drawing.Color.Transparent;
            this.BtnCovertiseur.BorderRadius = 15;
            this.BtnCovertiseur.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCovertiseur.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnCovertiseur.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnCovertiseur.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("BtnCovertiseur.CheckedState.Image")));
            this.BtnCovertiseur.CheckedState.Parent = this.BtnCovertiseur;
            this.BtnCovertiseur.CustomImages.Parent = this.BtnCovertiseur;
            this.BtnCovertiseur.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnCovertiseur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCovertiseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnCovertiseur.HoverState.Parent = this.BtnCovertiseur;
            this.BtnCovertiseur.Image = ((System.Drawing.Image)(resources.GetObject("BtnCovertiseur.Image")));
            this.BtnCovertiseur.ImageOffset = new System.Drawing.Point(-1, 0);
            this.BtnCovertiseur.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnCovertiseur.Location = new System.Drawing.Point(7, 433);
            this.BtnCovertiseur.Name = "BtnCovertiseur";
            this.BtnCovertiseur.ShadowDecoration.Parent = this.BtnCovertiseur;
            this.BtnCovertiseur.Size = new System.Drawing.Size(72, 39);
            this.BtnCovertiseur.TabIndex = 4;
            this.BtnCovertiseur.UseTransparentBackground = true;
            this.BtnCovertiseur.CheckedChanged += new System.EventHandler(this.btnCalculatorSimple_CheckedChanged);
            // 
            // btnCalculatorSci
            // 
            this.btnCalculatorSci.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculatorSci.BorderRadius = 15;
            this.btnCalculatorSci.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCalculatorSci.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCalculatorSci.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCalculatorSci.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculatorSci.CheckedState.Image")));
            this.btnCalculatorSci.CheckedState.Parent = this.btnCalculatorSci;
            this.btnCalculatorSci.CustomImages.Parent = this.btnCalculatorSci;
            this.btnCalculatorSci.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCalculatorSci.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalculatorSci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCalculatorSci.HoverState.Parent = this.btnCalculatorSci;
            this.btnCalculatorSci.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculatorSci.Image")));
            this.btnCalculatorSci.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCalculatorSci.Location = new System.Drawing.Point(7, 382);
            this.btnCalculatorSci.Name = "btnCalculatorSci";
            this.btnCalculatorSci.ShadowDecoration.Parent = this.btnCalculatorSci;
            this.btnCalculatorSci.Size = new System.Drawing.Size(72, 39);
            this.btnCalculatorSci.TabIndex = 3;
            this.btnCalculatorSci.UseTransparentBackground = true;
            this.btnCalculatorSci.CheckedChanged += new System.EventHandler(this.btnCalculatorSimple_CheckedChanged);
            // 
            // imageSlider
            // 
            this.imageSlider.BackColor = System.Drawing.Color.Transparent;
            this.imageSlider.Image = ((System.Drawing.Image)(resources.GetObject("imageSlider.Image")));
            this.imageSlider.Location = new System.Drawing.Point(57, 243);
            this.imageSlider.Name = "imageSlider";
            this.imageSlider.Size = new System.Drawing.Size(35, 105);
            this.imageSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageSlider.TabIndex = 2;
            this.imageSlider.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.CheckedState.Image")));
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.HoverState.Image")));
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(352, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnMin.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnMin.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.CheckedState.Image")));
            this.btnMin.CheckedState.Parent = this.btnMin;
            this.btnMin.CustomImages.Parent = this.btnMin;
            this.btnMin.FillColor = System.Drawing.Color.Transparent;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMin.ForeColor = System.Drawing.Color.Transparent;
            this.btnMin.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMin.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnMin.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.HoverState.Image")));
            this.btnMin.HoverState.Parent = this.btnMin;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(322, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.ShadowDecoration.Parent = this.btnMin;
            this.btnMin.Size = new System.Drawing.Size(26, 28);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseTransparentBackground = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.guna2TextBox1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(92, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 36);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBox1.Location = new System.Drawing.Point(4, 5);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.PlaceholderText = "Searche";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(127, 25);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Andy~Amy Calculator";
            // 
            // labelheurMinute
            // 
            this.labelheurMinute.AutoSize = true;
            this.labelheurMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelheurMinute.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheurMinute.ForeColor = System.Drawing.Color.White;
            this.labelheurMinute.Location = new System.Drawing.Point(288, 39);
            this.labelheurMinute.Name = "labelheurMinute";
            this.labelheurMinute.Size = new System.Drawing.Size(39, 16);
            this.labelheurMinute.TabIndex = 7;
            this.labelheurMinute.Text = "00:00";
            // 
            // labelSeconde
            // 
            this.labelSeconde.AutoSize = true;
            this.labelSeconde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelSeconde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconde.ForeColor = System.Drawing.Color.White;
            this.labelSeconde.Location = new System.Drawing.Point(324, 39);
            this.labelSeconde.Name = "labelSeconde";
            this.labelSeconde.Size = new System.Drawing.Size(21, 16);
            this.labelSeconde.TabIndex = 9;
            this.labelSeconde.Text = "00";
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelJour.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJour.ForeColor = System.Drawing.Color.White;
            this.labelJour.Location = new System.Drawing.Point(404, 137);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(42, 16);
            this.labelJour.TabIndex = 10;
            this.labelJour.Text = "Jeudi";
            // 
            // labelMoisDateAnne
            // 
            this.labelMoisDateAnne.AutoSize = true;
            this.labelMoisDateAnne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelMoisDateAnne.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoisDateAnne.ForeColor = System.Drawing.Color.White;
            this.labelMoisDateAnne.Location = new System.Drawing.Point(121, 137);
            this.labelMoisDateAnne.Name = "labelMoisDateAnne";
            this.labelMoisDateAnne.Size = new System.Drawing.Size(104, 16);
            this.labelMoisDateAnne.TabIndex = 11;
            this.labelMoisDateAnne.Text = "Janvier 06 2020";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // uC_CalculeSci1
            // 
            this.uC_CalculeSci1.BackColor = System.Drawing.Color.White;
            this.uC_CalculeSci1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_CalculeSci1.Location = new System.Drawing.Point(92, 36);
            this.uC_CalculeSci1.Name = "uC_CalculeSci1";
            this.uC_CalculeSci1.SigneResultat = 0;
            this.uC_CalculeSci1.Size = new System.Drawing.Size(384, 664);
            this.uC_CalculeSci1.TabIndex = 12;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panelMenu;
            // 
            // Andy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(476, 700);
            this.Controls.Add(this.labelSeconde);
            this.Controls.Add(this.labelheurMinute);
            this.Controls.Add(this.labelMoisDateAnne);
            this.Controls.Add(this.labelJour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uC_CalculeSci1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Andy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andy~Amy Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox imageSlider;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnCovertiseur;
        private Guna.UI2.WinForms.Guna2Button btnCalculatorSci;
        private Guna.UI2.WinForms.Guna2Button btnCalculatorSimple;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnMin;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMoisDateAnne;
        private System.Windows.Forms.Label labelJour;
        private System.Windows.Forms.Label labelSeconde;
        private System.Windows.Forms.Label labelheurMinute;
        private System.Windows.Forms.Timer timer;
        private UserControls.UC_CalculeSci uC_CalculeSci1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

