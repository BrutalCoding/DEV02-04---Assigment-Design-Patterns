using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class GUIElementsFactory : IIterator<GUIElementFactory>
    {
        private List<IElementType> elements = new List<IElementType>();
        private int index = -1;

        public GUIElementsFactory(List<IElementType> elements)
        {
            this.elements = elements;
        }

        public IOption<GUIElementFactory> GetNext()
        {
            if(index >= elements.Count() - 1)
            {
                return new None<GUIElementFactory>();
            }
            index++;
            return new Some<GUIElementFactory>(new GUIElementFactory(elements[index]));
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
