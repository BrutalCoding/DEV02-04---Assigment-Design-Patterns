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
        private List<Control> newControls;
        private IOption<GuiElementFactory> optionElementFactory;
        private GameTime gameTime;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            controls = new List<Control>();
            newControls = new List<Control>();
            ef = new GuiElementsFactory(controls);
            this.IsMouseVisible = true;
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

            // TODO: use this.Content to load your game content here
            spriteFont = Content.Load<SpriteFont>("Arial");
            myFirstButton = new ElementButton(new Vector2(graphics.PreferredBackBufferWidth / 4, graphics.PreferredBackBufferHeight / 4), spriteFont, "Click me", Content.Load<Texture2D>("dev4-practical-button"));
            myFirstLabel = new ElementLabel(new Vector2(graphics.PreferredBackBufferWidth / 4, graphics.PreferredBackBufferHeight / 2), spriteFont, "Click the button to animate it.");
            controls.Add(myFirstButton);
            controls.Add(myFirstLabel);
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
            doDraw(true);
            foreach (Control c in newControls)
            {
                c.Update(gameTime);
            }
            this.gameTime = gameTime;
            base.Update(gameTime);
        }

        private void doDraw(bool drawNow)
        {
            newControls.Clear();
            optionElementFactory = ef.GetNext();
            while (optionElementFactory.Visit(() => false, _ => true))
            {
                elementFactory = optionElementFactory.Visit(() => default(GuiElementFactory), x => x);
                newControls.Add(elementFactory.MakeElement(spriteBatch));
                optionElementFactory = ef.GetNext();
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            // TODO: Add your drawing code here
            foreach (Control c in newControls)
            {
                c.Draw(spriteBatch);
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
