using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentOP4New.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace assignmentOP4New.Elements
{
    class ElementLabel : Control
    {
        private Vector2 labelPosition;
        private SpriteFont labelFont;
        private string labelText;

        public ElementLabel(Vector2 pos, SpriteFont font, string text)
        {
            this.labelPosition = pos;
            this.labelFont = font;
            this.labelText = text;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(labelFont, labelText, labelPosition, Color.Black);
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
