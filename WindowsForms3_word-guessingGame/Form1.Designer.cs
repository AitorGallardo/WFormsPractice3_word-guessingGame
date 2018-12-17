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
            this.Estadístiques = new System.Windows.Forms.TabPage();
            this.resultTotalLabel_stats = new System.Windows.Forms.Label();
            this.resultLostLabel_stats = new System.Windows.Forms.Label();
            this.resultWinsLabel_stats = new System.Windows.Forms.Label();
            this.totalLostLabel_stats = new System.Windows.Forms.Label();
            this.totalWinLabel_stats = new System.Windows.Forms.Label();
            this.totalGamesLabel_stats = new System.Windows.Forms.Label();
            this.totalListBox_stats = new System.Windows.Forms.ListBox();
            this.logIn_Button = new System.Windows.Forms.Button();
            this.logIn_panel = new System.Windows.Forms.Panel();
            this.tabControlGame.SuspendLayout();
            this.Configuracio.SuspendLayout();
            this.Joc.SuspendLayout();
            this.informationPanel_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangPictureBox)).BeginInit();
            this.Estadístiques.SuspendLayout();
            this.logIn_panel.SuspendLayout();
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
            this.word_types_game.Location = new System.Drawing.Point(243, 154);
            this.word_types_game.Name = "word_types_game";
            this.word_types_game.Size = new System.Drawing.Size(121, 28);
            this.word_types_game.TabIndex = 0;
            // 
            // startGame
            // 
            this.startGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGame.Location = new System.Drawing.Point(393, 154);
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
            this.tabControlGame.Controls.Add(this.Estadístiques);
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
            this.Joc.Controls.Add(this.logIn_panel);
            this.Joc.Controls.Add(this.logIn_Button);
            this.Joc.Controls.Add(this.informationPanel_game);
            this.Joc.Controls.Add(this.hangPictureBox);
            this.Joc.Controls.Add(this.userInputTxtBox);
            this.Joc.Controls.Add(this.wordToSolve);
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
            this.informationPanel_game.Location = new System.Drawing.Point(506, 38);
            this.informationPanel_game.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.informationPanel_game.Name = "informationPanel_game";
            this.informationPanel_game.Size = new System.Drawing.Size(228, 340);
            this.informationPanel_game.TabIndex = 22;
            this.informationPanel_game.Visible = false;
            // 
            // correctCharactersListBox_game
            // 
            this.correctCharactersListBox_game.FormattingEnabled = true;
            this.correctCharactersListBox_game.ItemHeight = 20;
            this.correctCharactersListBox_game.Location = new System.Drawing.Point(50, 34);
            this.correctCharactersListBox_game.Name = "correctCharactersListBox_game";
            this.correctCharactersListBox_game.Size = new System.Drawing.Size(120, 84);
            this.correctCharactersListBox_game.TabIndex = 16;
            // 
            // resultWrongLabel_game
            // 
            this.resultWrongLabel_game.AutoSize = true;
            this.resultWrongLabel_game.Enabled = false;
            this.resultWrongLabel_game.Location = new System.Drawing.Point(153, 288);
            this.resultWrongLabel_game.Name = "resultWrongLabel_game";
            this.resultWrongLabel_game.Size = new System.Drawing.Size(18, 20);
            this.resultWrongLabel_game.TabIndex = 21;
            this.resultWrongLabel_game.Text = "0";
            // 
            // wrongCharactersLabel_game
            // 
            this.wrongCharactersLabel_game.AutoSize = true;
            this.wrongCharactersLabel_game.Location = new System.Drawing.Point(46, 175);
            this.wrongCharactersLabel_game.Name = "wrongCharactersLabel_game";
            this.wrongCharactersLabel_game.Size = new System.Drawing.Size(138, 20);
            this.wrongCharactersLabel_game.TabIndex = 14;
            this.wrongCharactersLabel_game.Text = "Wrong Characters";
            // 
            // resultCorrectLabel_game
            // 
            this.resultCorrectLabel_game.AutoSize = true;
            this.resultCorrectLabel_game.Enabled = false;
            this.resultCorrectLabel_game.Location = new System.Drawing.Point(153, 124);
            this.resultCorrectLabel_game.Name = "resultCorrectLabel_game";
            this.resultCorrectLabel_game.Size = new System.Drawing.Size(18, 20);
            this.resultCorrectLabel_game.TabIndex = 20;
            this.resultCorrectLabel_game.Text = "0";
            // 
            // correctCharactersLabel_game
            // 
            this.correctCharactersLabel_game.AutoSize = true;
            this.correctCharactersLabel_game.Location = new System.Drawing.Point(46, 11);
            this.correctCharactersLabel_game.Name = "correctCharactersLabel_game";
            this.correctCharactersLabel_game.Size = new System.Drawing.Size(143, 20);
            this.correctCharactersLabel_game.TabIndex = 15;
            this.correctCharactersLabel_game.Text = "Correct Characters";
            // 
            // totalCorrectLabel_game
            // 
            this.totalCorrectLabel_game.AutoSize = true;
            this.totalCorrectLabel_game.Enabled = false;
            this.totalCorrectLabel_game.Location = new System.Drawing.Point(84, 124);
            this.totalCorrectLabel_game.Name = "totalCorrectLabel_game";
            this.totalCorrectLabel_game.Size = new System.Drawing.Size(63, 20);
            this.totalCorrectLabel_game.TabIndex = 19;
            this.totalCorrectLabel_game.Text = "TOTAL:";
            // 
            // wrongCharactersListBox_game
            // 
            this.wrongCharactersListBox_game.FormattingEnabled = true;
            this.wrongCharactersListBox_game.ItemHeight = 20;
            this.wrongCharactersListBox_game.Location = new System.Drawing.Point(51, 198);
            this.wrongCharactersListBox_game.Name = "wrongCharactersListBox_game";
            this.wrongCharactersListBox_game.Size = new System.Drawing.Size(120, 84);
            this.wrongCharactersListBox_game.TabIndex = 17;
            // 
            // totalWrongLabel_game
            // 
            this.totalWrongLabel_game.AutoSize = true;
            this.totalWrongLabel_game.Enabled = false;
            this.totalWrongLabel_game.Location = new System.Drawing.Point(84, 288);
            this.totalWrongLabel_game.Name = "totalWrongLabel_game";
            this.totalWrongLabel_game.Size = new System.Drawing.Size(63, 20);
            this.totalWrongLabel_game.TabIndex = 18;
            this.totalWrongLabel_game.Text = "TOTAL:";
            // 
            // hangPictureBox
            // 
            this.hangPictureBox.ErrorImage = global::WindowsForms3_word_guessingGame.Properties.Resources._6_error;
            this.hangPictureBox.Location = new System.Drawing.Point(266, 98);
            this.hangPictureBox.Name = "hangPictureBox";
            this.hangPictureBox.Size = new System.Drawing.Size(100, 92);
            this.hangPictureBox.TabIndex = 11;
            this.hangPictureBox.TabStop = false;
            this.hangPictureBox.Visible = false;
            // 
            // userInputTxtBox
            // 
            this.userInputTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userInputTxtBox.Location = new System.Drawing.Point(264, 275);
            this.userInputTxtBox.MaxLength = 1;
            this.userInputTxtBox.Name = "userInputTxtBox";
            this.userInputTxtBox.Size = new System.Drawing.Size(100, 26);
            this.userInputTxtBox.TabIndex = 10;
            this.userInputTxtBox.Visible = false;
            this.userInputTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTxtBoxInputs_KeyPress);
            // 
            // wordToSolve
            // 
            this.wordToSolve.AutoSize = true;
            this.wordToSolve.Enabled = false;
            this.wordToSolve.Location = new System.Drawing.Point(261, 215);
            this.wordToSolve.Name = "wordToSolve";
            this.wordToSolve.Size = new System.Drawing.Size(100, 20);
            this.wordToSolve.TabIndex = 9;
            this.wordToSolve.Text = "wordToSolve";
            this.wordToSolve.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 9);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(14, 32);
            this.passwordTxtBox.MaxLength = 10;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 26);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allTxtBoxInputs_KeyPress);
            // 
            // Estadístiques
            // 
            this.Estadístiques.Controls.Add(this.resultTotalLabel_stats);
            this.Estadístiques.Controls.Add(this.resultLostLabel_stats);
            this.Estadístiques.Controls.Add(this.resultWinsLabel_stats);
            this.Estadístiques.Controls.Add(this.totalLostLabel_stats);
            this.Estadístiques.Controls.Add(this.totalWinLabel_stats);
            this.Estadístiques.Controls.Add(this.totalGamesLabel_stats);
            this.Estadístiques.Controls.Add(this.totalListBox_stats);
            this.Estadístiques.Location = new System.Drawing.Point(4, 29);
            this.Estadístiques.Name = "Estadístiques";
            this.Estadístiques.Size = new System.Drawing.Size(768, 393);
            this.Estadístiques.TabIndex = 2;
            this.Estadístiques.Text = "Estadístiques";
            this.Estadístiques.UseVisualStyleBackColor = true;
            // 
            // resultTotalLabel_stats
            // 
            this.resultTotalLabel_stats.AutoSize = true;
            this.resultTotalLabel_stats.Location = new System.Drawing.Point(680, 67);
            this.resultTotalLabel_stats.Name = "resultTotalLabel_stats";
            this.resultTotalLabel_stats.Size = new System.Drawing.Size(18, 20);
            this.resultTotalLabel_stats.TabIndex = 6;
            this.resultTotalLabel_stats.Text = "0";
            // 
            // resultLostLabel_stats
            // 
            this.resultLostLabel_stats.AutoSize = true;
            this.resultLostLabel_stats.Location = new System.Drawing.Point(631, 199);
            this.resultLostLabel_stats.Name = "resultLostLabel_stats";
            this.resultLostLabel_stats.Size = new System.Drawing.Size(18, 20);
            this.resultLostLabel_stats.TabIndex = 5;
            this.resultLostLabel_stats.Text = "0";
            // 
            // resultWinsLabel_stats
            // 
            this.resultWinsLabel_stats.AutoSize = true;
            this.resultWinsLabel_stats.Location = new System.Drawing.Point(632, 131);
            this.resultWinsLabel_stats.Name = "resultWinsLabel_stats";
            this.resultWinsLabel_stats.Size = new System.Drawing.Size(18, 20);
            this.resultWinsLabel_stats.TabIndex = 4;
            this.resultWinsLabel_stats.Text = "0";
            // 
            // totalLostLabel_stats
            // 
            this.totalLostLabel_stats.AutoSize = true;
            this.totalLostLabel_stats.Location = new System.Drawing.Point(494, 200);
            this.totalLostLabel_stats.Name = "totalLostLabel_stats";
            this.totalLostLabel_stats.Size = new System.Drawing.Size(112, 20);
            this.totalLostLabel_stats.TabIndex = 3;
            this.totalLostLabel_stats.Text = "PERDUDES : ";
            // 
            // totalWinLabel_stats
            // 
            this.totalWinLabel_stats.AutoSize = true;
            this.totalWinLabel_stats.Location = new System.Drawing.Point(494, 131);
            this.totalWinLabel_stats.Name = "totalWinLabel_stats";
            this.totalWinLabel_stats.Size = new System.Drawing.Size(120, 20);
            this.totalWinLabel_stats.TabIndex = 2;
            this.totalWinLabel_stats.Text = "GUANYADES :";
            // 
            // totalGamesLabel_stats
            // 
            this.totalGamesLabel_stats.AutoSize = true;
            this.totalGamesLabel_stats.Location = new System.Drawing.Point(494, 67);
            this.totalGamesLabel_stats.Name = "totalGamesLabel_stats";
            this.totalGamesLabel_stats.Size = new System.Drawing.Size(179, 20);
            this.totalGamesLabel_stats.TabIndex = 1;
            this.totalGamesLabel_stats.Text = "TOTAL DE PARTIDES :";
            // 
            // totalListBox_stats
            // 
            this.totalListBox_stats.FormattingEnabled = true;
            this.totalListBox_stats.ItemHeight = 20;
            this.totalListBox_stats.Location = new System.Drawing.Point(159, 38);
            this.totalListBox_stats.Name = "totalListBox_stats";
            this.totalListBox_stats.Size = new System.Drawing.Size(219, 304);
            this.totalListBox_stats.TabIndex = 0;
            this.totalListBox_stats.DoubleClick += new System.EventHandler(this.totalListBox_stats_DoubleClick);
            // 
            // logIn_Button
            // 
            this.logIn_Button.Location = new System.Drawing.Point(17, 20);
            this.logIn_Button.Name = "logIn_Button";
            this.logIn_Button.Size = new System.Drawing.Size(75, 34);
            this.logIn_Button.TabIndex = 23;
            this.logIn_Button.Text = "Logg in";
            this.logIn_Button.UseVisualStyleBackColor = true;
            this.logIn_Button.Click += new System.EventHandler(this.logIn_Button_Click);
            // 
            // logIn_panel
            // 
            this.logIn_panel.Controls.Add(this.passwordTxtBox);
            this.logIn_panel.Controls.Add(this.passwordLabel);
            this.logIn_panel.Location = new System.Drawing.Point(229, 61);
            this.logIn_panel.Name = "logIn_panel";
            this.logIn_panel.Size = new System.Drawing.Size(132, 68);
            this.logIn_panel.TabIndex = 24;
            this.logIn_panel.Visible = false;
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
            this.informationPanel_game.ResumeLayout(false);
            this.informationPanel_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangPictureBox)).EndInit();
            this.Estadístiques.ResumeLayout(false);
            this.Estadístiques.PerformLayout();
            this.logIn_panel.ResumeLayout(false);
            this.logIn_panel.PerformLayout();
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
        private System.Windows.Forms.TabPage Estadístiques;
        private System.Windows.Forms.Label totalLostLabel_stats;
        private System.Windows.Forms.Label totalWinLabel_stats;
        private System.Windows.Forms.Label totalGamesLabel_stats;
        private System.Windows.Forms.ListBox totalListBox_stats;
        private System.Windows.Forms.Label resultLostLabel_stats;
        private System.Windows.Forms.Label resultWinsLabel_stats;
        private System.Windows.Forms.Label resultTotalLabel_stats;
        private System.Windows.Forms.Button logIn_Button;
        private System.Windows.Forms.Panel logIn_panel;
    }
}

