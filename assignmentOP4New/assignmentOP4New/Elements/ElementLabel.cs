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
    class ElementLabel : IControl
    {
        private SpriteFont labelFont;
        private Vector2 labelPosition;
        private string labelText;

        public ElementLabel()
        {
            this.labelFont = font;
        }

        public SpriteFont font
        {
            get { return labelFont; }
            set { labelFont = value; }
        }

        public Vector2 position
        {
            get {return labelPosition;}
            set { labelPosition = value; }
        }

        public string Text
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
