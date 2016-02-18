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
    public partial class listDisplayScreen : UserControl
    {
        public listDisplayScreen()
        {
            InitializeComponent();
            int timesGuessed = gameScreen.guessList.Count;
            timesAttemptedLabel.Text = timesAttemptedLabel.Text + " " + Convert.ToString(timesGuessed);
            guessLabel.Text = guessLabel.Text + "\n";
            orderLabel.Text = orderLabel.Text + "\n";
            for (int i = 0; i < timesGuessed; i++)
            {
                guessLabel.Text = guessLabel.Text + Convert.ToString(gameScreen.guessList[i]) + ", ";
            }
            gameScreen.guessList.Sort();
            for (int i = 0; i < gameScreen.guessList.Count; i++)
            {
                orderLabel.Text = orderLabel.Text + Convert.ToString(gameScreen.guessList[i]) + ", ";
            }
        }
        
    }
}
