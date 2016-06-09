using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace assignmentOP4
{
    class Label : GUIElement
    {
        private String text;
        private SpriteFont font;

        public Label(Vector2 p, string t, SpriteFont f) : base(p)
        {
            this.text = t;
            this.font = f;

        }
    }
}
