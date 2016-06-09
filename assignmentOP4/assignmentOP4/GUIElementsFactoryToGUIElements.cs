using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOP4
{
    class GUIElementsFactoryToGUIElements
    {
        List<Option<GUIElement>> factory;

        int index;

        Option<GUIElementFactory> currentFactory;

        public GUIElementsFactoryToGUIElements(GUIElementsFactoryToGUIElements ef)
        {

        }

        public Option<GUIElement> GetNext()
        {
            return factory[0];
        }

    }
}
