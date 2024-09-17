using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

public class MovingNonAnimatedSprite : ISprite {

    private int totalFrames;
    private int currentFrame;

    private List<Rectangle> sourceRects;
    private Rectangle destinationRect;

    public MovingNonAnimatedSprite(int x, int y) {
        sourceRects = new List<Rectangle>();
        sourceRects.Add(new Rectangle(200, 120, 30, 35));

        currentFrame = 0;
        totalFrames = sourceRects.Count;

        destinationRect = new Rectangle(x, y, 100, 100);
    }

    void ISprite.Update(int x, int y) {
        currentFrame++;
        if(currentFrame == totalFrames) {
            currentFrame = 0;
        }
        destinationRect.X = x;
        destinationRect.Y = y;
    }

    void ISprite.Draw(SpriteBatch sb, Texture2D txt) {
        sb.Draw(txt, destinationRect, sourceRects[currentFrame], Color.White);
    }
}