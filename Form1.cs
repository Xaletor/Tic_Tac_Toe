using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool didOStart = false;
        bool isOTurn = true;

        bool isOWon = false;
        bool isXWon = false;
        bool isCats = false;

        List<Button> buttons = new List<Button>();
        int oScore = 0;
        int xScore = 0;
        
        public Form1()
        {
            InitializeComponent();
            System.Random randomPick = new System.Random();

            didOStart = true;
            singleButton.Checked = true;
            WhosTurn();

            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            ClearButtons();

        }
        public void RunAI()
        {
            if (!isOTurn)
            {
                #region X win checks

                // Horizontal X Checks
                if      (buttons[0].Text == "X" && buttons[1].Text == "X" && buttons[2].Text == "_") buttons[2].PerformClick();
                else if (buttons[0].Text == "X" && buttons[2].Text == "X" && buttons[1].Text == "_") buttons[1].PerformClick();
                else if (buttons[1].Text == "X" && buttons[2].Text == "X" && buttons[0].Text == "_") buttons[0].PerformClick();

                else if (buttons[3].Text == "X" && buttons[4].Text == "X" && buttons[5].Text == "_") buttons[5].PerformClick();
                else if (buttons[3].Text == "X" && buttons[5].Text == "X" && buttons[4].Text == "_") buttons[4].PerformClick();
                else if (buttons[4].Text == "X" && buttons[5].Text == "X" && buttons[3].Text == "_") buttons[3].PerformClick();

                else if (buttons[6].Text == "X" && buttons[7].Text == "X" && buttons[8].Text == "_") buttons[8].PerformClick();
                else if (buttons[6].Text == "X" && buttons[8].Text == "X" && buttons[7].Text == "_") buttons[7].PerformClick();
                else if (buttons[7].Text == "X" && buttons[8].Text == "X" && buttons[6].Text == "_") buttons[6].PerformClick();

                // Vertical X Checks
                else if (buttons[0].Text == "X" && buttons[3].Text == "X" && buttons[6].Text == "_") buttons[6].PerformClick();
                else if (buttons[0].Text == "X" && buttons[6].Text == "X" && buttons[3].Text == "_") buttons[3].PerformClick();
                else if (buttons[3].Text == "X" && buttons[6].Text == "X" && buttons[0].Text == "_") buttons[0].PerformClick();

                else if (buttons[1].Text == "X" && buttons[4].Text == "X" && buttons[7].Text == "_") buttons[7].PerformClick();
                else if (buttons[4].Text == "X" && buttons[7].Text == "X" && buttons[1].Text == "_") buttons[1].PerformClick();
                else if (buttons[7].Text == "X" && buttons[1].Text == "X" && buttons[4].Text == "_") buttons[4].PerformClick();

                else if (buttons[2].Text == "X" && buttons[5].Text == "X" && buttons[8].Text == "_") buttons[8].PerformClick();
                else if (buttons[5].Text == "X" && buttons[8].Text == "X" && buttons[2].Text == "_") buttons[2].PerformClick();
                else if (buttons[8].Text == "X" && buttons[2].Text == "X" && buttons[5].Text == "_") buttons[5].PerformClick();

                // Diagonal X Checks
                else if (buttons[0].Text == "X" && buttons[4].Text == "X" && buttons[8].Text == "_") buttons[8].PerformClick();
                else if (buttons[4].Text == "X" && buttons[8].Text == "X" && buttons[0].Text == "_") buttons[0].PerformClick();
                else if (buttons[8].Text == "X" && buttons[0].Text == "X" && buttons[4].Text == "_") buttons[4].PerformClick();

                else if (buttons[2].Text == "X" && buttons[4].Text == "X" && buttons[6].Text == "_") buttons[6].PerformClick();
                else if (buttons[4].Text == "X" && buttons[6].Text == "X" && buttons[2].Text == "_") buttons[2].PerformClick();
                else if (buttons[6].Text == "X" && buttons[2].Text == "X" && buttons[4].Text == "_") buttons[4].PerformClick();
                #endregion
                
                
                #region O win block checks

                // Horizontal  O Checks
                else if (buttons[0].Text == "O" && buttons[1].Text == "O" && buttons[2].Text == "_") buttons[2].PerformClick();
                else if (buttons[0].Text == "O" && buttons[2].Text == "O" && buttons[1].Text == "_") buttons[1].PerformClick();
                else if (buttons[1].Text == "O" && buttons[2].Text == "O" && buttons[0].Text == "_") buttons[0].PerformClick();

                else if (buttons[3].Text == "O" && buttons[4].Text == "O" && buttons[5].Text == "_") buttons[5].PerformClick();
                else if (buttons[3].Text == "O" && buttons[5].Text == "O" && buttons[4].Text == "_") buttons[4].PerformClick();
                else if (buttons[4].Text == "O" && buttons[5].Text == "O" && buttons[3].Text == "_") buttons[3].PerformClick();

                else if (buttons[6].Text == "O" && buttons[7].Text == "O" && buttons[8].Text == "_") buttons[8].PerformClick();
                else if (buttons[6].Text == "O" && buttons[8].Text == "O" && buttons[7].Text == "_") buttons[7].PerformClick();
                else if (buttons[7].Text == "O" && buttons[8].Text == "O" && buttons[6].Text == "_") buttons[6].PerformClick();

                // Vertical O Checks
                else if (buttons[0].Text == "O" && buttons[3].Text == "O" && buttons[6].Text == "_") buttons[6].PerformClick();
                else if (buttons[0].Text == "O" && buttons[6].Text == "O" && buttons[3].Text == "_") buttons[3].PerformClick();
                else if (buttons[3].Text == "O" && buttons[6].Text == "O" && buttons[0].Text == "_") buttons[0].PerformClick();

                else if (buttons[1].Text == "O" && buttons[4].Text == "O" && buttons[7].Text == "_") buttons[7].PerformClick();
                else if (buttons[4].Text == "O" && buttons[7].Text == "O" && buttons[1].Text == "_") buttons[1].PerformClick();
                else if (buttons[7].Text == "O" && buttons[1].Text == "O" && buttons[4].Text == "_") buttons[4].PerformClick();

                else if (buttons[2].Text == "O" && buttons[5].Text == "O" && buttons[8].Text == "_") buttons[8].PerformClick();
                else if (buttons[5].Text == "O" && buttons[8].Text == "O" && buttons[2].Text == "_") buttons[2].PerformClick();
                else if (buttons[8].Text == "O" && buttons[2].Text == "O" && buttons[5].Text == "_") buttons[5].PerformClick();

                // Diagonal O Checks
                else if (buttons[0].Text == "O" && buttons[4].Text == "O" && buttons[8].Text == "_") buttons[8].PerformClick();
                else if (buttons[4].Text == "O" && buttons[8].Text == "O" && buttons[0].Text == "_") buttons[0].PerformClick();
                else if (buttons[8].Text == "O" && buttons[0].Text == "O" && buttons[4].Text == "_") buttons[4].PerformClick();

                else if (buttons[2].Text == "O" && buttons[4].Text == "O" && buttons[6].Text == "_") buttons[6].PerformClick();
                else if (buttons[4].Text == "O" && buttons[6].Text == "O" && buttons[2].Text == "_") buttons[2].PerformClick();
                else if (buttons[6].Text == "O" && buttons[2].Text == "O" && buttons[4].Text == "_") buttons[4].PerformClick();
                #endregion

                #region Strat Checks
                else if (buttons[2].Text == "O" && buttons[6].Text == "O" && buttons[0].Text == "X" && buttons[8].Text == "_") buttons[8].PerformClick();
                else if (buttons[0].Text == "O" && buttons[8].Text == "O" && buttons[2].Text == "X" && buttons[6].Text == "_") buttons[6].PerformClick();
                else if (buttons[2].Text == "O" && buttons[6].Text == "O" && buttons[8].Text == "X" && buttons[0].Text == "_") buttons[0].PerformClick();
                else if (buttons[0].Text == "O" && buttons[8].Text == "O" && buttons[6].Text == "X" && buttons[2].Text == "_") buttons[2].PerformClick();
                #endregion

                else
                {
                    int rCell;
                    System.Random pickButton = new System.Random();
                    while (true)
                    {
                        rCell = (int)pickButton.Next(0, 9);
                        if (buttons[rCell].Text == "_")
                        {
                            buttons[rCell].PerformClick();
                            break;
                        }
                    }
                }
            }
        }
        public void WhosTurn()
        {
            isOTurn = (didOStart) ? true : false;
            turnLabel.Text = (!isOTurn && singleButton.Checked) ? "Computer's Turn :" : "Player's Turn :";
            turn.Text = (isOTurn) ? "O" : "X";
        }
        public void ClearButtons()
        {
            isXWon = false;
            isOWon = false;
            isCats = false;

            didOStart = !didOStart;
            foreach (Button button in buttons)
            {
                button.Text = "_";
            }
        }

        public void CheckConditions()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")      { isXWon = true; }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") { isXWon = true; }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") { isXWon = true; }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") { isXWon = true; }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") { isXWon = true; }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") { isXWon = true; }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") { isXWon = true; }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") { isXWon = true; }

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") { isOWon = true; }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") { isOWon = true; }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") { isOWon = true; }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") { isOWon = true; }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") { isOWon = true; }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") { isOWon = true; }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") { isOWon = true; }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") { isOWon = true; }


            int i = 0;
            foreach (Button button in buttons)
            {
               i += (button.Text != "_")?1:0;
                if(i == 9)
                {
                    isCats = true;
                } 
            }

            if (isOWon)
            {
                oScore++;
                MessageBox.Show("O is the winner!", "WINNER",MessageBoxButtons.OK);
                oScoreLabel.Text = oScore.ToString();
                ClearButtons();
                WhosTurn();
            }
            else if (isXWon)
            {
                xScore++;
                MessageBox.Show("X is the winner!", "WINNER", MessageBoxButtons.OK);
                xScoreLabel.Text = xScore.ToString();
                ClearButtons();
                WhosTurn();
            }

            else if (isCats)
            {
                MessageBox.Show("CATS, no one wins!", "DRAW", MessageBoxButtons.OK);
                xScoreLabel.Text = xScore.ToString();
                ClearButtons();
                WhosTurn();
            }
            if (!isOTurn && singleButton.Checked)
            {
                RunAI();
            }
        }

        public void ChangeTile(Button sender)
        {
            if (sender.Text == "_")
            {
                sender.Text = (isOTurn) ? "O" : "X";
                isOTurn = !isOTurn;
                turn.Text = (isOTurn) ? "O" : "X";
                turnLabel.Text = (!isOTurn && singleButton.Checked) ? "Computer's Turn :" : "Player's Turn :";
            }

            CheckConditions();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeTile(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeTile(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeTile(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeTile(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeTile(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeTile(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeTile(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeTile(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeTile(button9);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearButtons();
            oScore = 0;
            xScore = 0;
            xScoreLabel.Text = xScore.ToString();
            oScoreLabel.Text = oScore.ToString();
            WhosTurn();
            RunAI();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void multiButton_CheckedChanged(object sender, EventArgs e)
        {
            turnLabel.Text = (!isOTurn && singleButton.Checked) ? "Computer's Turn :" : "Player's Turn :";
            RunAI();
        }

        private void singleButton_CheckedChanged(object sender, EventArgs e)
        {
            turnLabel.Text = (!isOTurn && singleButton.Checked) ? "Computer's Turn :" : "Player's Turn :";
            RunAI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
