using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV02_04___Assigment_Design_Patterns
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

        }
    }
}
