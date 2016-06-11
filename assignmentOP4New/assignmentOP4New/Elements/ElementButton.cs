using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentOP4New.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace assignmentOP4New.Elements 
{
    class ElementButton : IControl
    {
        private Action btnAction;
        private SpriteFont btnFont;
        private Vector2 btnPos;
        private Texture2D btnTexture;
        private string btnText;

        public ElementButton()
        {
            
        }

        public ElementButton(Action action)
        {
            this.btnAction = action;
        }

        public Texture2D texture
        {
            get { return btnTexture; }
            set { btnTexture = value; }
        }

        public SpriteFont font
        {
            get { return btnFont; }

            set { btnFont = value; }
        }

        public Vector2 position
        {
            get { return btnPos; }

            set { btnPos = value; }
        }

        public string Text
        {
            get { return btnText; }

            set { btnText = value; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(btnTexture, btnPos);
            spriteBatch.DrawString(btnFont, btnText, new Vector2(btnPos.X + 100, btnPos.Y + 30), Color.Black);
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
