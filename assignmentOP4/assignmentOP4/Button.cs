using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace assignmentOP4
{
    class Button : GUIElement
    {
        EmptyButton button;
        Label label;
        Action action;
        static Vector2 p;

        public Button(EmptyButton button, Label label, Action action) : base(p)
        {
            this.button = button;
            this.label = label;
            this.action = action;
        }
    }
}
