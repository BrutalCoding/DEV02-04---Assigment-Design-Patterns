using System;
using System.Collections.Generic;
using System.Diagnostics;
using assignmentOP4New.Components;
using assignmentOP4New.Elements;
using assignmentOP4New.Factory;
using assignmentOP4New.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace assignmentOP4New
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private SpriteFont spriteFont;
        private ElementButton myFirstButton;
        private ElementLabel myFirstLabel;
        private GuiElementsFactory ef;
        private GuiElementFactory elementFactory;
        private List<Control> controls;
        private IOption<GuiElementFactory> test1;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            controls = new List<Control>();
            ef = new GuiElementsFactory(controls);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteFont = Content.Load<SpriteFont>("Arial");
            myFirstButton = new ElementButton(Vector2.Zero, spriteFont, "Click me", Content.Load<Texture2D>("dev4-practical-button"));
            myFirstLabel = new ElementLabel(Vector2.Zero, spriteFont, "Im a label");
            controls.Add(myFirstButton);
            controls.Add(myFirstLabel);
            
            
            //elementFactory = new GuiElementFactory(test1);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();



            test1 = ef.GetNext();
            while (test1.Visit(() => false, _ => true))
            {
                GuiElementFactory test = test1.Visit(() => default(GuiElementFactory), x => x);
                test.MakeElement(spriteBatch);
                test1 = ef.GetNext();
            }
            //elementFactory.MakeElement(spriteBatch);
            
            //while (test1.Visit(() => false, _ => true))
            //{
            //    Control test = test1.Visit(() => default(Control), x => x);
            //    test.Draw(spriteBatch);
            //    test1 = ef.GetNext();
            //}
            // TODO: Add your drawing code here
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
