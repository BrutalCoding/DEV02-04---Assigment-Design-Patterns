using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class Button : GUIElement
    {
        EmptyButton button;
        Label label;
        Action action;

        public Button(EmptyButton button, Label label, Action action)
        {
            this.button = button;
            this.label = label;
            this.action = action;
        }
    }
}
