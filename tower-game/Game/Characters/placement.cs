using Raylib_cs;
using System.Collections.Generic;
using System;

namespace tower_game
{
    public class Placement
    {
        MouseServices mouseServices = new MouseServices();
        VideoServices videoServices = new VideoServices();
        Grid grid = new Grid();
        private void pictureDrag()
        {
                videoServices.drawSprite(mouseServices.mousePosition(), "dragon");
        }
        public void picturePlacement()
        {
            bool item = false;
            bool dragon = false;
            Rectangle location = new Rectangle();
            if(Raylib.CheckCollisionRecs(mouseServices.mousePosition(), grid.selectBox(Immutables.x5, Immutables.yI)))
            {
                if(mouseServices.mouseClick())

                    Immutables.click = true;
            }
            else if(Immutables.click)
            {
                pictureDrag();
                if(mouseServices.mouseClick())
                {
                    foreach(KeyValuePair<Rectangle, string> entry in Immutables.pictureLocations)
                    {
                        // if(Raylib.CheckCollisionRecs(grid.returnsCurrentBox(mouseServices.mousePosition()), entry.Key))
                        // {
                        //     item = false;
                        //     dragon = false;
                        //     Raylib.DrawText("Cannot Place Here", (int)mouseServices.mousePosition().x, (int)mouseServices.mousePosition().y, 12, Color.BLACK);   
                        //     Console.WriteLine("IDIOT");
                        // }
                        // else
                        // {
                            item = true;
                            dragon = true;
                            location = grid.returnsCurrentBox(mouseServices.mousePosition());
                            Immutables.click = false;
                            Console.WriteLine("IDIOT3");
                            break;
                        // }
                    }
                    if(item == true && dragon == true)
                    {
                        Console.WriteLine("Idiot4");
                        Immutables.pictureLocations.Add(location, "dragon");
                        item = false;
                        dragon = false;
                    }
                }
            }
        }
        public void drawPictures()
        {
            foreach(KeyValuePair<Rectangle, string> entry in Immutables.pictureLocations)
            {
                videoServices.drawSprite(entry.Key, entry.Value);
            }
        }
    }
}