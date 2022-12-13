using Raylib_cs;
using System.Collections.Generic;

namespace tower_game
{
    public class Movement
    {

        public List<Enemy.enemy> navigateEnemies(List<Enemy.enemy> enemies, List<Rectangle> trackList)
        {
            int length = enemies.Count;

            for(int i = 0; i < length; i++)
            {
                Enemy.enemy currentEnemy = enemies[i];
                currentEnemy.location = navigate(trackList, currentEnemy.location);
                currentEnemy.collision = moveCollision(trackList, currentEnemy.collision);
                enemies[i] = currentEnemy;
            }

            return enemies;
        }


        public Rectangle navigate(List<Rectangle> trackList, Rectangle location)
        {
            Rectangle trackListSection1 = trackList[0];
            Rectangle trackListSection2 = trackList[1];
            Rectangle trackListSection3 = trackList[2];
            Rectangle trackListSection4 = trackList[3];
            Rectangle trackListSection5 = trackList[4];
            

            if(location.x < trackListSection1.x + trackListSection1.width)
            {
                location.x ++;
            }

            else if (location.x == trackListSection1.x + trackListSection1.width && location.y < trackListSection2.y + trackListSection2.height)
            {
                location.y ++;
            }

            else if(location.y== trackListSection2.y + trackListSection2.height && location.x < trackListSection3.x + trackListSection3.width - 100)
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

        private Rectangle moveCollision(List<Rectangle> trackList, Rectangle collision)
        {

            Rectangle trackListSection1 = trackList[0];
            Rectangle trackListSection2 = trackList[1];
            Rectangle trackListSection3 = trackList[2];
            Rectangle trackListSection4 = trackList[3];
            Rectangle trackListSection5 = trackList[4];
            

            if(collision.x < trackListSection1.x + trackListSection1.width)
            {
                collision.x ++;
            }

            else if (collision.x == trackListSection1.x + trackListSection1.width && collision.y < trackListSection2.y + trackListSection2.height)
            {
                collision.y ++;
            }

            else if(collision.y== trackListSection2.y + trackListSection2.height && collision.x < trackListSection3.x + trackListSection3.width - 100)
            {
                collision.x ++;
            }

            else if(collision.x == trackListSection3.x + trackListSection3.width - 100 && collision.y > trackListSection4.y - 100)
            {
                collision.y --;
            }

            else if(collision.y == trackListSection4.y - 100 && collision.x < trackListSection5.x + trackListSection5.width)
            {
                collision.x ++;
            }

            return collision;
        }

      
    }
}