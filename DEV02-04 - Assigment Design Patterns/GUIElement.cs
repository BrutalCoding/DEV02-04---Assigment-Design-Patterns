using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace DEV02_04___Assigment_Design_Patterns
{
    class GUIElement : Component
    {
        private Vector2 position;

        public GUIElement(Vector2 p)
        {
            this.position = p;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            throw new NotImplementedException();
        }

        public void Update(float dt)
        {
            throw new NotImplementedException();
        }
    }
}
