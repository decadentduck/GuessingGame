/// Description: The program generates a random number between 1-100 which
///              the use must guess
/// Author:      Mr. T

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            gameScreen gs = new gameScreen();
            this.Controls.Add(gs);
            
        }

        
    }
}
