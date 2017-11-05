namespace GalaxyWar
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.buttonPlanet = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.panelObjectsCreation = new System.Windows.Forms.Panel();
            this.labelOrganic = new System.Windows.Forms.Label();
            this.labelCarbon = new System.Windows.Forms.Label();
            this.labelMetal = new System.Windows.Forms.Label();
            this.numericCarbon = new System.Windows.Forms.NumericUpDown();
            this.numericOrganic = new System.Windows.Forms.NumericUpDown();
            this.numericMetal = new System.Windows.Forms.NumericUpDown();
            this.panelCivilizationCreation = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCiv = new System.Windows.Forms.Label();
            this.buttonCivilization = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelObjectsCreation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCarbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrganic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMetal)).BeginInit();
            this.panelCivilizationCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(248, 263);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // buttonPlanet
            // 
            this.buttonPlanet.Location = new System.Drawing.Point(3, 12);
            this.buttonPlanet.Name = "buttonPlanet";
            this.buttonPlanet.Size = new System.Drawing.Size(117, 23);
            this.buttonPlanet.TabIndex = 1;
            this.buttonPlanet.Text = "Planet";
            this.buttonPlanet.UseVisualStyleBackColor = true;
            this.buttonPlanet.Click += new System.EventHandler(this.buttonPlanet_Click);
            // 
            // buttonStar
            // 
            this.buttonStar.Enabled = false;
            this.buttonStar.Location = new System.Drawing.Point(126, 12);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(117, 23);
            this.buttonStar.TabIndex = 2;
            this.buttonStar.Text = "Star";
            this.buttonStar.UseVisualStyleBackColor = true;
            this.buttonStar.Click += new System.EventHandler(this.buttonStar_Click);
            // 
            // panelObjectsCreation
            // 
            this.panelObjectsCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelObjectsCreation.Controls.Add(this.labelOrganic);
            this.panelObjectsCreation.Controls.Add(this.labelCarbon);
            this.panelObjectsCreation.Controls.Add(this.labelMetal);
            this.panelObjectsCreation.Controls.Add(this.numericCarbon);
            this.panelObjectsCreation.Controls.Add(this.numericOrganic);
            this.panelObjectsCreation.Controls.Add(this.numericMetal);
            this.panelObjectsCreation.Controls.Add(this.buttonPlanet);
            this.panelObjectsCreation.Controls.Add(this.buttonStar);
            this.panelObjectsCreation.Location = new System.Drawing.Point(12, 281);
            this.panelObjectsCreation.Name = "panelObjectsCreation";
            this.panelObjectsCreation.Size = new System.Drawing.Size(248, 161);
            this.panelObjectsCreation.TabIndex = 3;
            // 
            // labelOrganic
            // 
            this.labelOrganic.AutoSize = true;
            this.labelOrganic.Location = new System.Drawing.Point(3, 120);
            this.labelOrganic.Name = "labelOrganic";
            this.labelOrganic.Size = new System.Drawing.Size(44, 13);
            this.labelOrganic.TabIndex = 8;
            this.labelOrganic.Text = "Organic";
            // 
            // labelCarbon
            // 
            this.labelCarbon.AutoSize = true;
            this.labelCarbon.Location = new System.Drawing.Point(3, 94);
            this.labelCarbon.Name = "labelCarbon";
            this.labelCarbon.Size = new System.Drawing.Size(41, 13);
            this.labelCarbon.TabIndex = 7;
            this.labelCarbon.Text = "Carbon";
            // 
            // labelMetal
            // 
            this.labelMetal.AutoSize = true;
            this.labelMetal.Location = new System.Drawing.Point(3, 68);
            this.labelMetal.Name = "labelMetal";
            this.labelMetal.Size = new System.Drawing.Size(33, 13);
            this.labelMetal.TabIndex = 6;
            this.labelMetal.Text = "Metal";
            // 
            // numericCarbon
            // 
            this.numericCarbon.Location = new System.Drawing.Point(123, 92);
            this.numericCarbon.Name = "numericCarbon";
            this.numericCarbon.Size = new System.Drawing.Size(120, 20);
            this.numericCarbon.TabIndex = 5;
            // 
            // numericOrganic
            // 
            this.numericOrganic.Location = new System.Drawing.Point(123, 118);
            this.numericOrganic.Name = "numericOrganic";
            this.numericOrganic.Size = new System.Drawing.Size(120, 20);
            this.numericOrganic.TabIndex = 4;
            // 
            // numericMetal
            // 
            this.numericMetal.Location = new System.Drawing.Point(123, 66);
            this.numericMetal.Name = "numericMetal";
            this.numericMetal.Size = new System.Drawing.Size(120, 20);
            this.numericMetal.TabIndex = 3;
            // 
            // panelCivilizationCreation
            // 
            this.panelCivilizationCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCivilizationCreation.Controls.Add(this.comboBox1);
            this.panelCivilizationCreation.Controls.Add(this.labelCiv);
            this.panelCivilizationCreation.Controls.Add(this.buttonCivilization);
            this.panelCivilizationCreation.Location = new System.Drawing.Point(12, 448);
            this.panelCivilizationCreation.Name = "panelCivilizationCreation";
            this.panelCivilizationCreation.Size = new System.Drawing.Size(248, 104);
            this.panelCivilizationCreation.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // labelCiv
            // 
            this.labelCiv.AutoSize = true;
            this.labelCiv.Location = new System.Drawing.Point(3, 68);
            this.labelCiv.Name = "labelCiv";
            this.labelCiv.Size = new System.Drawing.Size(46, 13);
            this.labelCiv.TabIndex = 6;
            this.labelCiv.Text = "Strategy";
            // 
            // buttonCivilization
            // 
            this.buttonCivilization.Location = new System.Drawing.Point(3, 12);
            this.buttonCivilization.Name = "buttonCivilization";
            this.buttonCivilization.Size = new System.Drawing.Size(240, 23);
            this.buttonCivilization.TabIndex = 1;
            this.buttonCivilization.Text = "Civilization";
            this.buttonCivilization.UseVisualStyleBackColor = true;
            this.buttonCivilization.Click += new System.EventHandler(this.buttonCivilization_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 568);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(248, 23);
            this.buttonNew.TabIndex = 11;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 597);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(248, 23);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 626);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(248, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 682);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.panelCivilizationCreation);
            this.Controls.Add(this.panelObjectsCreation);
            this.Controls.Add(this.groupBoxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GalaxyWar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panelObjectsCreation.ResumeLayout(false);
            this.panelObjectsCreation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCarbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrganic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMetal)).EndInit();
            this.panelCivilizationCreation.ResumeLayout(false);
            this.panelCivilizationCreation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Button buttonPlanet;
        private System.Windows.Forms.Button buttonStar;
        private System.Windows.Forms.Panel panelObjectsCreation;
        private System.Windows.Forms.NumericUpDown numericCarbon;
        private System.Windows.Forms.NumericUpDown numericOrganic;
        private System.Windows.Forms.NumericUpDown numericMetal;
        private System.Windows.Forms.Label labelOrganic;
        private System.Windows.Forms.Label labelCarbon;
        private System.Windows.Forms.Label labelMetal;
        private System.Windows.Forms.Panel panelCivilizationCreation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelCiv;
        private System.Windows.Forms.Button buttonCivilization;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
    }
}

