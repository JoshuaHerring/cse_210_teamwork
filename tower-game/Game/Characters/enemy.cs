using System.Collections.Generic;
using System;
using Raylib_cs;
namespace tower_game
{
    public class Enemy
    {

         public struct enemy
      {
        public Rectangle location;

        public Rectangle collision;

        public int hp;
      }

      private List<enemy> addEnemy(List<enemy> badies)
      {
        enemy enemy = new enemy();
        Rectangle location = new Rectangle(Immutables.x0, Immutables.yE, 100, 100);
        Rectangle collision = new Rectangle(Immutables.x0 + 22, Immutables.yE, 52, 60);
        enemy.location = location;
        enemy.collision = collision;
        
        enemy.hp = 1000;

        badies.Add(enemy);
        return badies;
      }

      public void validateEnemyAddition(int time)
      {
        int seconds = time/60;
        Console.WriteLine("time" +time);
        Console.WriteLine("seconds " + seconds);
        Console.WriteLine(seconds%2 == 1);
        if (seconds%2 == 1)
        {
            if(Immutables.allowed)
            {
            addEnemy(Immutables.enemies);
            Immutables.allowed = false;
            }
        }
        else
        {
            Immutables.allowed = true;
        }
      }

      public void Death(int index, Enemy.enemy currentEnemy)
      {
        if(currentEnemy.hp < 0)
        {
          Immutables.enemies.RemoveAt(index);
        }
      }
  

    }
}