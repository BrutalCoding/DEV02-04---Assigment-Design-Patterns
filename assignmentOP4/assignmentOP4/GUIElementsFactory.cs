using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class GUIElementsFactory<T> : Iterator<T>
    {
        private List<ElementType> elements;
        private int index;

        public GUIElementsFactory(List<ElementType> elements)
        {
            this.elements = elements;
        }

        public Option<T> GetNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
