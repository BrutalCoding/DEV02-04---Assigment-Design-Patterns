using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentOP4New.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace assignmentOP4New.Elements 
{
    class ElementButton : Control
    {
        private Action btnAction;
        private Texture2D btnTexture;

        private Vector2 btnPos;
        private SpriteFont btnFont;
        private string btnText;
        private MouseState msMouseState;
        private int amountClicked;
        public ElementButton(Vector2 pos, SpriteFont font, string text, Texture2D texture)
        {
            this.btnPos = pos;
            this.btnFont = font;
            this.btnText = text;
            this.btnTexture = texture;
        }

        public ElementButton(Vector2 pos, SpriteFont font, string text, Texture2D texture, Action action)
        {
            this.btnPos = pos;
            this.btnFont = font;
            this.btnText = text;
            this.btnTexture = texture;
            this.btnAction = action;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(btnTexture, btnPos);
            spriteBatch.DrawString(btnFont, btnText, new Vector2(btnPos.X + 100, btnPos.Y + 30), Color.Black);
        }

        
        public override void Update(GameTime gameTime) //, int textureWidth, int textureHeight
        {
            MouseState lastMouseState = msMouseState;
            msMouseState = Mouse.GetState();
           
            if (msMouseState.X < btnPos.X + btnTexture.Width && 
                msMouseState.X > btnPos.X && 
                msMouseState.Y < btnPos.Y + btnTexture.Height && 
                msMouseState.Y > btnPos.Y)
            {
                if (lastMouseState.LeftButton == ButtonState.Released && msMouseState.LeftButton == ButtonState.Pressed)
                {
                    amountClicked++;
                    if (amountClicked <= 3)
                    {
                        this.btnPos.X += 50;
                    }
                    else
                    {
                        this.btnPos.X -= 50;
                        if (amountClicked >= 6)
                        {
                            amountClicked = 0;
                        }
                    }
                        
                }
            }
        }
    }
}
