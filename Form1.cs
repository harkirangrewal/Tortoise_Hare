using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortoise_Hare
{
    public partial class Form1 : Form
    {
        Hare Bob;
        Tortoise Shelly;
        public class Contender
        {
            // Variables are declared to keep track of the position, length of race, score and a random number generator.
            protected int iPosition;
            protected int iNumberofSteps;
            public Random  Rand;
            public int iScore;
           
            
            // Contructors created for the Contender class
            // Default values are set in the default constructor
            public Contender()
            {
                iPosition = 1;
                iNumberofSteps = 70;
                Rand = new Random();
            }

            // This constructor allows the race length to be set
            public Contender(int steps)
            {
                iPosition = 1;
                iNumberofSteps = steps;
                Rand = new Random();
            }
            
            // Getters and setter created for the two int values (position and steps)
            public void set_position(int position)
            {
                iPosition = position;
            }

            public int get_position()
            {
                return iPosition;
            }

            public void set_steps(int steps)
            {
                iNumberofSteps = steps;
            }
            
            public int get_steps()
            {
                return iNumberofSteps;
            }

            // The method IsWinner is declared to figure out who the winner is
            // True or false is returned, to indicate who won the race
            public bool IsWinner()
            {
               
                if (iPosition == iNumberofSteps)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
          
        }
        // A child class is created for the tortoise (having the base/parent class the contender)
        class Tortoise : Contender
        {
            //Returns back to base-nothing needs to be added
            public Tortoise ():base()
            {

            }
            public Tortoise(int stp) : base(stp)
            {

            }

            // Using the random number generator to generate a value, that determines the movements of the objects
            public void UpdatePosition()
            {
                int RandomNumber = Rand.Next(1, 101);
                

                // If the nummber is greater than or equal to 50 fast plod
                if (RandomNumber <= 50)
                {
                    iPosition = iPosition + 3;
                }
                // If the number is between 50 and 70, large slip
                else if (RandomNumber > 50 && RandomNumber <=70 )
                {
                    iPosition = iPosition - 6;
                }
                // If the number is between 70 and 100, slow plod
                else if (RandomNumber > 70 && RandomNumber <= 100)
                {
                    iPosition = iPosition +1;
                }
              

                 //Capping race off at 0, no player will go less than or more than the track
               if (iPosition < 0 )
                {
                    iPosition = 1;
                }
                else if (iPosition > 70)
                {
                    iPosition = 70;
                }
           
            } 
        }
        // A second child class is created for the Hare
        class Hare: Contender
        {
            public Hare():base()
            {

            }
            public Hare(int stp): base (stp)
            {

            }
            // A method is declared to determine the movement of the Hare on the race track
            public void UpdatePosition()
            {
                // A randomnumber generator is declared to determine the ramdom movement of the Hare
               int RandomNumber = Rand.Next(1, 101);
                

                // If the nummber is between 0 and 20, the Hare does not move anywhere
                if (RandomNumber <= 20)
                {
                    iPosition = iPosition; 
                }
                // If the number is between 20 and 40, the Hare does a fast plod
                else if (RandomNumber > 20 && RandomNumber <=40 )
                {
                    iPosition = iPosition + 9;
                }
                // If the number is between 40 and 50, the Hare does a big slip
                else if (RandomNumber > 40 && RandomNumber <= 50)
                {
                    iPosition = iPosition -12;
                }
                // If the number is between 50 and 80, the Hare does a slow plod
                else if (RandomNumber > 50 && RandomNumber <= 80)
                 {
                        iPosition = iPosition + 1 ;
                 }
                // If the number is between 80 and 100, the Hare does a small slip
                else if(RandomNumber > 80 && RandomNumber <= 100)
                {
                    iPosition = iPosition -2;
                }

                //Capping race off at 0, no player will go less than or more than the track
                if (iPosition < 0)
                {
                    iPosition = 1;
                }
                else if (iPosition >70)
                {
                iPosition = 70;
                }
            }
        }
        //A sound player is created to play when both objects are in the same position
        System.Media.SoundPlayer ouchSoundPlayer = new System.Media.SoundPlayer(@"Ouch Sound.wav");
        public Form1()
        {
            
            InitializeComponent();
            // The objects for the tortise and hare are created/constructed
            Bob = new Hare(); 
            Shelly = new Tortoise();

            // The tracks that the animals run on are declared as children of the animal's picture box
            // This ensures that the animal moves using the co-ordinates on the track, and not the form
            pbHare.Parent = pbHareTrack;
            pbTortoise.Parent = pbTortoiseTrack;

            // Medium speed is set as default
            rbtnMedium.Checked = true;

            // The pause, reset and clear button are disabled when the program originally begins
            btnPause.Enabled = false;
            btnReset.Enabled = false;
            btnClear.Enabled = false;          
        }
       
        private void btnPlay_Click(object sender, EventArgs e)
        {
            // When the play button is pressed, the timer starts, certain buttons are also enabled and disabled
            timer1.Start();
            btnPause.Enabled = true;
            btnClear.Enabled = false;
            btnPlay.Enabled = false;
            btnReset.Enabled = false;
        }
      
        // After each tick of the timer, the following occurs
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Two bools are declared to store the values outputted from the IsWinner method
            bool Bob_Winner, Shelly_Winner;
       
            // The position of both animals/objects is updated (using the method in the class)
            Bob.UpdatePosition();
            Shelly.UpdatePosition();
            
            // The picture boxes are refreshed
            pbTortoiseTrack.Invalidate();
            pbHareTrack.Invalidate();
            
            // The IsWinner methods are run, to check and see if anyone has reached the end of the race
            Bob_Winner = Bob.IsWinner();
            Shelly_Winner = Shelly.IsWinner();

            // If both animals have reached the end of the race, the following occurs
            if(Bob_Winner == true && Shelly_Winner == true)
            {
                // The timer stops, the declaration of the tie is reported to the user (using the list box)
                timer1.Stop();
                lb_output.Items.Add("It's a tie!");

                // The scores for each animal are updated
                Bob.iScore = Bob.iScore + 1;
                Shelly.iScore = Shelly.iScore + 1;
                btnPlay.Enabled = false;
            }
            // If bob the Hare wins, the following occurs
            else if( Bob_Winner == true)
            {
                // The timer stops, the win is outputted to the user, and the score is updated
                timer1.Stop();
                lb_output.Items.Add("The hare wins!");
                Bob.iScore = Bob.iScore + 1;
                btnPlay.Enabled = false;
            }

            // If the tortiose Shelly wins, the following occurs
            else if (Shelly_Winner == true)
            {
                // The timer stops, the win is outputted to the user, and the score is updated
                timer1.Stop();
                lb_output.Items.Add("The tortoise wins!");
                Shelly.iScore = Shelly.iScore + 1;
                btnPlay.Enabled = false;
            }

            // If Bob and Shelly are at the same position in the race, the following occurs
            if(Bob.get_position() == Shelly.get_position())
            {
                // The status us outputted to the user, and the sound player is used to play a sound
                lb_output.Items.Add("OUCH!");
                ouchSoundPlayer.Play();
            }

            // If either animals reaches the end of the race, the following occurs
            if (Bob.get_position() == 70 || Shelly.get_position() == 70)
            { 
                // The buttons (Reset & Clear) are enabled, while the rest are disabled
                btnPause.Enabled = false;
                btnPlay.Enabled = false;
                btnReset.Enabled = true;
                btnClear.Enabled = true;
            }

            // The scoreboard is updated
            lblHareScore.Text = Bob.iScore.ToString();
            lblTortoiseScore.Text = Shelly.iScore.ToString();
        }

        // If the radio button used to speed up the score is selected, the timer speed is increased.
        private void rbtnFast_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // When the game is paused, the timer stops, and the following buttons are disabled and enabled
            timer1.Stop();
            btnPause.Enabled = false;
            btnPlay.Enabled = true;
            btnClear.Enabled = true;
            btnReset.Enabled = true;
            
        }

        // When the medium speed radio button is selected, the timer speed changes 
        private void rbtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        // When the slow speed radio button is selected, the timer speed changes
        private void rbtnSlow_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
        }

        // The following draws the track for Shelly and sets the position for the picture box
        private void pbTortoiseTrack_Paint(object sender, PaintEventArgs e)
        {
            Pen myRedPen = new Pen(Color.Red, 5);
            Pen myBlackPen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(myBlackPen, 0, 25, 770, 25);
            e.Graphics.DrawLine(myRedPen, 765, 0, 765, 50);
            pbTortoise.Top = 10;
            pbTortoise.Left = Shelly.get_position() * 11;
        }

        // The following draws the track for Bob and sets the position for the picture box
        private void pbHareTrack_Paint(object sender, PaintEventArgs e)
        {
            Pen myRedPen = new Pen(Color.Red, 5);
            Pen myBlackPen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(myBlackPen, 0, 25, 770, 25);
            e.Graphics.DrawLine(myRedPen, 765, 0, 765, 50);
            pbHare.Top = 10;
            pbHare.Left = Bob.get_position() * 11;
        }

        private void lbl_output_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // The following code is run when the RESET button is pressed
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Each object's position is set to zero
            Bob.set_position(0);
            Shelly.set_position(0);

            // The timer stops, and the position of the animal is set back to normal (in proprotion to the track)
            timer1.Stop();
       
            pbTortoise.Top = 10;
            pbTortoise.Left = Shelly.get_position() * 11;

            pbHare.Top = 10;
            pbHare.Left = Bob.get_position() * 11;

            lb_output.Items.Clear();

            rbtnMedium.Checked = true;
            btnPlay.Enabled = true;
        }

        // The following occurs when the Clear button is pressed
        private void btnClear_Click(object sender, EventArgs e)
        {
            // The score is reset, and outputted to the scoreboard
            Bob.iScore = 0;
            Shelly.iScore = 0;

            lblHareScore.Text = "0";
            lblTortoiseScore.Text = "0";
        }
    }
}
