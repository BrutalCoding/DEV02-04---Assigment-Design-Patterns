using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentOP4New.Interfaces;
using assignmentOP4New.Components;
using assignmentOP4New.Factory;
using Microsoft.Xna.Framework.Graphics;

namespace assignmentOP4New.Elements
{
    class GuiElementsFactory : IIterator<GuiElementFactory>
    {
        private List<Control> elementList;
        private int index = -1;
        public GuiElementsFactory(List<Control> listControl)
        {
            elementList = listControl;
        }
        
        public IOption<GuiElementFactory> GetNext()
        {
            index++;
            if (index <= elementList.Count() -1)
            {
                return new Some<GuiElementFactory>(new GuiElementFactory(new Some<Control>(elementList[index])));
            }
            else
            {
                Reset();
                return new None<GuiElementFactory>();
            }
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
