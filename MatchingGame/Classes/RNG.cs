using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchingGame_Project_III_.Classes;
using MatchingGame.Forms;
using MatchingGame.Properties;


//Purpose: randomly select a card from collection and randomly place on the board
namespace MatchingGame.Classes
{

    public class RNG : Form
    {
        
        public static Random RandomObj;
       

        // Type random object
        public RNG()
        {
            RandomObj = new Random();
            // Creates a random object
        }  // end RNG

        //Set Tag values at random

        //public void Tags()
        //{
        //    int[] arr = new int[16];
        //    int index = 0;

        //    int r;
        //    while (index < 16)
        //    {
        //        r = RandomObj.Next(1, 17);
        //        if (Array.IndexOf(arr, r) == -1)
        //        {
        //            arr[index] = r;
        //            index++;
        //        }
        //    }
        //    for (index = 0; index < 16; index++)
        //    {
        //        if (arr[index] > 8) arr[index] -= 8;
        //    }
        //    index = 0;
        //    foreach (Control x in this.Controls)
        //    {
        //        if (x is PictureBox)
        //        {
        //            (x as PictureBox).Tag = arr[index].ToString();
        //            index++;
        //        }
        //    }


        //}

    }
}


    
