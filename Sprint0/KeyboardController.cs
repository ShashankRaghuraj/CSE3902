using Microsoft.Xna.Framework.Input;
using Sprint0;

public class KeyboardController : IController
{
    private Game1 programGame;

    public KeyboardController(Game1 g)
    {
        programGame = g;
    }

    void IController.Update()
    {
        KeyboardState ks = Keyboard.GetState();
        if (ks.IsKeyDown(Keys.D1) || ks.IsKeyDown(Keys.NumPad1))
        {
            programGame.setMode(1);
        }
        if (ks.IsKeyDown(Keys.D2) || ks.IsKeyDown(Keys.NumPad2))
        {
            programGame.setMode(2);
        }
        if (ks.IsKeyDown(Keys.D3) || ks.IsKeyDown(Keys.NumPad3))
        {
            programGame.setMode(3);
        }
        if (ks.IsKeyDown(Keys.D4) || ks.IsKeyDown(Keys.NumPad4))
        {
            programGame.setMode(4);
        }
        if (ks.IsKeyDown(Keys.T))
        {
            programGame.PreviousBlock(); // Switch to previous block
        }
        if (ks.IsKeyDown(Keys.Y))
        {
            programGame.NextBlock(); // Switch to next block
        }
    }
}