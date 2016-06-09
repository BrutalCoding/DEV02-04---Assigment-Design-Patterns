using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class GUIElementFactory
    {
        private ElementType type;

        public GUIElementFactory(ElementType t)
        {
            this.type = t;
        }

        public GUIElement Load()
        {
            return type.Visit((EmptyButton, Label, Action) => new Button(EmptyButton, Label, Action),
                              (position, texture) => new EmptyButton(position, texture),
                              (position, text, font) => new Label(position, text, font));
        }
    }
}
