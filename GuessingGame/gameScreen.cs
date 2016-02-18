using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class gameScreen : UserControl
    {
        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        int rand = randNum.Next(1, 101);
        public static List<int> guessList = new List<int>();
        public static int numberOfGuess = 0;
        public gameScreen()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            {
                // get the users guess and place into a variable
                int guess = Convert.ToInt16(inputBox.Text);
                guessList.Add(guess);

                label1.Text = Convert.ToString(rand);
                // check guess against the random value and output appropriate message
                if (guess < rand)
                {
                    outputLabel.Text = "Too Low!";
                }
                else if (guess > rand)
                {
                    outputLabel.Text = "Too High!";
                }
                else
                {
                    outputLabel.Text = "You Got it!";
                    

                    listDisplayScreen ld = new listDisplayScreen();

                    this.Controls.Add(ld);
                    ld.BringToFront();
                    
                }

                // clear out the input box 
                inputBox.Text = "";
            }
        }
    }
}
