// Josh is doing this

using System;
using System.Collections.Generic;
namespace Test
{
    public class jumper
    {
        ///<summary>
        ///<para> Creates the starting parachuter in a list</para> returns that list
        ///</summary>
        private List<string> originalImage()
        {

            List<string> originalImage = new List<string>() {
                " ___",
                "/___\\",
                "\\   /",
                " \\ /",
                "  O",
                " /|\\",
                " / \\"
            };

            return originalImage;
        }

        public List<string> originalImageGet()
        {
            List<string> image = originalImage();

            return image;
        }

        ///<summary> Changes the list Image to progress towards the final result on wrong guess </summary>
        public List<string> editImage(List<string> image)
        {
            int length = image.Count;
            if (length > 3)
            {
                image.RemoveAt(0);
            }
            if ( length == 4)
            {

                image[0] = "  x";
            }

            return image;
        }

        ///<summary> Compares the current image to the final image to see if failed returns bool
        ///<para> returns a bool true if game is over and false if continues</para>
        ///</summary>
        private bool checkForFailure(List<string> curretImage)
        {
            bool over = false;
            List<string> finalImage = new List<string>() 
            {
            "  x",
            " /|\\",
            " / \\"
            };

            if (curretImage == finalImage)
            {
                over = true;
            }
            return over;
        }

        ///<summary> Prints the failed result along with the correct word</summary>
        private void failed()
        {

        }

    }
}