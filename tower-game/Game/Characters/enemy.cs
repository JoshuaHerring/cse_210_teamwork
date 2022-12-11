using System.Collections.Generic;
using System;
using Raylib_cs;
namespace tower_game
{
    public class Enemy
    {
        VideoServices videoServices = new VideoServices();
        //     List<Rectangle> list = new List<Rectangle>()
        //     {
        //     grid.selectBoxxes(Immutables.x0, 400, Immutables.yE400, 100),
        //     grid.selectBoxxes(Immutables.x400, 100, Immutables.yE400, 200),
        //     grid.selectBoxxes(Immutables.x400, 400, Immutables.yG600, 100),
        //     grid.selectBoxxes(Immutables.x700, 100, Immutables.yC200, 400),
        //     grid.selectBoxxes(Immutables.x700, 500, Immutables.yB100, 100)
        //     };
        //     return list;
        // what it is, pathing(rectangles), stats

        ///<summary> List of two int</summary>
        public Rectangle navigate(List<Rectangle> trackList, Rectangle location)
        {
            Rectangle trackListSection1 = trackList[0];
            Rectangle trackListSection2 = trackList[1];
            Rectangle trackListSection3 = trackList[2];
            Rectangle trackListSection4 = trackList[3];
            Rectangle trackListSection5 = trackList[4];
            
                Console.WriteLine("location" +location);
                Console.WriteLine("section 5" + trackListSection4);
            if(location.x < trackListSection1.x + trackListSection1.width)
            {
                location.x ++;
            }

            else if (location.x == trackListSection1.x + trackListSection1.width && location.y < trackListSection2.y + trackListSection2.height)
            {
                location.y ++;
            }

            else if(location.y== trackListSection2.y + trackListSection2.height && location.x < trackListSection3.x + trackListSection3.width - 100) /////why - 100 neccesarry?
            {
                location.x ++;
            }

            else if(location.x == trackListSection3.x + trackListSection3.width - 100 && location.y > trackListSection4.y - 100)
            {
                location.y --;
            }

            else if(location.y == trackListSection4.y - 100 && location.x < trackListSection5.x + trackListSection5.width)
            {
                location.x ++;
            }



            return location;
        }

    }
}