using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignmentOP4
{
    interface IComponent
    {
        void Update(float dt);

        void Draw(SpriteBatch spritebatch);
    }
}
