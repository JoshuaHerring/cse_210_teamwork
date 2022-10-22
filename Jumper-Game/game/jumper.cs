// Josh is doing this

using System;
using System.Collections.Generic;
using System.Linq;
namespace Test
{
    public class jumper
    {
        ///<summary>
        ///<para> Creates the starting parachuter in a list</para> returns that list
        ///</summary>
        public List<string> originalImage()
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
            int lengthOfImage = originalImage.Count;
            for (int i = 0; i < lengthOfImage; i++)
            {
            Console.WriteLine(originalImage[i]);
            }

            return originalImage;
        }

        ///<summary> Changes the list Image to progress towards the final result on wrong guess </summary>
        public List<string> editImage(List<string> image)
        {
            int length = image.Count;
            if (length > 3)
            {
                image.RemoveAt(0);
            }
            else if ( length == 4)
            {
                Console.WriteLine("working?");
                image[0] = "  x";
            }

            return image;
        }

        ///<summary> Compares the current image to the final image to see if failed returns bool</summary>
        private void checkForFailure()
        {
               List<string> finalImage = new List<string>() 
               {
                "  x",
                " /|\\",
                " / \\"
               };

        }

        ///<summary> Prints the failed result along with the correct word</summary>
        private void failed()
        {

        }

    }
}