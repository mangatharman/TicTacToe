//Rapid App Development (SODV2101)
//Assignment 1
//Harman Mangat

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_Game
{
    public partial class Form1 : Form
    {
        Boolean check;
        int onePlus;
        Boolean winner = false; 

        //Method for when Player X wins the game
        void winnerX()
        {
            //Displaying a message once a player wins
            MessageBox.Show("Player X is the Winner!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            winner = true;

            //Increasing the win count of a player
            onePlus = int.Parse(label5.Text);
            label5.Text = Convert.ToString(onePlus + 1);
        }

        //Method for when Player O wins the game
        void winnerO()
        {
            //Displaying a message once a player wins
            MessageBox.Show("Player O is the Winner!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            winner = true;

            //Increasing the win count of a player
            onePlus = int.Parse(label6.Text);
            label6.Text = Convert.ToString(onePlus + 1);
        }

        void score()
        {
            // Code for when Player X wins
            // There are 8 different ways by which a player can win 

            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                //Chaning the background of the boxes when a player wins
                button1.BackColor = Color.Teal;
                button2.BackColor = Color.Teal;
                button3.BackColor = Color.Teal;

                winnerX();
                reset();
            }

            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                //Chaning the background of the boxes when a player wins
                button4.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button6.BackColor = Color.Teal;

                winnerX();
                reset();
            }

            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                //Chaning the background of the boxes when a player wins
                button7.BackColor = Color.Teal;
                button8.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                winnerX();
                reset();
            }

            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                //Chaning the background of the boxes when a player wins
                button1.BackColor = Color.Teal;
                button4.BackColor = Color.Teal;
                button7.BackColor = Color.Teal;

                winnerX();
                reset();
            }

            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                //Chaning the background of the boxes when a player wins
                button2.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button8.BackColor = Color.Teal;

                winnerX();
                reset();
            }

            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                //Chaning the background of the boxes when a player wins
                button3.BackColor = Color.Teal;
                button6.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                winnerX();
                reset();
            }

            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                //Chaning the background of the boxes when a player wins
                button1.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                winnerX();
                reset();
            }

            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                //Chaning the background of the boxes when a player wins
                button3.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button7.BackColor = Color.Teal;

                winnerX();
                reset();
            }

            //******************************************************************************************
            // Code for when Player O wins
            // There are 8 different ways by which a player can win

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                //Chaning the background of the boxes when a player wins
                button1.BackColor = Color.Teal;
                button2.BackColor = Color.Teal;
                button3.BackColor = Color.Teal;

                winnerO();
                reset();
            }

            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                //Chaning the background of the boxes when a player wins
                button4.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button6.BackColor = Color.Teal;

                winnerO();
                reset();
            }

            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                //Chaning the background of the boxes when a player wins
                button7.BackColor = Color.Teal;
                button8.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                winnerO();
                reset();
            }

            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                //Chaning the background of the boxes when a player wins
                button1.BackColor = Color.Teal;
                button4.BackColor = Color.Teal;
                button7.BackColor = Color.Teal;

                winnerO();
                reset();
            }

            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                //Chaning the background of the boxes when a player wins
                button2.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button8.BackColor = Color.Teal;

                winnerO();
                reset();
            }

            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                //Chaning the background of the boxes when a player wins
                button3.BackColor = Color.Teal;
                button6.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                winnerO();
                reset();
            }

            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                //Chaning the background of the boxes when a player wins
                button1.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                winnerO();
                reset();
            }

            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                //Chaning the background of the boxes when a player wins
                button3.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button7.BackColor = Color.Teal;

                winnerO();
                reset();
            }

            //If the match is a Draw 
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && winner == false)
            {
                //Displaying a message once a player wins
                MessageBox.Show("The match is a Draw!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reset();
            }
        }

        //Method to Reset the game
        void reset()
        {
            //So that we may use the buttons again
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            //Making the buttons blank
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button12.Enabled = true; //New Game Button    

            //Making the background color snow again
            button1.BackColor = Color.Snow;
            button2.BackColor = Color.Snow;
            button3.BackColor = Color.Snow;
            button4.BackColor = Color.Snow;
            button5.BackColor = Color.Snow;
            button6.BackColor = Color.Snow;
            button7.BackColor = Color.Snow;
            button8.BackColor = Color.Snow;
            button9.BackColor = Color.Snow;

            winner = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Methods for when clicking a button 
        private void button1_Click(object sender, EventArgs e)
        {
            //Using a boolean variable, 'Check' to use X and O simultaneously
            //If check is false then it means that it's turn of Player X and if it's true then it means that it's the turn of Player O
            if (check == false)
            {
                button1.Text = "X";
                check = true;
            }
            else
            {
                button1.Text = "O";
                check = false;
            }
            button1.Enabled = false; //So that this button couldn't be used again
            score(); //Calling the Score Method
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Using a boolean variable, 'Check' to use X and O simultaneously
            //If check is false then it means that it's turn of Player X and if it's true then it means that it's the turn of Player O
            if (check == false)
            {
                button2.Text = "X";
                check = true;
            }
            else
            {
                button2.Text = "O";
                check = false;
            }
            button2.Enabled = false; //So that this button couldn't be used again
            score(); //Calling the Score Method
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Using a boolean variable, 'Check' to use X and O simultaneously
            //If check is false then it means that it's turn of Player X and if it's true then it means that it's the turn of Player O
            if (check == false)
            {
                button3.Text = "X";
                check = true;
            }
            else
            {
                button3.Text = "O";
                check = false;
            }
            button3.Enabled = false; //So that this button couldn't be used again
            score(); //Calling the Score Method
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Using a boolean variable, 'Check' to use X and O simultaneously
            //If check is false then it means that it's turn of Player X and if it's true then it means that it's the turn of Player O
            if (check == false)
            {
                button4.Text = "X";
                check = true;
            }
            else
            {
                button4.Text = "O";
                check = false;
            }
            button4.Enabled = false; //So that this button couldn't be used again
            score(); //Calling the Score Method
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Using a boolean variable, 'Check' to use X and O simultaneously
            //If check is false then it means that it's turn of Player X and if it's true then it means that it's the turn of Player O
            if (check == false)
            {
                button5.Text = "X";
                check = true;
            }
            else
            {
                button5.Text = "O";
                check = false;
            }
            button5.Enabled = false; //So that this button couldn't be used again
            score(); //Calling the Score Method
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Using a boolean variable, 'Check' to use X and O simultaneously
            //If check is false then it means that it's turn of Player X and if it's true then it means that it's the turn of Player O
            if (check == false)
            {
                button6.Text = "X";
                check = true;
            }
            else
            {
                button6.Text = "O";
                check = false;
            }
            button6.Enabled = false; //So that this button couldn't be used again
            score(); //Calling the Score Method
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Using a boolean variable, 'Check' to use X and O simultaneously
            //If check is false then it means that it's turn of Player X and if it's true then it means that it's the turn of Player O
            if (check == false)
            {
                button7.Text = "X";
                check = true;
            }
            else
            {
                button7.Text = "O";
                check = false;
            }
            button7.Enabled = false; //So that this button couldn't be used again
            score(); //Calling the Score Method
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Using a boolean variable, 'Check' to use X and O simultaneously
            //If check is false then it means that it's turn of Player X and if it's true then it means that it's the turn of Player O
            if (check == false)
            {
                button8.Text = "X";
                check = true;
            }
            else
            {
                button8.Text = "O";
                check = false;
            }
            button8.Enabled = false; //So that this button couldn't be used again
            score(); //Calling the Score Method
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Using a boolean variable, 'Check' to use X and O simultaneously
            //If check is false then it means that it's turn of Player X and if it's true then it means that it's the turn of Player O
            if (check == false)
            {
                button9.Text = "X";
                check = true;
            }
            else
            {
                button9.Text = "O";
                check = false;
            }
            button9.Enabled = false; //So that this button couldn't be used again
            score(); //Calling the Score Method
        }

        //New Game BUtton
        private void button12_Click(object sender, EventArgs e)
        {
            //So that we may use the buttons again
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            //Making the buttons blank
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            //Making the score 0
            label5.Text = "0";
            label6.Text = "0";

            //Making the background color snow again
            button1.BackColor = Color.Snow;
            button2.BackColor = Color.Snow;
            button3.BackColor = Color.Snow;
            button4.BackColor = Color.Snow;
            button5.BackColor = Color.Snow;
            button6.BackColor = Color.Snow;
            button7.BackColor = Color.Snow;
            button8.BackColor = Color.Snow;
            button9.BackColor = Color.Snow;

            winner = false;
        }

        //Reset Button
        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }

        //Exit Button
        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
