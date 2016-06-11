using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace assignmentOP4New.Interfaces
{
    interface IControl
    {
        Vector2 position { get; set; }
        SpriteFont font { get; set; }
        string Text { get; set; }
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch);
    }
}
