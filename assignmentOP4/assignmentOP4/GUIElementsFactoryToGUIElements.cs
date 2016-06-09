using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class GUIElementsFactoryToGUIElements
    {
        List<IOption<GUIElement>> factory;

        int index;

        IOption<GUIElementFactory> currentFactory;

        public GUIElementsFactoryToGUIElements(GUIElementsFactoryToGUIElements ef)
        {

        }

        public IOption<GUIElement> GetNext()
        {
            return factory[0];
        }

    }
}
