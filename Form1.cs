using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Alexander Souza - G00317835
// 03/03/2015
// Project C# Rock Paper Scissor

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        Help HelpForm = new Help(); //Iniciate form Help

        public static Form Mainform = null;

        enum Options { Rock, Paper, Scissor };
        enum Result {You, Computer, draw };
        Options player = new Options();
        Options computer = new Options();
        Random rdm = new Random();
        Result winner = new Result();

        public Form1()
        {
            InitializeComponent();
        }

        void optionPlayer() // Player Decisions
        {
            switch (player)
            { 
                case Options.Rock:
                    picturePlayer.BackgroundImage = Properties.Resources.RockL;
                    break;

                case Options.Paper:
                    picturePlayer.BackgroundImage = Properties.Resources.PaperL;
                    break;

                case Options.Scissor:
                    picturePlayer.BackgroundImage = Properties.Resources.ScissorL;
                    break;
            }
       
        }

        void optionComputer() // Computer options and Random
        {
            int number = rdm.Next(1, 4);

            if(number == 1)
            {
                computer = Options.Rock;
                pictureComputer.BackgroundImage = Properties.Resources.RockR;
            }

            else if(number == 2)
            {
                computer = Options.Paper;
                pictureComputer.BackgroundImage = Properties.Resources.PaperR;
            }
       
            else if(number == 3)
            {
                computer = Options.Scissor;
                pictureComputer.BackgroundImage = Properties.Resources.ScissorR;
            }
       
        }

        void newGame() // Star a New Game
        {
            pictureBoxBG.Enabled = true;
            resultYou.Text = "0";
            resultComputer.Text = "0";
            pictureComputer.BackgroundImage = Properties.Resources.blank;
            picturePlayer.BackgroundImage = Properties.Resources.blank;
            pgBarrComputer.Value = 0;
            pgBarrYou.Value = 0;
            labelResult.Text = " ";
        }

        void exitPrograme() //Exit the Game
        {
            int scoreYou = Convert.ToInt32(resultYou.Text);
            int scoreComputer = Convert.ToInt32(resultComputer.Text);
            String msgResult;

            if (scoreYou > scoreComputer)
            {
                msgResult = "You win: " + resultYou.Text + " points";
            }

            else if (scoreYou == scoreComputer)
            {
                msgResult = "Draw " + "Your " + resultYou.Text + " - Computer's " + resultComputer.Text;
            }

            else
            {
                msgResult = "Computer's win: " + resultComputer.Text + " points";
            }

            pictureBoxBG.Enabled = false;

            DialogResult result = MessageBox.Show("Final Score - You Vs Computer\n \n Your points:  " + resultYou.Text + "\n Computer's points:  " + resultComputer.Text + "\n\n" + msgResult, "Do you like to leave the game ?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

            if (result == DialogResult.No)
            {
                newGame();
               
            }           
       
        }

        void checkWinner() // Verifiy Winner and Update the Score
        {
            switch (player)
            {
                case Options.Rock:
                    if (computer == Options.Rock)
                        winner = Result.draw;
                    else if (computer == Options.Paper)
                        winner = Result.Computer;
                    else if (computer == Options.Scissor)
                        winner = Result.You;
                    break;

                case Options.Paper:
                    if (computer == Options.Rock)
                        winner = Result.You;
                    else if (computer == Options.Paper)
                        winner = Result.draw;
                    else if (computer == Options.Scissor)
                        winner = Result.Computer;
                    break;

                case Options.Scissor:
                    if (computer == Options.Rock)
                        winner = Result.Computer;
                    else if (computer == Options.Paper)
                        winner = Result.You;
                    else if (computer == Options.Scissor)
                        winner = Result.draw;
                    break;
         
                }

                if (winner == Result.You)
                {
                    resultYou.Text = (int.Parse(resultYou.Text) + 1).ToString();
                    pgBarrYou.Increment(10);
                    labelResult.Text = "You Win!";
                    if (pgBarrYou.Value == 100)
                    {
                        exitPrograme();
                    }
                }
 
                else if (winner == Result.Computer)
                {
                    resultComputer.Text = (int.Parse(resultComputer.Text) + 1).ToString();
                    pgBarrComputer.Increment(10);
                    labelResult.Text = "You lose!";
                    if (pgBarrComputer.Value == 100)
                    {
                        exitPrograme();
                    }
                }
        
                else 
                {
                    labelResult.Text = "Draw!";
                }
      
        }

        private void btExit_Click_1(object sender, EventArgs e) // Botton Exit
        {
            exitPrograme();
            
        }
        
        private void Form1_Load(object sender, EventArgs e) // Load the Form to put some image transparent
        {
            picturePlayer.Parent = pictureBoxBG;
            picturePlayer.BackColor = Color.Transparent;

            pictureComputer.Parent = pictureBoxBG;
            pictureComputer.BackColor = Color.Transparent;

            btRock.Parent = pictureBoxBG;
            btRock.BackColor = Color.Transparent;

            btScissor.Parent = pictureBoxBG;
            btScissor.BackColor = Color.Transparent;

            btPaper1.Parent = pictureBoxBG;
            btPaper1.BackColor = Color.Transparent;

            labelResult.Parent = pictureBoxBG;
            labelResult.BackColor = Color.Transparent;
        }

        private void btRock_Click_1(object sender, EventArgs e)
        {
            player = Options.Rock;
            optionPlayer();
            optionComputer();
            checkWinner();
        }

        private void btScissor_Click_1(object sender, EventArgs e)
        {
            player = Options.Scissor;
            optionPlayer();
            optionComputer();
            checkWinner();
        }

        private void btPaper1_Click(object sender, EventArgs e)
        {
            player = Options.Paper;
            optionPlayer();
            optionComputer();
            checkWinner();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Mainform = this;
            HelpForm.Show();
            
          }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
