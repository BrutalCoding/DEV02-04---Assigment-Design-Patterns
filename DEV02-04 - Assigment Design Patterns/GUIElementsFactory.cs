using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV02_04___Assigment_Design_Patterns
{
    class GUIElementsFactory
    {
        private List<ElementType> elements;
        private int index;

        public GUIElementsFactory(List<ElementType> elements)
        {
            this.elements = elements;
        }

        public Option<GUIElementFactory> GetNext()
        {
             
        }
    }
}
