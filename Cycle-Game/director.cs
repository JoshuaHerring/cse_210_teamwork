using Raylib_cs;
using System.Collections.Generic;

namespace Cycle_Game
{
    ///<summary>Leads the game through the program to run the game properly</summary>
    public class Director
    {
        VideoServices videoServices = new VideoServices();
        Movement movement = new Movement();
        Tail tail = new Tail();
        Collision collision = new Collision();
        Border border = new Border();
        GameOver gameOver = new GameOver();
        Cycle cycle = new Cycle();

        ///<summary>Starts the game by calling the neccecary functions from other classes</summary>
        public void start_game()
        {
            string direction = "down";
            string direction2 = "up";
            List<Rectangle> collisionBoxes = new List<Rectangle>();
            List<Coords.coordinates> tailHolder = new List<Coords.coordinates>();
            List<Coords.coordinates> tailHolder2 = new List<Coords.coordinates>();
            Coords.coordinates head_location;
            Coords.coordinates head_location2;
            head_location.x = 200;
            head_location.y = 200;
            head_location2.x = 600;
            head_location2.y = 600;
            string winner = "";
            string loser = "";
            Raylib.SetTargetFPS(Immutables.fps);
            
            
            videoServices.openScreen("Game");
            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib_cs.Color.BLACK);

                ///output
                cycle.draw_head(head_location, Color.player1Color);
                if(collision.checkCollision(head_location, collisionBoxes))
                {
                    winner = "blue";
                    loser =  "red";
                    break;
                }
                collisionBoxes = collision.addCollision(head_location, collisionBoxes);
                cycle.draw_head(head_location2, Color.player2Color);
                if(collision.checkCollision(head_location2, collisionBoxes))
                {
                    winner = "red";
                    loser = "blue";
                    break;
                }
                collisionBoxes = collision.addCollision(head_location2, collisionBoxes);
                videoServices.draw_tail(tailHolder, Raylib_cs.Color.RED);
                videoServices.draw_tail(tailHolder2, Raylib_cs.Color.BLUE);

                ///logic
                tailHolder = tail.addTailSegment(head_location, tailHolder);
                tailHolder2 = tail.addTailSegment(head_location2, tailHolder2);
                head_location = border.borderControl(head_location);
                head_location2 = border.borderControl(head_location2);



                ///input
                direction = movement.changeDirectionWASD(direction);
                direction2 = movement.changeDirectionIJKL(direction2);
                head_location = movement.move(direction, head_location);
                head_location2 = movement.move(direction2, head_location2);

                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
            
            gameOver.endScreen(winner, loser);
        }
    }
}