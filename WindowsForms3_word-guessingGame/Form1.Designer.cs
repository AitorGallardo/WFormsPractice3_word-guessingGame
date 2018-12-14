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
            this.wrongCharactersListBox_game = new System.Windows.Forms.ListBox();
            this.correctCharactersListBox_game = new System.Windows.Forms.ListBox();
            this.correctCharactersLabel_game = new System.Windows.Forms.Label();
            this.wrongCharactersLabel_game = new System.Windows.Forms.Label();
            this.hangPictureBox = new System.Windows.Forms.PictureBox();
            this.userInputTxtBox = new System.Windows.Forms.TextBox();
            this.wordToSolve = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.totalWrongLabel_game = new System.Windows.Forms.Label();
            this.totalCorrectLabel_game = new System.Windows.Forms.Label();
            this.resultCorrectLabel_game = new System.Windows.Forms.Label();
            this.resultWrongLabel_game = new System.Windows.Forms.Label();
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
            this.word_types_game.Location = new System.Drawing.Point(447, 25);
            this.word_types_game.Name = "word_types_game";
            this.word_types_game.Size = new System.Drawing.Size(121, 28);
            this.word_types_game.TabIndex = 0;
            // 
            // startGame
            // 
            this.startGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGame.Location = new System.Drawing.Point(591, 28);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(75, 37);
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
            this.Configuracio.Controls.Add(this.word_types_config);
            this.Configuracio.Controls.Add(this.ComplexLabel);
            this.Configuracio.Controls.Add(this.newWordTxtBox);
            this.Configuracio.Controls.Add(this.complexesListBox);
            this.Configuracio.Controls.Add(this.simplesListBox);
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
            // word_types_config
            // 
            this.word_types_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.word_types_config.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.word_types_config.FormattingEnabled = true;
            this.word_types_config.Items.AddRange(new object[] {
            "Simples",
            "Normals",
            "Complexes"});
            this.word_types_config.Location = new System.Drawing.Point(458, 286);
            this.word_types_config.Name = "word_types_config";
            this.word_types_config.Size = new System.Drawing.Size(121, 28);
            this.word_types_config.TabIndex = 8;
            // 
            // ComplexLabel
            // 
            this.ComplexLabel.AutoSize = true;
            this.ComplexLabel.Location = new System.Drawing.Point(549, 29);
            this.ComplexLabel.Name = "ComplexLabel";
            this.ComplexLabel.Size = new System.Drawing.Size(101, 20);
            this.ComplexLabel.TabIndex = 5;
            this.ComplexLabel.Text = "P.Complexes";
            // 
            // newWordTxtBox
            // 
            this.newWordTxtBox.Location = new System.Drawing.Point(238, 286);
            this.newWordTxtBox.Name = "newWordTxtBox";
            this.newWordTxtBox.Size = new System.Drawing.Size(176, 26);
            this.newWordTxtBox.TabIndex = 7;
            this.newWordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTxtBoxInputs_KeyPress);
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
            this.complexesListBox.Location = new System.Drawing.Point(554, 74);
            this.complexesListBox.Name = "complexesListBox";
            this.complexesListBox.Size = new System.Drawing.Size(120, 144);
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
            this.simplesListBox.Location = new System.Drawing.Point(44, 74);
            this.simplesListBox.Name = "simplesListBox";
            this.simplesListBox.Size = new System.Drawing.Size(120, 144);
            this.simplesListBox.TabIndex = 0;
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(291, 29);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(81, 20);
            this.normalLabel.TabIndex = 4;
            this.normalLabel.Text = "P.Normals";
            // 
            // simpleLabel
            // 
            this.simpleLabel.AutoSize = true;
            this.simpleLabel.Location = new System.Drawing.Point(39, 29);
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
            this.normalsListBox.Location = new System.Drawing.Point(296, 74);
            this.normalsListBox.Name = "normalsListBox";
            this.normalsListBox.Size = new System.Drawing.Size(120, 144);
            this.normalsListBox.TabIndex = 1;
            // 
            // Joc
            // 
            this.Joc.Controls.Add(this.resultWrongLabel_game);
            this.Joc.Controls.Add(this.resultCorrectLabel_game);
            this.Joc.Controls.Add(this.totalCorrectLabel_game);
            this.Joc.Controls.Add(this.totalWrongLabel_game);
            this.Joc.Controls.Add(this.wrongCharactersListBox_game);
            this.Joc.Controls.Add(this.correctCharactersListBox_game);
            this.Joc.Controls.Add(this.correctCharactersLabel_game);
            this.Joc.Controls.Add(this.wrongCharactersLabel_game);
            this.Joc.Controls.Add(this.hangPictureBox);
            this.Joc.Controls.Add(this.userInputTxtBox);
            this.Joc.Controls.Add(this.wordToSolve);
            this.Joc.Controls.Add(this.passwordLabel);
            this.Joc.Controls.Add(this.passwordTxtBox);
            this.Joc.Controls.Add(this.word_types_game);
            this.Joc.Controls.Add(this.startGame);
            this.Joc.Location = new System.Drawing.Point(4, 29);
            this.Joc.Name = "Joc";
            this.Joc.Padding = new System.Windows.Forms.Padding(3);
            this.Joc.Size = new System.Drawing.Size(768, 393);
            this.Joc.TabIndex = 1;
            this.Joc.Text = "Joc";
            this.Joc.UseVisualStyleBackColor = true;
            // 
            // wrongCharactersListBox_game
            // 
            this.wrongCharactersListBox_game.FormattingEnabled = true;
            this.wrongCharactersListBox_game.ItemHeight = 20;
            this.wrongCharactersListBox_game.Location = new System.Drawing.Point(560, 275);
            this.wrongCharactersListBox_game.Name = "wrongCharactersListBox_game";
            this.wrongCharactersListBox_game.Size = new System.Drawing.Size(120, 84);
            this.wrongCharactersListBox_game.TabIndex = 17;
            // 
            // correctCharactersListBox_game
            // 
            this.correctCharactersListBox_game.FormattingEnabled = true;
            this.correctCharactersListBox_game.ItemHeight = 20;
            this.correctCharactersListBox_game.Location = new System.Drawing.Point(560, 128);
            this.correctCharactersListBox_game.Name = "correctCharactersListBox_game";
            this.correctCharactersListBox_game.Size = new System.Drawing.Size(120, 84);
            this.correctCharactersListBox_game.TabIndex = 16;
            // 
            // correctCharactersLabel_game
            // 
            this.correctCharactersLabel_game.AutoSize = true;
            this.correctCharactersLabel_game.Location = new System.Drawing.Point(551, 105);
            this.correctCharactersLabel_game.Name = "correctCharactersLabel_game";
            this.correctCharactersLabel_game.Size = new System.Drawing.Size(143, 20);
            this.correctCharactersLabel_game.TabIndex = 15;
            this.correctCharactersLabel_game.Text = "Correct Characters";
            // 
            // wrongCharactersLabel_game
            // 
            this.wrongCharactersLabel_game.AutoSize = true;
            this.wrongCharactersLabel_game.Location = new System.Drawing.Point(551, 252);
            this.wrongCharactersLabel_game.Name = "wrongCharactersLabel_game";
            this.wrongCharactersLabel_game.Size = new System.Drawing.Size(138, 20);
            this.wrongCharactersLabel_game.TabIndex = 14;
            this.wrongCharactersLabel_game.Text = "Wrong Characters";
            // 
            // hangPictureBox
            // 
            this.hangPictureBox.Location = new System.Drawing.Point(266, 98);
            this.hangPictureBox.Name = "hangPictureBox";
            this.hangPictureBox.Size = new System.Drawing.Size(100, 49);
            this.hangPictureBox.TabIndex = 11;
            this.hangPictureBox.TabStop = false;
            // 
            // userInputTxtBox
            // 
            this.userInputTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userInputTxtBox.Location = new System.Drawing.Point(266, 255);
            this.userInputTxtBox.MaxLength = 1;
            this.userInputTxtBox.Name = "userInputTxtBox";
            this.userInputTxtBox.Size = new System.Drawing.Size(100, 26);
            this.userInputTxtBox.TabIndex = 10;
            this.userInputTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTxtBoxInputs_KeyPress);
            // 
            // wordToSolve
            // 
            this.wordToSolve.AutoSize = true;
            this.wordToSolve.Enabled = false;
            this.wordToSolve.Location = new System.Drawing.Point(261, 209);
            this.wordToSolve.Name = "wordToSolve";
            this.wordToSolve.Size = new System.Drawing.Size(100, 20);
            this.wordToSolve.TabIndex = 9;
            this.wordToSolve.Text = "wordToSolve";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(16, 15);
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
            this.passwordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTxtBoxInputs_KeyPress);
            // 
            // totalWrongLabel_game
            // 
            this.totalWrongLabel_game.AutoSize = true;
            this.totalWrongLabel_game.Enabled = false;
            this.totalWrongLabel_game.Location = new System.Drawing.Point(604, 362);
            this.totalWrongLabel_game.Name = "totalWrongLabel_game";
            this.totalWrongLabel_game.Size = new System.Drawing.Size(63, 20);
            this.totalWrongLabel_game.TabIndex = 18;
            this.totalWrongLabel_game.Text = "TOTAL:";
            // 
            // totalCorrectLabel_game
            // 
            this.totalCorrectLabel_game.AutoSize = true;
            this.totalCorrectLabel_game.Enabled = false;
            this.totalCorrectLabel_game.Location = new System.Drawing.Point(604, 215);
            this.totalCorrectLabel_game.Name = "totalCorrectLabel_game";
            this.totalCorrectLabel_game.Size = new System.Drawing.Size(63, 20);
            this.totalCorrectLabel_game.TabIndex = 19;
            this.totalCorrectLabel_game.Text = "TOTAL:";
            // 
            // resultCorrectLabel_game
            // 
            this.resultCorrectLabel_game.AutoSize = true;
            this.resultCorrectLabel_game.Enabled = false;
            this.resultCorrectLabel_game.Location = new System.Drawing.Point(661, 215);
            this.resultCorrectLabel_game.Name = "resultCorrectLabel_game";
            this.resultCorrectLabel_game.Size = new System.Drawing.Size(18, 20);
            this.resultCorrectLabel_game.TabIndex = 20;
            this.resultCorrectLabel_game.Text = "0";
            // 
            // resultWrongLabel_game
            // 
            this.resultWrongLabel_game.AutoSize = true;
            this.resultWrongLabel_game.Enabled = false;
            this.resultWrongLabel_game.Location = new System.Drawing.Point(661, 362);
            this.resultWrongLabel_game.Name = "resultWrongLabel_game";
            this.resultWrongLabel_game.Size = new System.Drawing.Size(18, 20);
            this.resultWrongLabel_game.TabIndex = 21;
            this.resultWrongLabel_game.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.tabControlGame);
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
        private System.Windows.Forms.ListBox wrongCharactersListBox_game;
        private System.Windows.Forms.ListBox correctCharactersListBox_game;
        private System.Windows.Forms.Label correctCharactersLabel_game;
        private System.Windows.Forms.Label wrongCharactersLabel_game;
        private System.Windows.Forms.Label resultWrongLabel_game;
        private System.Windows.Forms.Label resultCorrectLabel_game;
        private System.Windows.Forms.Label totalCorrectLabel_game;
        private System.Windows.Forms.Label totalWrongLabel_game;
    }
}

