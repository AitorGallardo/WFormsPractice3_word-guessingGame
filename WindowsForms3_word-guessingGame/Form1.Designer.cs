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
            this.informationPanel_game = new System.Windows.Forms.Panel();
            this.correctCharactersListBox_game = new System.Windows.Forms.ListBox();
            this.resultWrongLabel_game = new System.Windows.Forms.Label();
            this.wrongCharactersLabel_game = new System.Windows.Forms.Label();
            this.resultCorrectLabel_game = new System.Windows.Forms.Label();
            this.correctCharactersLabel_game = new System.Windows.Forms.Label();
            this.totalCorrectLabel_game = new System.Windows.Forms.Label();
            this.wrongCharactersListBox_game = new System.Windows.Forms.ListBox();
            this.totalWrongLabel_game = new System.Windows.Forms.Label();
            this.hangPictureBox = new System.Windows.Forms.PictureBox();
            this.userInputTxtBox = new System.Windows.Forms.TextBox();
            this.wordToSolve = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.tabControlGame.SuspendLayout();
            this.Configuracio.SuspendLayout();
            this.Joc.SuspendLayout();
            this.informationPanel_game.SuspendLayout();
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
            this.word_types_game.Location = new System.Drawing.Point(162, 103);
            this.word_types_game.Margin = new System.Windows.Forms.Padding(2);
            this.word_types_game.Name = "word_types_game";
            this.word_types_game.Size = new System.Drawing.Size(82, 21);
            this.word_types_game.TabIndex = 0;
            // 
            // startGame
            // 
            this.startGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGame.Location = new System.Drawing.Point(262, 100);
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
            this.Joc.Controls.Add(this.informationPanel_game);
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
            // informationPanel_game
            // 
            this.informationPanel_game.Controls.Add(this.correctCharactersListBox_game);
            this.informationPanel_game.Controls.Add(this.resultWrongLabel_game);
            this.informationPanel_game.Controls.Add(this.wrongCharactersLabel_game);
            this.informationPanel_game.Controls.Add(this.resultCorrectLabel_game);
            this.informationPanel_game.Controls.Add(this.correctCharactersLabel_game);
            this.informationPanel_game.Controls.Add(this.totalCorrectLabel_game);
            this.informationPanel_game.Controls.Add(this.wrongCharactersListBox_game);
            this.informationPanel_game.Controls.Add(this.totalWrongLabel_game);
            this.informationPanel_game.Location = new System.Drawing.Point(337, 25);
            this.informationPanel_game.Name = "informationPanel_game";
            this.informationPanel_game.Size = new System.Drawing.Size(152, 221);
            this.informationPanel_game.TabIndex = 22;
            this.informationPanel_game.Visible = false;
            // 
            // correctCharactersListBox_game
            // 
            this.correctCharactersListBox_game.FormattingEnabled = true;
            this.correctCharactersListBox_game.Location = new System.Drawing.Point(34, 28);
            this.correctCharactersListBox_game.Margin = new System.Windows.Forms.Padding(2);
            this.correctCharactersListBox_game.Name = "correctCharactersListBox_game";
            this.correctCharactersListBox_game.Size = new System.Drawing.Size(81, 56);
            this.correctCharactersListBox_game.TabIndex = 16;
            // 
            // resultWrongLabel_game
            // 
            this.resultWrongLabel_game.AutoSize = true;
            this.resultWrongLabel_game.Enabled = false;
            this.resultWrongLabel_game.Location = new System.Drawing.Point(102, 187);
            this.resultWrongLabel_game.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultWrongLabel_game.Name = "resultWrongLabel_game";
            this.resultWrongLabel_game.Size = new System.Drawing.Size(13, 13);
            this.resultWrongLabel_game.TabIndex = 21;
            this.resultWrongLabel_game.Text = "0";
            // 
            // wrongCharactersLabel_game
            // 
            this.wrongCharactersLabel_game.AutoSize = true;
            this.wrongCharactersLabel_game.Location = new System.Drawing.Point(31, 114);
            this.wrongCharactersLabel_game.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongCharactersLabel_game.Name = "wrongCharactersLabel_game";
            this.wrongCharactersLabel_game.Size = new System.Drawing.Size(93, 13);
            this.wrongCharactersLabel_game.TabIndex = 14;
            this.wrongCharactersLabel_game.Text = "Wrong Characters";
            // 
            // resultCorrectLabel_game
            // 
            this.resultCorrectLabel_game.AutoSize = true;
            this.resultCorrectLabel_game.Enabled = false;
            this.resultCorrectLabel_game.Location = new System.Drawing.Point(102, 86);
            this.resultCorrectLabel_game.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultCorrectLabel_game.Name = "resultCorrectLabel_game";
            this.resultCorrectLabel_game.Size = new System.Drawing.Size(13, 13);
            this.resultCorrectLabel_game.TabIndex = 20;
            this.resultCorrectLabel_game.Text = "0";
            // 
            // correctCharactersLabel_game
            // 
            this.correctCharactersLabel_game.AutoSize = true;
            this.correctCharactersLabel_game.Location = new System.Drawing.Point(31, 7);
            this.correctCharactersLabel_game.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.correctCharactersLabel_game.Name = "correctCharactersLabel_game";
            this.correctCharactersLabel_game.Size = new System.Drawing.Size(95, 13);
            this.correctCharactersLabel_game.TabIndex = 15;
            this.correctCharactersLabel_game.Text = "Correct Characters";
            // 
            // totalCorrectLabel_game
            // 
            this.totalCorrectLabel_game.AutoSize = true;
            this.totalCorrectLabel_game.Enabled = false;
            this.totalCorrectLabel_game.Location = new System.Drawing.Point(48, 86);
            this.totalCorrectLabel_game.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCorrectLabel_game.Name = "totalCorrectLabel_game";
            this.totalCorrectLabel_game.Size = new System.Drawing.Size(45, 13);
            this.totalCorrectLabel_game.TabIndex = 19;
            this.totalCorrectLabel_game.Text = "TOTAL:";
            // 
            // wrongCharactersListBox_game
            // 
            this.wrongCharactersListBox_game.FormattingEnabled = true;
            this.wrongCharactersListBox_game.Location = new System.Drawing.Point(34, 129);
            this.wrongCharactersListBox_game.Margin = new System.Windows.Forms.Padding(2);
            this.wrongCharactersListBox_game.Name = "wrongCharactersListBox_game";
            this.wrongCharactersListBox_game.Size = new System.Drawing.Size(81, 56);
            this.wrongCharactersListBox_game.TabIndex = 17;
            // 
            // totalWrongLabel_game
            // 
            this.totalWrongLabel_game.AutoSize = true;
            this.totalWrongLabel_game.Enabled = false;
            this.totalWrongLabel_game.Location = new System.Drawing.Point(48, 187);
            this.totalWrongLabel_game.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalWrongLabel_game.Name = "totalWrongLabel_game";
            this.totalWrongLabel_game.Size = new System.Drawing.Size(45, 13);
            this.totalWrongLabel_game.TabIndex = 18;
            this.totalWrongLabel_game.Text = "TOTAL:";
            // 
            // hangPictureBox
            // 
            this.hangPictureBox.ErrorImage = global::WindowsForms3_word_guessingGame.Properties.Resources._6_error;
            this.hangPictureBox.Location = new System.Drawing.Point(177, 64);
            this.hangPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.hangPictureBox.Name = "hangPictureBox";
            this.hangPictureBox.Size = new System.Drawing.Size(67, 60);
            this.hangPictureBox.TabIndex = 11;
            this.hangPictureBox.TabStop = false;
            this.hangPictureBox.Visible = false;
            // 
            // userInputTxtBox
            // 
            this.userInputTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userInputTxtBox.Location = new System.Drawing.Point(176, 179);
            this.userInputTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.userInputTxtBox.MaxLength = 1;
            this.userInputTxtBox.Name = "userInputTxtBox";
            this.userInputTxtBox.Size = new System.Drawing.Size(68, 20);
            this.userInputTxtBox.TabIndex = 10;
            this.userInputTxtBox.Visible = false;
            this.userInputTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTxtBoxInputs_KeyPress);
            // 
            // wordToSolve
            // 
            this.wordToSolve.AutoSize = true;
            this.wordToSolve.Enabled = false;
            this.wordToSolve.Location = new System.Drawing.Point(174, 140);
            this.wordToSolve.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wordToSolve.Name = "wordToSolve";
            this.wordToSolve.Size = new System.Drawing.Size(70, 13);
            this.wordToSolve.TabIndex = 9;
            this.wordToSolve.Text = "wordToSolve";
            this.wordToSolve.Visible = false;
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
            this.informationPanel_game.ResumeLayout(false);
            this.informationPanel_game.PerformLayout();
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
        private System.Windows.Forms.Panel informationPanel_game;
    }
}

