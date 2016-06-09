using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class GUIElementsFactoryToGUIElements : IIterator<GUIElement>
    {
        List<IOption<GUIElement>> factory;
        IOption<GUIElementFactory> currentFactory;
        int index = -1;

        public GUIElementsFactoryToGUIElements(GUIElementsFactory ef)
        {
            currentFactory = ef.GetNext();
            factory.Add(currentFactory.Visit<IOption<GUIElement>>(() => new None<GUIElement>(), x => new Some<GUIElement>(x.Load())));
            //.Visit<GUIElement>(new None<GUIElement>(), new Some<GUIElement>();
            //IOption<GUIElement> item
            
        }

        public IOption<GUIElement> GetNext()
        {
            if (index >= factory.Count() - 1)
            {
                Reset();
            }
            index++;
            return factory[index];
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
