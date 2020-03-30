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

        int padding = 20;

        Timer clickTimer = new Timer();
        int time = 60;  //60 seconds
        Timer timer = new Timer { Interval = 1000 };
        PictureBox prev;       //first card the user clicks on
        int num = 0;          //used to help with matching the cards
        public int hint;        //number of hints the user gets
        Random RandomObj = new Random();        // random object
        int count = 0;                //starts the timer
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
            PictureBox current = (sender as PictureBox);  //first card cliked on
            if (count == 0)  //allows the timer to start once
            {
                Timer();
                count++;
                
            }

            else
            {
                Card_Classclass.showImage((sender as PictureBox));       //display image
                if (num == 0)
                {
                    prev = current;        // the current card becomes the second card clicked on
                    num = 1;
                }
                else if (prev != current)
                {
                    Card_Classclass.isMatch(prev, current);
                    num = 0;
                }
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
        //timer 
        public void Timer()
        {

            timer.Start();  //Timer starts
            timer.Tick += delegate
            {

                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Out of Time");
                    
                }
                var ssTime = TimeSpan.FromSeconds(time);
                txtTimer.Text = "00:" + time.ToString();  //displays the timer on board
            };
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
        //stops the timer
        public void StopTimer()
        {
            timer.Stop();
            txtTimer.Text = "";
            MessageBox.Show("Congratulations you win!");
            btnHint.Enabled = false;

        }
     }
    //public void createBoard()
    //{
    //    // Dynamically Creates 25 buttons on a Bingo Board 
    //    // Written by Bill Hall with Joe Jupin and FLF
    //    // This should be enough help for all of you to adapt this to your own needs
    //    // Create and  Add the buttons to the form

    //    Size size = new Size(75, 75);
    //    Point loc = new Point(0, 0);
    //    int topMargin = 60;

    //    for (int row = 0; row < ROWS; row++)
    //    {
    //        loc.Y = topMargin + row * (size.Height + padding);
    //        int extraLeftPadding = 50;
    //        for (int col = 0; col < COLUMNS; col++)
    //        {
    //            newButton[row, col] = new Button();
    //            newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
    //            newButton[row, col].Size = size;
    //            newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
    //            newButton[row, col].Enabled = true;

    //            newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
    //            newButton[row, col].Text = "❤";
    //            //int value = Convert.ToInt16(newButton[row, col].Text);

    //            newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

    //            // Associates the same event handler with each of the buttons generated
    //            //newButton[row, col].Click += new EventHandler(Button_Click);

    //            // Add button to the form
    //            pnlCard.Controls.Add(newButton[row, col]);
    //        }
    //    }
    //} // end createBoard

}
