using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            //initialize variables
            int die_One = 0;
            int die_Two = 0;
            int countRolls = 0;

            //initialize die objects
            Die dieOne = new Die(1);
            Die dieTwo = new Die(1);

            //while loop to check if die one and die two == 1, else execute loop body
            while (die_One != 1 && die_Two != 1) 
            {
                die_One = dieOne.RollDice();
                numOne.Text = die_One.ToString();

                die_Two = dieTwo.RollDice();
                numTwo.Text = die_Two.ToString();
                countRolls++;
                
            }
            //print how many rolls it took to get snake eyes
            count.Text = ("It took " + countRolls + " rolls to get snake eyes.");

        }
    }
}
