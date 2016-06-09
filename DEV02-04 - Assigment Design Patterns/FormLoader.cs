using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV02_04___Assigment_Design_Patterns
{
    class FormLoader
    {
        private List<ElementType> elements;
        public FormLoader(List<ElementType> elements)
        {
            this.elements = elements;
        }

        public GUIElementsFactory Load()
        {

        }
    }
}
