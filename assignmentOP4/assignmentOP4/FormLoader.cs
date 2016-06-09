using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class FormLoader<T>
    {
        private List<IElementType> elements;
        public FormLoader(List<IElementType> elements)
        {
            this.elements = elements;
        }

        public GUIElementsFactory Load()
        {
            return new GUIElementsFactory(elements);
        }
    }
}
