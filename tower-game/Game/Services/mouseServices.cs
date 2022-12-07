using Raylib_cs;
using System;
using System.Collections.Generic;
namespace tower_game
{
    public class MouseServices
    {
        Grid grid = new Grid();
        TrackCreations trackCreation = new TrackCreations();
        public Rectangle mousePosition()
        {
            int x = Raylib.GetMouseX();
            int y = Raylib.GetMouseY();
            Rectangle position = new Rectangle(x, y, Immutables.mouseWidth , Immutables.mouseHeight);
            return position;
        }
    
        public bool mouseClick()
        {
            bool pressed = Raylib.IsMouseButtonPressed(Raylib_cs.MouseButton.MOUSE_BUTTON_LEFT);
            return pressed;
        }

        public void hoverHighlight()
        {
            
            for(int i = 0; i <= grid.rectangleList().Count-1; i++)
            {
                if(Raylib.CheckCollisionRecs(grid.rectangleList()[i], mousePosition()))
                {
                    Raylib.DrawRectangleRec(grid.rectangleList()[i], Immutables.clearGreen);
                }
            }
            for(int z = 0; z <= trackCreation.track1().Count-1; z++)
            {
                if(Raylib.CheckCollisionRecs(trackCreation.track1()[z], mousePosition()))
                {
                    for(int y = 0; y <= trackCreation.track1().Count-1; y++)
                    {
                    Raylib.DrawRectangleRec(trackCreation.track1()[y], Immutables.clearRed);
                    }
                }
            }

        }
    }
}