using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentOP4New.Interfaces;
using assignmentOP4New.Components;
using Microsoft.Xna.Framework.Graphics;

namespace assignmentOP4New.Elements
{
    class ElementFactory : IIterator<Control>
    {
        private List<Control> elementList = new List<Control>();
        private int index = -1;
        public ElementFactory(List<Control> listControl)
        {
            elementList = listControl;
        }
        
        public IOption<Control> GetNext()
        {
            index++;
            if (index <= elementList.Count() -1)
            {
                return new Some<Control>(elementList[index]);
            }
            else
            {
                Reset();
                return new None<Control>();
            }
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
