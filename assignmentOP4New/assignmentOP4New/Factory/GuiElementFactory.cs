using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentOP4New.Components;
using assignmentOP4New.Interfaces;
using Microsoft.Xna.Framework.Graphics;

namespace assignmentOP4New.Factory
{
    class GuiElementFactory
    {
        private IOption<Control> elementOption;

        public GuiElementFactory(IOption<Control> elementOption)
        {
            this.elementOption = elementOption;
        }

        public void MakeElement(SpriteBatch spriteBatch)
        {
            if (elementOption.Visit(() => false, _ => true))
            {
                Control test = elementOption.Visit(() => default(Control), x => x);
                test.Draw(spriteBatch);
            }
        } 
    }
}
