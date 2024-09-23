using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Sprint0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private ISprite characterSprite;
        private ISprite textSprite;
        private List<IController> controllerList;
        private Texture2D characterTexture;
        private SpriteFont font;
        private int spriteMode;
        private int[] spritePos;
        private bool moving;

        private Texture2D blockTexture; // Single block texture
        private List<Rectangle> blockSourceRectangles; // List of source rectangles for blocks
        private StationaryBlock currentBlock; // Current block

        enum PlayerSpriteList { NonMovingNonAnimatedPlayer, NonMovingAnimatedPlayer, MovingNonAnimatedPlayer, MovingAnimatedPlayer };

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(this));
            controllerList.Add(new MouseController(this));
            spritePos = new int[2];
            spritePos[0] = 50;
            spritePos[1] = 50;
            spriteMode = 1;
            moving = false;

            blockSourceRectangles = new List<Rectangle>(); // Initialize block source rectangles list
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            characterSprite = new NonMovingNonAnimatedSprite(spritePos[0], spritePos[1]);
            characterTexture = Content.Load<Texture2D>("mario");
            font = Content.Load<SpriteFont>("File");
            textSprite = new TextSprite(200, 100, font);

            // Load block texture
            blockTexture = Content.Load<Texture2D>("zelda_blocks");

            // Define source rectangles for blocks
            blockSourceRectangles.Add(new Rectangle(0, 300, 32, 32)); // Block 1
            blockSourceRectangles.Add(new Rectangle(64, 100, 32, 32)); // Block 2

            // Initialize the current block with the first source rectangle
            currentBlock = new StationaryBlock(100, 100, blockTexture, blockSourceRectangles[0]);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape) || Keyboard.GetState().IsKeyDown(Keys.D0))
            {
                Exit();
            }

            foreach (IController c in controllerList)
            {
                c.Update();
            }

            if (moving && spritePos[1] < GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2.2)
            {
                spritePos[1]++;
            }
            else if (moving)
            {
                spritePos[1] = -5;
            }

            characterSprite.Update(spritePos[0], spritePos[1]);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            GraphicsDevice.Clear(Color.Cyan);

            characterSprite.Draw(spriteBatch, characterTexture);
            textSprite.Draw(spriteBatch, characterTexture);

            // Draw the current block
            currentBlock.Draw(spriteBatch, blockTexture);

            base.Draw(gameTime);
            spriteBatch.End();
        }

        public void setMode(int mode)
        {
            if (spriteMode != mode)
            {
                spriteMode = mode;
                switch (mode)
                {
                    case 1:
                        characterSprite = new NonMovingNonAnimatedSprite(spritePos[0], spritePos[1]);
                        moving = false;
                        break;
                    case 2:
                        characterSprite = new NonMovingAnimatedSprite(spritePos[0], spritePos[1]);
                        moving = false;
                        break;
                    case 3:
                        characterSprite = new MovingNonAnimatedSprite(spritePos[0], spritePos[1]);
                        moving = true;
                        break;
                    case 4:
                        characterSprite = new MovingAnimatedSprite(spritePos[0], spritePos[1]);
                        moving = true;
                        break;
                }
            }
        }

        public void PreviousBlock()
        {
            if (blockSourceRectangles.Count > 0)
            {
                int currentIndex = blockSourceRectangles.IndexOf(currentBlock.SourceRectangle);
                int previousIndex = (currentIndex - 1 + blockSourceRectangles.Count) % blockSourceRectangles.Count;
                currentBlock.SourceRectangle = blockSourceRectangles[previousIndex];
            }
        }

        public void NextBlock()
        {
            if (blockSourceRectangles.Count > 0)
            {
                int currentIndex = blockSourceRectangles.IndexOf(currentBlock.SourceRectangle);
                int nextIndex = (currentIndex + 1) % blockSourceRectangles.Count;
                currentBlock.SourceRectangle = blockSourceRectangles[nextIndex];
            }
        }
    }
}