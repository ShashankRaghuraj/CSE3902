using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Sprint0 {
    public class Game1 : Game {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private ISprite characterSprite;
        private ISprite textSprite;
        private List<IController> controllerList;
        private Texture2D characterTexture;
        private SpriteFont font;
        private int spriteMode;
        //Hi this works?
        private int[] spritePos;
        private bool moving;

        enum PlayerSpriteList { NonMovingNonAnimatedPlayer, NonMovingAnimatedPlayer, MovingNonAnimatedPlayer, MovingAnimatedPlayer };

        public Game1(){
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
        }

        protected override void Initialize(){
            base.Initialize();
        }

        protected override void LoadContent(){
            spriteBatch = new SpriteBatch(GraphicsDevice);
            characterSprite = new NonMovingNonAnimatedSprite(spritePos[0], spritePos[1]);
            characterTexture = Content.Load<Texture2D>("mario");
            font = Content.Load<SpriteFont>("File");
            textSprite = new TextSprite(200, 100, font);
        }

        protected override void Update(GameTime gameTime){
            if (Keyboard.GetState().IsKeyDown(Keys.Escape) || Keyboard.GetState().IsKeyDown(Keys.D0)) {
                Exit();
            }

            foreach(IController c in controllerList) {
                c.Update();
            }

            if (moving && spritePos[1] < GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2.2) {
                spritePos[1]++;
            } else if (moving) {
                spritePos[1] = -5;
            }

            characterSprite.Update(spritePos[0], spritePos[1]);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime){
            spriteBatch.Begin();
            GraphicsDevice.Clear(Color.Cyan);

            characterSprite.Draw(spriteBatch, characterTexture);
            textSprite.Draw(spriteBatch, characterTexture);

            base.Draw(gameTime);
            spriteBatch.End();
        }

        public void setMode(int mode) {
            if(spriteMode != mode) {
                spriteMode = mode;
                switch (mode) {
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
    }
}