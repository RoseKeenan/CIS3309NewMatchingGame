/* Rose Marie Keenan
 * Maryam Salawu
 * CIS 3309 Section 01
 * Matching Game
 * Card Class
 * Due: 04.05.2020
 * Includes information on the card
 * Assigns picture each card
 * Includes isMatch method that checks if the two cards images match
 */



using System;
using System.Windows.Forms;
using MatchingGame.Classes;
using MatchingGame.Forms;
using MatchingGame.Properties;

//Purpose: Stores an integer value of the card and references an image

namespace MatchingGame_Project_III_.Classes
{

    class Card_Class
    {
    }
}

public class Card_Classclass
{
     static frmGame form1= new frmGame();  //instance of the frmGame
     private static int NUMBER_OF_MATCHES = 0;      //number of matches the user gets
   
    //finds a match
    public static Boolean isMatch(PictureBox previous, PictureBox current)
    {
        if (previous.Tag.ToString() == current.Tag.ToString())  // compare the two cards tag
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            previous.Visible = false;
            current.Visible = false;
            NUMBER_OF_MATCHES++;
            form1.increaseScore();           
           
            if (BoardClass.getNumberOfPairs == NUMBER_OF_MATCHES)   //found all pairs
            {
                //form1.StopTimer();        // call a method to stop the timer (frmGame)
                return true;
                
            }
            
        }
        else
        {
            Application.DoEvents();                 //if the tags are not equal flip them back over
            System.Threading.Thread.Sleep(500);     
            previous.Image = Resources.heartCover;
            current.Image = Resources.heartCover;
            return false;
        }

        return false;
    }


    //  converts all  picureBox tags to image
    public static void showImage(PictureBox box)
    {
        switch (Convert.ToInt32(box.Tag))
        {
            case 1:
                box.Image = Resources.butterfly;
                break;
            case 2:
                box.Image = Resources.crocodile;
                break;
            case 3:
                box.Image = Resources.elephant;
                break;
            case 4:
                box.Image = Resources.frog;
                break;
            case 5:
                box.Image = Resources.lion;
                break;
            case 6:
                box.Image = Resources.sea_lion;
                break;
            case 7:
                box.Image = Resources.squid;
                break;
            case 8:
                box.Image = Resources.worm;
                break;
            default:
                box.Image = Resources.heartCover;
                break;
        }
       

    }

}
