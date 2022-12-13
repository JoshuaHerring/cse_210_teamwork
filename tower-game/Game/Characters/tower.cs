using System.Collections.Generic;
using Raylib_cs;
using System.Numerics;
using System;

namespace tower_game
{
    public class Tower
    {
        Grid grid = new Grid();
        Projectile projectile = new Projectile();
        Enemy enemy = new Enemy();
        public void towerCreation()
        {
                        Rectangle test = new Rectangle();
            Rectangle location = new Rectangle();
            foreach(KeyValuePair<Rectangle, string> entry in Immutables.pictureLocations)
            {
                if(entry.Value == "dragon")
                {
                    Vector2 locationVector = new Vector2(entry.Key.x + 50, entry.Key.y + 50);
                    Raylib.DrawCircleLines((int)entry.Key.x + 50, (int)entry.Key.y + 50, 150, Color.GREEN);
                    for(int i = 0; i <= Immutables.enemies.Count - 1 ; i++)
                    {
                    if(Raylib.CheckCollisionCircleRec(locationVector, 150, Immutables.enemies[i].collision))
                    {
                        Enemy.enemy curretnEnemy = Immutables.enemies[i];
                        curretnEnemy.hp --;
                        Immutables.enemies[i] = curretnEnemy;
                        enemy.Death(i, Immutables.enemies[i]);
                        Console.WriteLine("hp" + curretnEnemy.hp);
                        
                        // Raylib.DrawRectangleRec(grid.rectangleList()[7], Immutables.clearGreen);
                        // Immutables.allowProjectile = true;
                        // location = Immutables.enemies[i].collision;
                        // test = entry.Key;
                    }
                    }
                }
            if(Immutables.allowProjectile)
            {
             test = projectile.projectile(location, test);  
            }
            }
        }   
    }
}