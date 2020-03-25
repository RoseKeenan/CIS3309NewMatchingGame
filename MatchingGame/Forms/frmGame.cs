using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MatchingGame.Forms
{
    public partial class frmGame : Form
    {

        private const int ROWS = 4;
        private const int COLUMNS = 4;
        private const int NUMBER_OF_PAIRS = 8;

        private Button[,] newButton = new Button[ROWS, COLUMNS];

        int padding = 20;


        //sets up timer
        Timer clickTimer = new Timer();
        int time = 60;  //60 seconds
        Timer timer = new Timer { Interval = 1000 };

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            createBoard();
        }

        public void createBoard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form

            Size size = new Size(75, 75);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            for (int row = 0; row < ROWS; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < COLUMNS; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Enabled = true;

                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Text = "❤";
                    //int value = Convert.ToInt16(newButton[row, col].Text);

                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    //newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);
                }
            }
        } // end createBoard

        private void btnTestCard_Click(object sender, EventArgs e)
        {
            timer.Start();  //Timer starts
            timer.Tick += delegate
            {

                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Out of Time");
                    //reset images
                }
                var ssTime = TimeSpan.FromSeconds(time);
                lblTimer.Text = "00:" + time.ToString();  //displays the timer on board
            };
        }

    }
}
