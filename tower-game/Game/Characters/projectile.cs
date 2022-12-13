using Raylib_cs;

namespace tower_game
{
    public class Projectile
    {
        VideoServices videoServices = new VideoServices();
        public Rectangle projectile(Rectangle collision, Rectangle location)
        {
            if(location.x != collision.x && location.y != collision.y)
            {
                location.x ++;
                location.y ++;
                videoServices.drawSprite(location, "maybe");
                return location;
            }
            return location;
        }
    }
}