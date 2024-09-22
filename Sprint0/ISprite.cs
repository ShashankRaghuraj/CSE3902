using Microsoft.Xna.Framework.Graphics;

public interface ISprite {



    void Update(int x, int y);
    void Draw(SpriteBatch sb, Texture2D txt);
}
