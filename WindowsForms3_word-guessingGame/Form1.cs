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
        Regex regexSimple = new Regex("^[A-Z]{1,5}$");
        Regex regexNormal = new Regex("^[A-Z]{6,9}$");
        Regex regexComplex = new Regex("^[A-Z]{7,15}$");
        public Form1()
        {
            InitializeComponent();
            tabControlGame.TabPages.Remove(Configuracio);
            wordToSolve.Text = "";
            wordToSolve.Visible = false;
        }
        // GAME
        private void startGame_Click(object sender, EventArgs e)
        {
            if (word_types.SelectedItem != null)
            {
            int index = word_types.Items.IndexOf(word_types.SelectedItem);
                initGame(index);
            }
        }

        private void initGame(int listNumber)
        {
            
            Random rand = new Random();
            int maxRandom;
            String randomWord;
            int wordToSolveLenght;
            

            switch (listNumber)
            {
                case 0:
                    maxRandom = simplesListBox.Items.Count;
                    randomWord = simplesListBox.Items[rand.Next(1, maxRandom)].ToString();
                    wordToSolveLenght = randomWord.Length;
                    for (int i=0; i < wordToSolveLenght; i++)
                    {
                        wordToSolve.Text += " _ ";
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

        private void allInputTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBx = (TextBox)sender;
            if(e.KeyChar == Convert.ToChar(Keys.Return))
            {
                switch (txtBx.Name)
                {
                    case "passwordTxtBox":
                        logIn(passwordTxtBox.Text);
                        txtBx.Clear();
                        break;
                    case "simplesTxtBox":
                        if (regexSimple.IsMatch(txtBx.Text))
                        {
                            simplesListBox.Items.Add(txtBx.Text);
                            MessageBox.Show("La paraula s'ha afegit correctament!");
                            txtBx.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Paraula incorrecte. Les normes per introduir una paraula del tipus simple són: " +
                                            "\n\n# Nomès caràcters en majúscula\n# Sense accents\n# Paraules de 1 a 5 caràcters");
                            txtBx.Clear();
                        }
                        break;
                    case "normalsTxtBox":
                        if (regexNormal.IsMatch(txtBx.Text))
                        {
                            normalsListBox.Items.Add(txtBx.Text);
                            MessageBox.Show("La paraula s'ha afegit correctament!");
                            txtBx.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Paraula incorrecte. Les normes per introduir una paraula del tipus simple són: " +
                                            "\n\n# Nomès caràcters en majúscula\n# Sense accents\n# Paraules de 6 a 9 caràcters");
                            txtBx.Clear();
                        }
                        break;
                    case "complexesTxtBox":
                        if (regexNormal.IsMatch(txtBx.Text))
                        {
                            complexesListBox.Items.Add(txtBx.Text);
                            MessageBox.Show("La paraula s'ha afegit correctament!");
                            txtBx.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Paraula incorrecte. Les normes per introduir una paraula del tipus simple són: " +
                                            "\n\n# Nomès caràcters en majúscula\n# Sense accents\n# Paraules de 7 a 15 caràcters");
                            txtBx.Clear();
                        }
                        break;
                    case "userInputTxtBox":
                        // metodo cuando entra input
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
