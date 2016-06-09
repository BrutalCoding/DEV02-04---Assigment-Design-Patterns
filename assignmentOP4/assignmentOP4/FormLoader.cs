using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class FormLoader<T>
    {
        private List<ElementType> elements;
        public FormLoader(List<ElementType> elements)
        {
            this.elements = elements;
        }

        public GUIElementsFactory<T> Load()
        {
            return new GUIElementsFactory<T>(elements);
        }
    }
}
