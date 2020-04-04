using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchingGame.Classes;
using MatchingGame_Project_III_.Classes;


namespace MatchingGame.Forms
{

    public partial class frmGame : Form
    {
        private const int ROWS = 4;
        private const int COLUMNS = 4;
        private const int NUMBER_OF_PAIRS = 8;

        private Button[,] newButton = new Button[ROWS, COLUMNS];

        //first card the user clicks on
        PictureBox prev;

        //used to help with matching the cards
        int num = 0;

        //number of hints the user gets
        public int hint;

        // random object
        Random RandomObj = new Random();

        //starts the timer
        int count = 0;                

        //boolean to lead the timer to a stop
        Boolean foundMatches = false;

        //ensures the user hits start before playing
        Boolean startGame = false;

        // Timer object
        Timer timer = new Timer();

        // 60 seconds from the start
        int timeLeft;

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        //click event for cards
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(startGame)
            {
                PictureBox current = (sender as PictureBox);  //first card cliked on
                Card_Classclass.showImage((sender as PictureBox));       //display image
                if (num == 0)
                {
                    prev = current;        // the current card becomes the second card clicked on
                    num = 1;
                }
                else if (prev != current)
                {
                    foundMatches = Card_Classclass.isMatch(prev, current);
                    num = 0;
                }
            }
           
            else
            {
                MessageBox.Show("Please hit start to begin the game.", "UH OH!");
            }

        }

        // Initialize all pictureBoxes images to a heart 
        public void resetImages()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Image = Properties.Resources.heartCover;

                }
            }
        }

        // Initialize all pictureBoxes tags to 0
        public void resetTags()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {

                    (x as PictureBox).Tag = "0";
                }
            }
        }

        //Makes all pictureboxes visible
        public void allvisibleTrue()
        {
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    (x as PictureBox).Visible = true;
                }
            }
        }

        //pictureboxes can be clicked on
        public void activeAll()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Enabled = true;
                }

            }
        }

        //pictureboes cannot be clicked on
        public void deActiveAll()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox) {

                (x as PictureBox).Enabled = false; }
            }
        }
        

       // Set Tag values at random to each picturebox
        public void Tags()
        {
            int[] arr = new int[16];
            int i = 0;

            int r;
            while (i < 16)
            {
                r = RandomObj.Next(1, 17);          //generates a random number
                if (Array.IndexOf(arr, r) == -1)
                {
                    arr[i] = r;
                    i++;
                }
            }
            for (i = 0; i < 16; i++)     // if i is greater than 8 then subtract from 8 b/c there are only 8 images
            {
                if (arr[i] > 8)
                {
                    arr[i] -= 8;
                }
            }
            i = 0;
            foreach (Control x in this.Controls)          //assigns a random number to each picturebox
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Tag = arr[i].ToString();   //sets array's numbers to pictureBoxes tags
                    i++;
                }
            }
        }
 
        //starts the matching game
        public void StartGame()
        {
            Tags();     //set tag numbers to each picturebox
            allvisibleTrue();
            btnHint.Enabled = true;
            resetImages();
            num = 0;     
            activeAll();
        }

        //turns over all the cards for 1 second
        private void btnHint_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)

                { Card_Classclass.showImage((x as PictureBox)); }
            }
            Application.DoEvents();
            btnHint.Enabled = false;   //disable the hint button
            System.Threading.Thread.Sleep(1000);    // displays images for 1 second
            resetImages();
           

        }

        public void increaseScore()
        {
            PlayerClass.increaseScore();
        }

        //stops the timer
        public void StopTimer()
        {
            MessageBox.Show("Congratulations you win!");
            btnHint.Enabled = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (foundMatches)
            {
                timer1.Stop();
                int totalScore = timeLeft + PlayerClass.getScore();
                MessageBox.Show("Well done, " + PlayerClass.getName() + "! You found all the matches! \nYou found the matches in " + (60 - timeLeft) + " seconds!" +
                    "\nYour total score is: " + totalScore, "CONGRATULATIONS");
                playAgain();
            }

            else if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timerLabel.Text = timeLeft + " seconds";
            }

            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timerLabel.Text = "Time's up!";
                MessageBox.Show("Aw man! You didn't finish in time. Your score is: " + PlayerClass.getScore(), "SORRY!");
                playAgain();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startGame = true;
            timeLeft = 60;
            timerLabel.Text = "60 seconds";
            timer1.Start();
            count++;
        }

        private void playAgain()
        {
            DialogResult play = MessageBox.Show("Would you like to play again?", "TRY AGAIN?", MessageBoxButtons.YesNo);
            switch (play)
            {
                case DialogResult.Yes:
                    Application.Restart();
                    break;
                case DialogResult.No:
                    Close();
                    break;
            }
        }
    }
 }
