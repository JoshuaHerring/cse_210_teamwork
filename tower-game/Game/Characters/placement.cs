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
                    Immutables.pictureLocations.Add(grid.returnsCurrentBox(mouseServices.mousePosition()), "dragon");
                    Immutables.click = false;
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