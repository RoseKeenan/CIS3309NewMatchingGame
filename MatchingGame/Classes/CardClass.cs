using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchingGame_Project_III_.Classes;

//Purpose: Stores an integer value of the card and references an image

namespace MatchingGame_Project_III_.Classes
{

    class Card_Class
    {
    }
}

public class Card_Classclass : Form
{

    //array of an image class

    public static List<Bitmap> pictures = new List<Bitmap>(){

                    //Properties.Resources.bird,
                    //Properties.Resources.bird,
                    //Properties.Resources.cat,
                    //Properties.Resources.cat,
                    //Properties.Resources.elephant,
                    //Properties.Resources.elephant,
                    //Properties.Resources.fox,
                    //Properties.Resources.fox,
                    //Properties.Resources.monkey,
                    //Properties.Resources.monkey,
                    //Properties.Resources.panda,
                    //Properties.Resources.panda,
                    //Properties.Resources.puppy,
                    //Properties.Resources.puppy,
                    //Properties.Resources.sheep,
                    //Properties.Resources.sheep
        };



    //assign a value to each image
    public static void Tags(int index)
    {
        switch (index)
        {
            case 0:
            case 1:
                pictures[index].Tag = "bird";
                break;
            case 2:
            case 3:
                pictures[index].Tag = "cat";
                break;
            case 4:
            case 5:
                pictures[index].Tag = "elephant";
                break;
            case 6:
            case 7:
                pictures[index].Tag = "fox";
                break;
            case 8:
            case 9:
                pictures[index].Tag = "monkey";
                break;
            case 10:
            case 11:
                pictures[index].Tag = "panda";
                break;
            case 12:
            case 13:
                pictures[index].Tag = "puppy";
                break;
            case 14:
            case 15:
                pictures[index].Tag = "sheep";
                break;
        }

    }

}
