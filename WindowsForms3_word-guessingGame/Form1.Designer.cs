namespace WindowsForms3_word_guessingGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.word_types = new System.Windows.Forms.ComboBox();
            this.startGame = new System.Windows.Forms.Button();
            this.tabControlGame = new System.Windows.Forms.TabControl();
            this.Configuracio = new System.Windows.Forms.TabPage();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.configWordPanel = new System.Windows.Forms.Panel();
            this.ComplexLabel = new System.Windows.Forms.Label();
            this.normalLabel = new System.Windows.Forms.Label();
            this.simpleLabel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Joc = new System.Windows.Forms.TabPage();
            this.configPasswordPanel = new System.Windows.Forms.Panel();
            this.simplesTxtBox = new System.Windows.Forms.TextBox();
            this.normalsTxtBox = new System.Windows.Forms.TextBox();
            this.complexesTxtBox = new System.Windows.Forms.TextBox();
            this.tabControlGame.SuspendLayout();
            this.Configuracio.SuspendLayout();
            this.configWordPanel.SuspendLayout();
            this.Joc.SuspendLayout();
            this.configPasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // word_types
            // 
            this.word_types.Cursor = System.Windows.Forms.Cursors.Hand;
            this.word_types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.word_types.FormattingEnabled = true;
            this.word_types.Items.AddRange(new object[] {
            "Simples",
            "Normals",
            "Complexes"});
            this.word_types.Location = new System.Drawing.Point(447, 25);
            this.word_types.Name = "word_types";
            this.word_types.Size = new System.Drawing.Size(121, 28);
            this.word_types.TabIndex = 0;
            // 
            // startGame
            // 
            this.startGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGame.Location = new System.Drawing.Point(591, 27);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(75, 26);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Start";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // tabControlGame
            // 
            this.tabControlGame.Controls.Add(this.Configuracio);
            this.tabControlGame.Controls.Add(this.Joc);
            this.tabControlGame.Location = new System.Drawing.Point(12, 12);
            this.tabControlGame.Name = "tabControlGame";
            this.tabControlGame.SelectedIndex = 0;
            this.tabControlGame.Size = new System.Drawing.Size(776, 426);
            this.tabControlGame.TabIndex = 3;
            // 
            // Configuracio
            // 
            this.Configuracio.Controls.Add(this.configPasswordPanel);
            this.Configuracio.Controls.Add(this.configWordPanel);
            this.Configuracio.Location = new System.Drawing.Point(4, 29);
            this.Configuracio.Name = "Configuracio";
            this.Configuracio.Padding = new System.Windows.Forms.Padding(3);
            this.Configuracio.Size = new System.Drawing.Size(768, 393);
            this.Configuracio.TabIndex = 0;
            this.Configuracio.Text = "Configuració";
            this.Configuracio.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(305, 71);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(265, 103);
            this.passwordTxtBox.MaxLength = 10;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(153, 26);
            this.passwordTxtBox.TabIndex = 5;
            this.passwordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTxtBox_KeyPress);
            // 
            // configWordPanel
            // 
            this.configWordPanel.AutoSize = true;
            this.configWordPanel.Controls.Add(this.complexesTxtBox);
            this.configWordPanel.Controls.Add(this.normalsTxtBox);
            this.configWordPanel.Controls.Add(this.simplesTxtBox);
            this.configWordPanel.Controls.Add(this.ComplexLabel);
            this.configWordPanel.Controls.Add(this.normalLabel);
            this.configWordPanel.Controls.Add(this.simpleLabel);
            this.configWordPanel.Controls.Add(this.listBox2);
            this.configWordPanel.Controls.Add(this.listBox3);
            this.configWordPanel.Controls.Add(this.listBox1);
            this.configWordPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.configWordPanel.Location = new System.Drawing.Point(0, 36);
            this.configWordPanel.Name = "configWordPanel";
            this.configWordPanel.Size = new System.Drawing.Size(768, 357);
            this.configWordPanel.TabIndex = 3;
            this.configWordPanel.Visible = false;
            // 
            // ComplexLabel
            // 
            this.ComplexLabel.AutoSize = true;
            this.ComplexLabel.Location = new System.Drawing.Point(595, 116);
            this.ComplexLabel.Name = "ComplexLabel";
            this.ComplexLabel.Size = new System.Drawing.Size(101, 20);
            this.ComplexLabel.TabIndex = 5;
            this.ComplexLabel.Text = "P.Complexes";
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(345, 116);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(81, 20);
            this.normalLabel.TabIndex = 4;
            this.normalLabel.Text = "P.Normals";
            // 
            // simpleLabel
            // 
            this.simpleLabel.AutoSize = true;
            this.simpleLabel.Location = new System.Drawing.Point(64, 116);
            this.simpleLabel.Name = "simpleLabel";
            this.simpleLabel.Size = new System.Drawing.Size(79, 20);
            this.simpleLabel.TabIndex = 3;
            this.simpleLabel.Text = "P.Simples";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "LLAPIS",
            "RATOLI",
            "GRIPAU",
            "MOTOS",
            "CADIRA",
            "TAULA",
            "COTXE"});
            this.listBox2.Location = new System.Drawing.Point(324, 18);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 84);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "GRINYOLAR",
            "ESQUERDAR",
            "ESBIAXAR",
            "AXAFLANAR"});
            this.listBox3.Location = new System.Drawing.Point(585, 18);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 84);
            this.listBox3.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "CEC",
            "CRANC",
            "DEU",
            "MES",
            "FIL",
            "MEU",
            "COTXE"});
            this.listBox1.Location = new System.Drawing.Point(43, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            // 
            // Joc
            // 
            this.Joc.Controls.Add(this.word_types);
            this.Joc.Controls.Add(this.startGame);
            this.Joc.Location = new System.Drawing.Point(4, 29);
            this.Joc.Name = "Joc";
            this.Joc.Padding = new System.Windows.Forms.Padding(3);
            this.Joc.Size = new System.Drawing.Size(768, 393);
            this.Joc.TabIndex = 1;
            this.Joc.Text = "Joc";
            this.Joc.UseVisualStyleBackColor = true;
            // 
            // configPasswordPanel
            // 
            this.configPasswordPanel.Controls.Add(this.passwordTxtBox);
            this.configPasswordPanel.Controls.Add(this.passwordLabel);
            this.configPasswordPanel.Location = new System.Drawing.Point(43, 33);
            this.configPasswordPanel.Name = "configPasswordPanel";
            this.configPasswordPanel.Size = new System.Drawing.Size(662, 141);
            this.configPasswordPanel.TabIndex = 8;
            // 
            // simplesTxtBox
            // 
            this.simplesTxtBox.Location = new System.Drawing.Point(43, 151);
            this.simplesTxtBox.Name = "simplesTxtBox";
            this.simplesTxtBox.Size = new System.Drawing.Size(120, 26);
            this.simplesTxtBox.TabIndex = 6;
            // 
            // normalsTxtBox
            // 
            this.normalsTxtBox.Location = new System.Drawing.Point(324, 151);
            this.normalsTxtBox.Name = "normalsTxtBox";
            this.normalsTxtBox.Size = new System.Drawing.Size(120, 26);
            this.normalsTxtBox.TabIndex = 7;
            // 
            // complexesTxtBox
            // 
            this.complexesTxtBox.Location = new System.Drawing.Point(585, 151);
            this.complexesTxtBox.Name = "complexesTxtBox";
            this.complexesTxtBox.Size = new System.Drawing.Size(120, 26);
            this.complexesTxtBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlGame.ResumeLayout(false);
            this.Configuracio.ResumeLayout(false);
            this.Configuracio.PerformLayout();
            this.configWordPanel.ResumeLayout(false);
            this.configWordPanel.PerformLayout();
            this.Joc.ResumeLayout(false);
            this.configPasswordPanel.ResumeLayout(false);
            this.configPasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox word_types;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.TabControl tabControlGame;
        private System.Windows.Forms.TabPage Configuracio;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Panel configWordPanel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage Joc;
        private System.Windows.Forms.Label ComplexLabel;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.Label simpleLabel;
        private System.Windows.Forms.Panel configPasswordPanel;
        private System.Windows.Forms.TextBox complexesTxtBox;
        private System.Windows.Forms.TextBox normalsTxtBox;
        private System.Windows.Forms.TextBox simplesTxtBox;
    }
}

