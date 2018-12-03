using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            if (word_types.SelectedItem != null)
            {
            }
        }

        private bool logIn(String password)
        {
            if (this.correctPassword.Equals(password))
            {
                configPasswordPanel.Visible = false;
                configWordPanel.Visible = true;
                //768; 393
                configWordPanel.Size = new Size(768, 393);
                configWordPanel.AutoSize = true;
                return true;
            }
            return false;
        }

        private void passwordTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                logIn(passwordTxtBox.Text);
            }
        }
    }
}
