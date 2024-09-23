using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class StationaryBlock : ISprite
    {
        public Texture2D Texture { get; set; }
        public Rectangle SourceRectangle { get; set; }

        public StationaryBlock(int x, int y, Texture2D texture, Rectangle sourceRectangle)
        {
            Texture = texture;
            SourceRectangle = sourceRectangle;
        }

        public void Update(int x, int y)
        {
            // Update logic if needed
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            spriteBatch.Draw(Texture, new Vector2(100, 100), SourceRectangle, Color.White);
        }
    }
}