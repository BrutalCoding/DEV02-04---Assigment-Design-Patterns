using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignmentOP4
{
    class EmptyButton : GUIElement
    {
        private Texture2D texture;
        private Vector2 scale;
        private Boolean is_clicked;
        private Boolean waiting_for_up;
        private float count_down;
        private float max_count_down;

        public EmptyButton(Vector2 p, Texture2D t) : base(p)
        {
            this.scale = p;
            this.texture = t;
        }
    }
}
