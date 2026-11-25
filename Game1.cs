using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Topic_2___Scaling___Text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D circleTexture, rectangleTexture;

        SpriteFont textFont;

        Rectangle circleRect;

        Rectangle leftEye;

        Rectangle rightEye;

        Rectangle mouthRect;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            circleRect = new Rectangle(200, 100, 400, 400);
            leftEye = new Rectangle(300, 220, 60, 60);
            rightEye = new Rectangle(440, 220, 60, 60);
            mouthRect = new Rectangle(320, 390, 140, 50);

           
            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            circleTexture = Content.Load<Texture2D>("circle.png");
            rectangleTexture = Content.Load<Texture2D>("rectangle.png");
            textFont = Content.Load<SpriteFont>("Text Font");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(circleTexture, circleRect, Color.Yellow);

            _spriteBatch.Draw(circleTexture, leftEye, Color.Black);

            _spriteBatch.Draw(circleTexture, rightEye, Color.Black);

            _spriteBatch.Draw(rectangleTexture, mouthRect, Color.Black);

            _spriteBatch.DrawString(textFont, "SMILE", new Vector2(365, 400), Color.White);

            
            
             _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
