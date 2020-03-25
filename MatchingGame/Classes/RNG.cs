using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchingGame_Project_III_.Classes;

//Purpose: randomly select a card from collection and randomly place on the board
namespace MatchingGame.Classes
{

    class RNG : Form
    {
        public static Random RandomObj;
        
        // Type random object
        public RNG()
        {
            RandomObj = new Random();
            // Creates a random object
        }  // end RNG

        //calls the Tags method to assigns tags values to each image
        public void AssignImages()
        {
            for (int i = 0; i < Card_Classclass.pictures.Count; i++)
            {
                Card_Classclass.Tags(i);
            }
            //assigns images to each card
            foreach (Control c in this.Controls)
            {
                int j = RandomObj.Next(Card_Classclass.pictures.Count);
                PictureBox p = (PictureBox)c;     //getting a pictureBox
                p.InitialImage = Card_Classclass.pictures[j];  //setting a random image to the picturebox
                p.Tag = Card_Classclass.pictures[j].Tag;   //Image tag is equal to the picturebox tag
                Card_Classclass.pictures.RemoveAt(j);    //remove the image from the list
            }
        }
    }


}
