using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Simulator
{
    public partial class DiceSimulator : Form
    {
        
        private int diceOne;
        private int diceTwo;
        private int diceTotal;
        private int OneDice = 0;
        private int TwoDice = 0;
        private int ThreeDice = 0;
        private int FourDice = 0;
        private int FiveDice = 0;
        private int SixDice = 0;
        private int OneDiceSecond = 0;
        private int TwoDiceSecond = 0;
        private int ThreeDiceSecond = 0;
        private int FourDiceSecond = 0;
        private int FiveDiceSecond = 0;
        private int SixDiceSecond = 0;
        private int total = 0;
        private int diceTimer = 0;


        public DiceSimulator()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            tmDice.Start();
        }

        private void tmDice_Tick(object sender, EventArgs e)
        {
            //This rolls the dice
            Random rand = new Random();
            diceOne = rand.Next(1, 7);
            diceTwo = rand.Next(1, 7);

                //goes through the dice twice based on the dicTimer number
                if (diceTimer == 0)
                {
                    pbxDiceOne.Image = Properties.Resources.Die1;
                    pbxDiceTwo.Image = Properties.Resources.Die1;
                    diceTimer++;
                }

                else if (diceTimer == 1)
                {
                    pbxDiceOne.Image = Properties.Resources.Die2;
                    pbxDiceTwo.Image = Properties.Resources.Die2;
                    diceTimer++;
                }

                else if (diceTimer == 2)
                {
                    pbxDiceOne.Image = Properties.Resources.Die3;
                    pbxDiceTwo.Image = Properties.Resources.Die3;
                    diceTimer++;
                }

                else if (diceTimer == 3)
                {
                    pbxDiceOne.Image = Properties.Resources.Die4;
                    pbxDiceTwo.Image = Properties.Resources.Die4;
                    diceTimer++;
                }

                else if (diceTimer == 4)
                {
                    pbxDiceOne.Image = Properties.Resources.Die5;
                    pbxDiceTwo.Image = Properties.Resources.Die5;
                    diceTimer++;
                }

                else if (diceTimer == 5)
                {
                    pbxDiceOne.Image = Properties.Resources.Die6;
                    pbxDiceTwo.Image = Properties.Resources.Die6;
                    diceTimer++;
                }

                else if (diceTimer == 6)
                {
                    pbxDiceOne.Image = Properties.Resources.Die1;
                    pbxDiceTwo.Image = Properties.Resources.Die1;
                    diceTimer++;
                }

                else if (diceTimer == 7)
                {
                    pbxDiceOne.Image = Properties.Resources.Die2;
                    pbxDiceTwo.Image = Properties.Resources.Die2;
                    diceTimer++;
                }

                else if (diceTimer == 8)
                {
                    pbxDiceOne.Image = Properties.Resources.Die3;
                    pbxDiceTwo.Image = Properties.Resources.Die3;
                    diceTimer++;
                }

                else if (diceTimer == 9)
                {
                    pbxDiceOne.Image = Properties.Resources.Die4;
                    pbxDiceTwo.Image = Properties.Resources.Die4;
                    diceTimer++;
                }

                else if (diceTimer == 10)
                {
                    pbxDiceOne.Image = Properties.Resources.Die5;
                    pbxDiceTwo.Image = Properties.Resources.Die5;
                    diceTimer++;
                }

                else if (diceTimer == 11)
                {
                    pbxDiceOne.Image = Properties.Resources.Die6;
                    pbxDiceTwo.Image = Properties.Resources.Die6;
                    diceTimer++;
                }

            else
                {
                //first dice
                if (diceOne == 1)
                    {
                        pbxDiceOne.Image = Properties.Resources.Die1;
                        OneDice += 1; //adds one to how many times you rolled a one on the first dice
                        total += 1; //adds one for the total amount of rolls
                    }

                    else if (diceOne == 2)
                    {
                        pbxDiceOne.Image = Properties.Resources.Die2;
                        TwoDice += 1; //adds one to how many times you rolled a two on the first dice
                        total += 1; //adds one for the total amount of rolls
                    }

                    else if (diceOne == 3)
                    {
                        pbxDiceOne.Image = Properties.Resources.Die3;
                        ThreeDice += 1; //adds one to how many times you rolled a three on the first dice
                        total += 1; //adds one for the total amount of rolls
                    }

                    else if (diceOne == 4)
                    {
                        pbxDiceOne.Image = Properties.Resources.Die4;
                        FourDice += 1; //adds one to how many times you rolled a four on the first dice
                        total += 1; //adds one for the total amount of rolls
                    }

                    else if (diceOne == 5)
                    {
                        pbxDiceOne.Image = Properties.Resources.Die5;
                        FiveDice += 1; //adds one to how many times you rolled a five on the first dice
                        total += 1; //adds one for the total amount of rolls
                    }

                    else if (diceOne == 6)
                    {
                        pbxDiceOne.Image = Properties.Resources.Die6;
                        SixDice += 1; //adds one to how many times you rolled a six on the first dice
                        total += 1; //adds one for the total amount of rolls
                    }

                    //second dice
                    if (diceTwo == 1)
                    {
                        pbxDiceTwo.Image = Properties.Resources.Die1;
                        OneDiceSecond += 1; //adds one to how many times you rolled a one on the second dice
                    }

                    else if (diceTwo == 2)
                    {
                        pbxDiceTwo.Image = Properties.Resources.Die2;
                        TwoDiceSecond += 1; //adds one to how many times you rolled a two on the second dice
                    }

                    else if (diceTwo == 3)
                    {
                        pbxDiceTwo.Image = Properties.Resources.Die3;
                        ThreeDiceSecond += 1; //adds one to how many times you rolled a three on the second dice
                    }

                    else if (diceTwo == 4)
                    {
                        pbxDiceTwo.Image = Properties.Resources.Die4;
                        FourDiceSecond += 1; //adds one to how many times you rolled a four on the second dice
                    }

                    else if (diceTwo == 5)
                    {
                        pbxDiceTwo.Image = Properties.Resources.Die5;
                        FiveDiceSecond += 1; //adds one to how many times you rolled a five on the second dice
                    }

                    else if (diceTwo == 6)
                    {
                        pbxDiceTwo.Image = Properties.Resources.Die6;
                        SixDiceSecond += 1; //adds one to how many times you rolled a six on the second dice
                    }

                    diceTotal = diceOne + diceTwo; //Adds the total of the two dice
                    lblNumber.Text = "Total of the two dice is: " + diceTotal.ToString(); // shows total of the to dice

                    //Displays the number of times each number was rolled on the screen
                    lblOnes.Text = "Ones: " + OneDice.ToString();
                    lblTwos.Text = "Twos: " + TwoDice.ToString();
                    lblThrees.Text = "Threes: " + ThreeDice.ToString();
                    lblFours.Text = "Fours: " + FourDice.ToString();
                    lblFives.Text = "Fives: " + FiveDice.ToString();
                    lblSixes.Text = "Sixes: " + SixDice.ToString();
                    lblOnesSecond.Text = "Ones: " + OneDiceSecond.ToString();
                    lblTwosSecond.Text = "Twos: " + TwoDiceSecond.ToString();
                    lblThreesSecond.Text = "Threes: " + ThreeDiceSecond.ToString();
                    lblFoursSecond.Text = "Fours: " + FourDiceSecond.ToString();
                    lblFivesSecond.Text = "Fives: " + FiveDiceSecond.ToString();
                    lblSixesSecond.Text = "Sixes: " + SixDiceSecond.ToString();

                    //displays the total amount of times the dice was rolled
                    lblTotal.Text = "Total amount of times you rolled the dice: " + total;
                tmDice.Stop();
                diceTimer = 0;
            }
         }
        
        private void btnExit_Click(object sender, EventArgs e)
        { //this closes the program
            this.Close();
        }
    }
}
