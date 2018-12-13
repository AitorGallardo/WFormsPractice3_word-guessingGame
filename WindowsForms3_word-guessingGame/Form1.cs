using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms3_word_guessingGame
{
    public partial class Form1 : Form
    {
        // List<String> simpleWords = new List<String>() {"CEC", "CRANC", "DEU", "MES", "FIL", "MEU", "COTXE"};
        // List<String> normalWords = new List<String>() { "LLAPIS", "RATOLI", "GRIPAU", "MOTOS", "CADIRA", "TAULA", "COTXE" };
        // List<String> complexWords = new List<String>() { "GRINYOLAR", "ESQUERDAR", "ESBIAXAR", "AXAFLANAR"};
        String correctPassword = "ABCD1234";
        // Regex
        Regex regexGameInput = new Regex("^[A-Za-z]{1}$");
        Regex regexSimple = new Regex("^[A-Z]{1,5}$");
        Regex regexNormal = new Regex("^[A-Z]{6,9}$");
        Regex regexComplex = new Regex("^[A-Z]{7,15}$");
        // Resources to manage game inputs
        String randomWordToSolve = "";
        List<char> introducedCharacters = new List<char>();
        //timer
        Timer countDownTimer;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            tabControlGame.TabPages.Remove(Configuracio);
            wordToSolve.Text = "";
            wordToSolve.Visible = false;
            countDownTimer = new System.Windows.Forms.Timer();
        }
        // GAME
        private void startGame_Click(object sender, EventArgs e)
        {
            if (word_types_game.SelectedItem != null)
            {
                int index = word_types_game.Items.IndexOf(word_types_game.SelectedItem);
                initGame(index);
                setCountDown();
            }
        }

        private void initGame(int listNumber)
        {

            Random rand = new Random();
            int maxRandom;
            int wordToSolveLenght;


            switch (listNumber) // falta acabr
            {
                case 0:
                    maxRandom = simplesListBox.Items.Count;
                    randomWordToSolve = simplesListBox.Items[rand.Next(1, maxRandom)].ToString();
                    wordToSolveLenght = randomWordToSolve.Length;
                    for (int i = 0; i < wordToSolveLenght; i++)
                    {
                        wordToSolve.Text += "#";
                    }
                    wordToSolve.Visible = true;
                    break;
                case 1:
                    maxRandom = normalsListBox.Items.Count;
                    rand.Next(1, maxRandom);
                    break;
                case 2:
                    maxRandom = complexesListBox.Items.Count;
                    rand.Next(1, maxRandom);
                    break;
            }

        }

        private void checkAndReplaceWord(String inputCharacter) // repartir en mas metodos?
        {
            char[] copyOfWordToSolve = wordToSolve.Text.ToCharArray();
            char charToReplace = inputCharacter[0];
            int index = 0;
            if (!introducedCharacters.Contains(charToReplace))
            {
                if (randomWordToSolve.Contains(charToReplace))
                {
                    index = randomWordToSolve.IndexOf(charToReplace, index);
                    while (index != -1)
                    {
                        copyOfWordToSolve[index] = charToReplace;
                        wordToSolve.Text = new string(copyOfWordToSolve);
                        index = randomWordToSolve.IndexOf(charToReplace, index + 1);
                    }
                    introducedCharacters.Add(charToReplace);
                    correctCharactersListBox_game.Items.Add(charToReplace);
                }
                else
                {
                    introducedCharacters.Add(charToReplace);
                    wrongCharactersListBox_game.Items.Add(charToReplace);
                }
            }
            else
            {
                MessageBox.Show("Ja has introduit aquesta lletra!");
            }
        }

        private void setCountDown()
        {
            countDownTimer.Interval = 1000;
            countDownTimer.Tick += new EventHandler(checkCountDownEverySecond);
            this.counter = 0;
            countDownTimer.Start();
        }

        private void checkCountDownEverySecond(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(counter);

            if (counter.Equals(8))
            {
                countDownTimer.Stop();
                System.Diagnostics.Debug.WriteLine("finished countdown");
                MessageBox.Show("T'has quedat sense temps. +1 ERROR"); // poner contador de errores
            }

            counter++;
        }

        // CONFIG
        private bool logIn(String password)
        {
            if (this.correctPassword.Equals(password))
            {
                tabControlGame.TabPages.Add(Configuracio);
                tabControlGame.SelectedTab = Configuracio;
                // configPasswordPanel.Visible = false;
                // configWordPanel.Visible = true;
                //768; 393
                // configWordPanel.Size = new Size(768, 393);
                // configWordPanel.AutoSize = true;
                return true;
            }
            return false;
        }
        private void addNewWord(TextBox textbox)
        {
            int wordTypeIndex = word_types_config.Items.IndexOf(word_types_config.SelectedItem);
            switch (wordTypeIndex)
            {
                case 0:
                    if (regexSimple.IsMatch(textbox.Text))
                    {
                        simplesListBox.Items.Add(textbox.Text);
                        MessageBox.Show("La paraula s'ha afegit correctament!");
                        textbox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Paraula incorrecte. Les normes per introduir una paraula del tipus simple són: " +
                                        "\n\n# Nomès caràcters en majúscula\n# Sense accents\n# Paraules de 1 a 5 caràcters");
                        textbox.Clear();
                    }
                    break;
                case 1:
                    if (regexNormal.IsMatch(textbox.Text))
                    {
                        normalsListBox.Items.Add(textbox.Text);
                        MessageBox.Show("La paraula s'ha afegit correctament!");
                        textbox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Paraula incorrecte. Les normes per introduir una paraula del tipus simple són: " +
                                        "\n\n# Nomès caràcters en majúscula\n# Sense accents\n# Paraules de 6 a 9 caràcters");
                        textbox.Clear();
                    }
                    break;
                case 2:
                    if (regexComplex.IsMatch(textbox.Text))
                    {
                        complexesListBox.Items.Add(textbox.Text);
                        MessageBox.Show("La paraula s'ha afegit correctament!");
                        textbox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Paraula incorrecte. Les normes per introduir una paraula del tipus simple són: " +
                                        "\n\n# Nomès caràcters en majúscula\n# Sense accents\n# Paraules de 7 a 15 caràcters");
                        textbox.Clear();
                    }
                    break;
            }
        }
        private void allTxtBoxInputs_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBx = (TextBox)sender;
            bool pressedEnter = e.KeyChar == Convert.ToChar(Keys.Return);

            if (txtBx.Name.Equals("userInputTxtBox"))
            {
                if (!regexGameInput.IsMatch(e.KeyChar.ToString())) // allows only words
                {
                    e.Handled = true;

                } else
                {
                    txtBx.Text = e.KeyChar.ToString().ToUpper();
                    checkAndReplaceWord(txtBx.Text);
                    txtBx.Clear();
                }

            }
            else if(pressedEnter)
            {
                switch (txtBx.Name)
                {
                    case "passwordTxtBox":
                        logIn(passwordTxtBox.Text);
                        txtBx.Clear();
                        break;
                    case "newWordTxtBox":
                        addNewWord(txtBx);
                        break;
                }              
            }
        }

        private void tabControlGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControlGame.SelectedTab != Configuracio)
            {
                tabControlGame.TabPages.Remove(Configuracio);
            }
        }

    }
}
