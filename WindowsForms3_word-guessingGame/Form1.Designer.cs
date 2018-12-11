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
            this.word_types_game = new System.Windows.Forms.ComboBox();
            this.startGame = new System.Windows.Forms.Button();
            this.tabControlGame = new System.Windows.Forms.TabControl();
            this.Configuracio = new System.Windows.Forms.TabPage();
            this.word_types_config = new System.Windows.Forms.ComboBox();
            this.ComplexLabel = new System.Windows.Forms.Label();
            this.newWordTxtBox = new System.Windows.Forms.TextBox();
            this.complexesListBox = new System.Windows.Forms.ListBox();
            this.simplesListBox = new System.Windows.Forms.ListBox();
            this.normalLabel = new System.Windows.Forms.Label();
            this.simpleLabel = new System.Windows.Forms.Label();
            this.normalsListBox = new System.Windows.Forms.ListBox();
            this.Joc = new System.Windows.Forms.TabPage();
            this.hangPictureBox = new System.Windows.Forms.PictureBox();
            this.userInputTxtBox = new System.Windows.Forms.TextBox();
            this.wordToSolve = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.tabControlGame.SuspendLayout();
            this.Configuracio.SuspendLayout();
            this.Joc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // word_types_game
            // 
            this.word_types_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.word_types_game.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.word_types_game.FormattingEnabled = true;
            this.word_types_game.Items.AddRange(new object[] {
            "Simples",
            "Normals",
            "Complexes"});
            this.word_types_game.Location = new System.Drawing.Point(298, 16);
            this.word_types_game.Margin = new System.Windows.Forms.Padding(2);
            this.word_types_game.Name = "word_types_game";
            this.word_types_game.Size = new System.Drawing.Size(82, 21);
            this.word_types_game.TabIndex = 0;
            // 
            // startGame
            // 
            this.startGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGame.Location = new System.Drawing.Point(394, 18);
            this.startGame.Margin = new System.Windows.Forms.Padding(2);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(50, 24);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Start";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // tabControlGame
            // 
            this.tabControlGame.Controls.Add(this.Configuracio);
            this.tabControlGame.Controls.Add(this.Joc);
            this.tabControlGame.Location = new System.Drawing.Point(8, 8);
            this.tabControlGame.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlGame.Name = "tabControlGame";
            this.tabControlGame.SelectedIndex = 0;
            this.tabControlGame.Size = new System.Drawing.Size(517, 277);
            this.tabControlGame.TabIndex = 3;
            this.tabControlGame.SelectedIndexChanged += new System.EventHandler(this.tabControlGame_SelectedIndexChanged);
            // 
            // Configuracio
            // 
            this.Configuracio.Controls.Add(this.word_types_config);
            this.Configuracio.Controls.Add(this.ComplexLabel);
            this.Configuracio.Controls.Add(this.newWordTxtBox);
            this.Configuracio.Controls.Add(this.complexesListBox);
            this.Configuracio.Controls.Add(this.simplesListBox);
            this.Configuracio.Controls.Add(this.normalLabel);
            this.Configuracio.Controls.Add(this.simpleLabel);
            this.Configuracio.Controls.Add(this.normalsListBox);
            this.Configuracio.Location = new System.Drawing.Point(4, 22);
            this.Configuracio.Margin = new System.Windows.Forms.Padding(2);
            this.Configuracio.Name = "Configuracio";
            this.Configuracio.Padding = new System.Windows.Forms.Padding(2);
            this.Configuracio.Size = new System.Drawing.Size(509, 251);
            this.Configuracio.TabIndex = 0;
            this.Configuracio.Text = "Configuració";
            this.Configuracio.UseVisualStyleBackColor = true;
            // 
            // word_types_config
            // 
            this.word_types_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.word_types_config.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.word_types_config.FormattingEnabled = true;
            this.word_types_config.Items.AddRange(new object[] {
            "Simples",
            "Normals",
            "Complexes"});
            this.word_types_config.Location = new System.Drawing.Point(305, 186);
            this.word_types_config.Margin = new System.Windows.Forms.Padding(2);
            this.word_types_config.Name = "word_types_config";
            this.word_types_config.Size = new System.Drawing.Size(82, 21);
            this.word_types_config.TabIndex = 8;
            // 
            // ComplexLabel
            // 
            this.ComplexLabel.AutoSize = true;
            this.ComplexLabel.Location = new System.Drawing.Point(366, 19);
            this.ComplexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ComplexLabel.Name = "ComplexLabel";
            this.ComplexLabel.Size = new System.Drawing.Size(68, 13);
            this.ComplexLabel.TabIndex = 5;
            this.ComplexLabel.Text = "P.Complexes";
            // 
            // newWordTxtBox
            // 
            this.newWordTxtBox.Location = new System.Drawing.Point(159, 186);
            this.newWordTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.newWordTxtBox.Name = "newWordTxtBox";
            this.newWordTxtBox.Size = new System.Drawing.Size(119, 20);
            this.newWordTxtBox.TabIndex = 7;
            this.newWordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTxtBoxInputs_KeyPress);
            // 
            // complexesListBox
            // 
            this.complexesListBox.FormattingEnabled = true;
            this.complexesListBox.Items.AddRange(new object[] {
            "GRINYOLAR",
            "ESQUERDAR",
            "ESBIAXAR",
            "AXAFLANAR"});
            this.complexesListBox.Location = new System.Drawing.Point(369, 48);
            this.complexesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.complexesListBox.Name = "complexesListBox";
            this.complexesListBox.Size = new System.Drawing.Size(81, 95);
            this.complexesListBox.TabIndex = 2;
            // 
            // simplesListBox
            // 
            this.simplesListBox.FormattingEnabled = true;
            this.simplesListBox.Items.AddRange(new object[] {
            "CEC",
            "CRANC",
            "DEU",
            "MES",
            "FIL",
            "MEU",
            "COTXE"});
            this.simplesListBox.Location = new System.Drawing.Point(29, 48);
            this.simplesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.simplesListBox.Name = "simplesListBox";
            this.simplesListBox.Size = new System.Drawing.Size(81, 95);
            this.simplesListBox.TabIndex = 0;
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(194, 19);
            this.normalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(55, 13);
            this.normalLabel.TabIndex = 4;
            this.normalLabel.Text = "P.Normals";
            // 
            // simpleLabel
            // 
            this.simpleLabel.AutoSize = true;
            this.simpleLabel.Location = new System.Drawing.Point(26, 19);
            this.simpleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.simpleLabel.Name = "simpleLabel";
            this.simpleLabel.Size = new System.Drawing.Size(53, 13);
            this.simpleLabel.TabIndex = 3;
            this.simpleLabel.Text = "P.Simples";
            // 
            // normalsListBox
            // 
            this.normalsListBox.FormattingEnabled = true;
            this.normalsListBox.Items.AddRange(new object[] {
            "LLAPIS",
            "RATOLI",
            "GRIPAU",
            "MOTOS",
            "CADIRA",
            "TAULA",
            "COTXE"});
            this.normalsListBox.Location = new System.Drawing.Point(197, 48);
            this.normalsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.normalsListBox.Name = "normalsListBox";
            this.normalsListBox.Size = new System.Drawing.Size(81, 95);
            this.normalsListBox.TabIndex = 1;
            // 
            // Joc
            // 
            this.Joc.Controls.Add(this.hangPictureBox);
            this.Joc.Controls.Add(this.userInputTxtBox);
            this.Joc.Controls.Add(this.wordToSolve);
            this.Joc.Controls.Add(this.passwordLabel);
            this.Joc.Controls.Add(this.passwordTxtBox);
            this.Joc.Controls.Add(this.word_types_game);
            this.Joc.Controls.Add(this.startGame);
            this.Joc.Location = new System.Drawing.Point(4, 22);
            this.Joc.Margin = new System.Windows.Forms.Padding(2);
            this.Joc.Name = "Joc";
            this.Joc.Padding = new System.Windows.Forms.Padding(2);
            this.Joc.Size = new System.Drawing.Size(509, 251);
            this.Joc.TabIndex = 1;
            this.Joc.Text = "Joc";
            this.Joc.UseVisualStyleBackColor = true;
            // 
            // hangPictureBox
            // 
            this.hangPictureBox.Location = new System.Drawing.Point(177, 64);
            this.hangPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.hangPictureBox.Name = "hangPictureBox";
            this.hangPictureBox.Size = new System.Drawing.Size(67, 32);
            this.hangPictureBox.TabIndex = 11;
            this.hangPictureBox.TabStop = false;
            // 
            // userInputTxtBox
            // 
            this.userInputTxtBox.Location = new System.Drawing.Point(177, 166);
            this.userInputTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.userInputTxtBox.MaxLength = 1;
            this.userInputTxtBox.Name = "userInputTxtBox";
            this.userInputTxtBox.Size = new System.Drawing.Size(68, 20);
            this.userInputTxtBox.TabIndex = 10;
            this.userInputTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTxtBoxInputs_KeyPress);
            // 
            // wordToSolve
            // 
            this.wordToSolve.AutoSize = true;
            this.wordToSolve.Enabled = false;
            this.wordToSolve.Location = new System.Drawing.Point(174, 136);
            this.wordToSolve.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wordToSolve.Name = "wordToSolve";
            this.wordToSolve.Size = new System.Drawing.Size(70, 13);
            this.wordToSolve.TabIndex = 9;
            this.wordToSolve.Text = "wordToSolve";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(11, 10);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(4, 25);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTxtBox.MaxLength = 10;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(68, 20);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTxtBoxInputs_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.tabControlGame);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlGame.ResumeLayout(false);
            this.Configuracio.ResumeLayout(false);
            this.Configuracio.PerformLayout();
            this.Joc.ResumeLayout(false);
            this.Joc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox word_types_game;
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
        private System.Windows.Forms.TextBox newWordTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label wordToSolve;
        private System.Windows.Forms.TextBox userInputTxtBox;
        private System.Windows.Forms.PictureBox hangPictureBox;
        private System.Windows.Forms.ComboBox word_types_config;
    }
}

