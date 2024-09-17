using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

public class TextSprite : ISprite {

    private int totalFrames;
    private int currentFrame;
    private SpriteFont font;

    private List<Rectangle> textRects;

    public TextSprite(int x, int y, SpriteFont sf) {
        textRects = new List<Rectangle>();
        font = sf;
        currentFrame = 0;
        totalFrames = textRects.Count;
    }

    void ISprite.Update(int x, int y) {
        currentFrame++;
        if(currentFrame >= totalFrames) {
            currentFrame = 0;
        }
    }

    void ISprite.Draw(SpriteBatch sb, Texture2D txt) {
        sb.DrawString(font, "Credits: ", new Vector2(200, 220), Color.Purple);
        sb.DrawString(font, "Program Made By: Shivam Engineer", new Vector2(200, 250), Color.Purple);
        sb.DrawString(font, "Sprites from: Files Section of Carmen Canvas Page", new Vector2(200, 280), Color.Purple);
    }
}