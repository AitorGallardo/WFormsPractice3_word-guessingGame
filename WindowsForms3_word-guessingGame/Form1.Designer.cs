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
            this.complexesTxtBox = new System.Windows.Forms.TextBox();
            this.ComplexLabel = new System.Windows.Forms.Label();
            this.normalsTxtBox = new System.Windows.Forms.TextBox();
            this.complexesListBox = new System.Windows.Forms.ListBox();
            this.simplesListBox = new System.Windows.Forms.ListBox();
            this.simplesTxtBox = new System.Windows.Forms.TextBox();
            this.normalLabel = new System.Windows.Forms.Label();
            this.simpleLabel = new System.Windows.Forms.Label();
            this.normalsListBox = new System.Windows.Forms.ListBox();
            this.Joc = new System.Windows.Forms.TabPage();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.tabControlGame.SuspendLayout();
            this.Configuracio.SuspendLayout();
            this.Joc.SuspendLayout();
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
            this.tabControlGame.SelectedIndexChanged += new System.EventHandler(this.tabControlGame_SelectedIndexChanged);
            // 
            // Configuracio
            // 
            this.Configuracio.Controls.Add(this.complexesTxtBox);
            this.Configuracio.Controls.Add(this.ComplexLabel);
            this.Configuracio.Controls.Add(this.normalsTxtBox);
            this.Configuracio.Controls.Add(this.complexesListBox);
            this.Configuracio.Controls.Add(this.simplesListBox);
            this.Configuracio.Controls.Add(this.simplesTxtBox);
            this.Configuracio.Controls.Add(this.normalLabel);
            this.Configuracio.Controls.Add(this.simpleLabel);
            this.Configuracio.Controls.Add(this.normalsListBox);
            this.Configuracio.Location = new System.Drawing.Point(4, 29);
            this.Configuracio.Name = "Configuracio";
            this.Configuracio.Padding = new System.Windows.Forms.Padding(3);
            this.Configuracio.Size = new System.Drawing.Size(768, 393);
            this.Configuracio.TabIndex = 0;
            this.Configuracio.Text = "Configuració";
            this.Configuracio.UseVisualStyleBackColor = true;
            // 
            // complexesTxtBox
            // 
            this.complexesTxtBox.Location = new System.Drawing.Point(554, 174);
            this.complexesTxtBox.Name = "complexesTxtBox";
            this.complexesTxtBox.Size = new System.Drawing.Size(120, 26);
            this.complexesTxtBox.TabIndex = 8;
            this.complexesTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allInputTxtBox_KeyPress);
            // 
            // ComplexLabel
            // 
            this.ComplexLabel.AutoSize = true;
            this.ComplexLabel.Location = new System.Drawing.Point(564, 140);
            this.ComplexLabel.Name = "ComplexLabel";
            this.ComplexLabel.Size = new System.Drawing.Size(101, 20);
            this.ComplexLabel.TabIndex = 5;
            this.ComplexLabel.Text = "P.Complexes";
            // 
            // normalsTxtBox
            // 
            this.normalsTxtBox.Location = new System.Drawing.Point(295, 174);
            this.normalsTxtBox.Name = "normalsTxtBox";
            this.normalsTxtBox.Size = new System.Drawing.Size(120, 26);
            this.normalsTxtBox.TabIndex = 7;
            this.normalsTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allInputTxtBox_KeyPress);
            // 
            // complexesListBox
            // 
            this.complexesListBox.FormattingEnabled = true;
            this.complexesListBox.ItemHeight = 20;
            this.complexesListBox.Items.AddRange(new object[] {
            "GRINYOLAR",
            "ESQUERDAR",
            "ESBIAXAR",
            "AXAFLANAR"});
            this.complexesListBox.Location = new System.Drawing.Point(554, 53);
            this.complexesListBox.Name = "complexesListBox";
            this.complexesListBox.Size = new System.Drawing.Size(120, 84);
            this.complexesListBox.TabIndex = 2;
            // 
            // simplesListBox
            // 
            this.simplesListBox.FormattingEnabled = true;
            this.simplesListBox.ItemHeight = 20;
            this.simplesListBox.Items.AddRange(new object[] {
            "CEC",
            "CRANC",
            "DEU",
            "MES",
            "FIL",
            "MEU",
            "COTXE"});
            this.simplesListBox.Location = new System.Drawing.Point(43, 53);
            this.simplesListBox.Name = "simplesListBox";
            this.simplesListBox.Size = new System.Drawing.Size(120, 84);
            this.simplesListBox.TabIndex = 0;
            // 
            // simplesTxtBox
            // 
            this.simplesTxtBox.Location = new System.Drawing.Point(43, 174);
            this.simplesTxtBox.Name = "simplesTxtBox";
            this.simplesTxtBox.Size = new System.Drawing.Size(120, 26);
            this.simplesTxtBox.TabIndex = 6;
            this.simplesTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allInputTxtBox_KeyPress);
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(308, 140);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(81, 20);
            this.normalLabel.TabIndex = 4;
            this.normalLabel.Text = "P.Normals";
            // 
            // simpleLabel
            // 
            this.simpleLabel.AutoSize = true;
            this.simpleLabel.Location = new System.Drawing.Point(61, 140);
            this.simpleLabel.Name = "simpleLabel";
            this.simpleLabel.Size = new System.Drawing.Size(79, 20);
            this.simpleLabel.TabIndex = 3;
            this.simpleLabel.Text = "P.Simples";
            // 
            // normalsListBox
            // 
            this.normalsListBox.FormattingEnabled = true;
            this.normalsListBox.ItemHeight = 20;
            this.normalsListBox.Items.AddRange(new object[] {
            "LLAPIS",
            "RATOLI",
            "GRIPAU",
            "MOTOS",
            "CADIRA",
            "TAULA",
            "COTXE"});
            this.normalsListBox.Location = new System.Drawing.Point(295, 53);
            this.normalsListBox.Name = "normalsListBox";
            this.normalsListBox.Size = new System.Drawing.Size(120, 84);
            this.normalsListBox.TabIndex = 1;
            // 
            // Joc
            // 
            this.Joc.Controls.Add(this.passwordLabel);
            this.Joc.Controls.Add(this.passwordTxtBox);
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
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(17, 15);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(6, 38);
            this.passwordTxtBox.MaxLength = 10;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 26);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allInputTxtBox_KeyPress);
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
            this.Joc.ResumeLayout(false);
            this.Joc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox word_types;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.TabControl tabControlGame;
        private System.Windows.Forms.TabPage Configuracio;
        private System.Windows.Forms.ListBox normalsListBox;
        private System.Windows.Forms.ListBox complexesListBox;
        private System.Windows.Forms.ListBox simplesListBox;
        private System.Windows.Forms.TabPage Joc;
        private System.Windows.Forms.Label ComplexLabel;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.Label simpleLabel;
        private System.Windows.Forms.TextBox complexesTxtBox;
        private System.Windows.Forms.TextBox normalsTxtBox;
        private System.Windows.Forms.TextBox simplesTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}

