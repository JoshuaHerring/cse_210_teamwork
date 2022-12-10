using Raylib_cs;

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
                    videoServices.drawSprite(grid.returnsCurrentBox(mouseServices.mousePosition()), "dragon");   
                    Immutables.click = false;
                }
            }
        }
    }
}