using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_2017_020
{
    public partial class Hang : Form
    {   
        //Pool Words
        string[] PoolWords = { "duck","lion","bear","crab","hare","frog","wolf","goat","mole","deer","lamb","moco","puma","zobo","vole " };

        int count = 3;
        string HiddenWord;//Hidden word of the Pool Words
        
        public Hang()
        {
            InitializeComponent();
        }

        public void Hang_Load(object sender, EventArgs e)
        {
            int y;
            y = GetRandNo();
            HiddenWord = PoolWords[y];
            lblL2.Text = HiddenWord[1].ToString();
            lblAttempts.Text = count.ToString();
        }
        public int GetRandNo()//Get Random Number
        {
            int i;
            Random random = new Random();
            return i = random.Next(0,15);
        }
        private void txtGuessLetter_KeyDown(object sender, KeyEventArgs e)
        {
            string G= txtGuessLetter.Text;
            string T1 = Convert.ToString(HiddenWord[0]);
            string T2 = Convert.ToString(HiddenWord[1]);
            string T3 = Convert.ToString(HiddenWord[2]);
            string T4 = Convert.ToString(HiddenWord[3]);

            if (e.KeyCode == Keys.Enter && G.Length ==1 && txtGuessLetter.Text!="")
            {
                GuessProcess();

            }
            else if(e.KeyCode == Keys.Enter && G.Length!=1)
            {
                MessageBox.Show("Please enter only one letter!");
                txtGuessLetter.Text = "";
            }
        }
        public void GuessProcess()//Checking process
        {
            char L1 = HiddenWord[0];
            char L3 = HiddenWord[2];
            char L4 = HiddenWord[3];
            char GWord = Convert.ToChar(txtGuessLetter.Text);

            if(GWord==L1 && lblL1.Text=="#")
            {
                
                    
                    lblL1.Text = L1.ToString();
                    txtGuessLetter.Text = "";
                if (lblL3.Text == "#" || lblL4.Text == "#")
                {
                    MessageBox.Show("1st letter is correct!");
                }
                else
                {
                    MessageBox.Show("Congratulations!!! You won the Game.");
                    
                }



            }
            else if (GWord == L3 && lblL3.Text=="#")
            {

                lblL3.Text = L3.ToString();
                txtGuessLetter.Text = "";
                if (lblL1.Text == "#" || lblL4.Text == "#")
                {
                    MessageBox.Show("3rd letter is correct!");
                }
                else
                {
                    MessageBox.Show("Congratulations!!! You won the Game.");
                    txtGuessLetter.Enabled = false;
                }

            }
            else if (GWord == L4 && lblL4.Text == "#")
            {

                lblL4.Text = L4.ToString();
                txtGuessLetter.Text = "";
                if (lblL3.Text == "#" || lblL1.Text == "#")
                {
                    MessageBox.Show("4th letter is correct!");
                }
                else
                {
                    MessageBox.Show("Congratulations!!! You won the Game.");
                    txtGuessLetter.Enabled = false;
                }

            }
            else if(GWord!=L1 && GWord!=L3 && GWord!=L4)
            {
                MessageBox.Show("Letter is incorrect!");
                count--;
                lblAttempts.Text = "" + count;
                txtGuessLetter.Text = "";
                if (count == 0)
                {
                    MessageBox.Show("Sorry. Game is Over!!!");
                    txtGuessLetter.Text = "";
                    txtGuessLetter.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Letter is incorrect!");
                count--;
                lblAttempts.Text = "" + count;
                txtGuessLetter.Text = "";
                if (count == 0)
                {
                    MessageBox.Show("Sorry. Game is Over!!!");
                    txtGuessLetter.Text = "";
                    txtGuessLetter.Enabled = false;
                }
            }
             

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
             this.Close();
        }

    }
}
