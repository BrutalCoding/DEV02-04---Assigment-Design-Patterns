using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentOP4New.Components;
using assignmentOP4New.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace assignmentOP4New.Factory
{
    class GuiElementFactory
    {
        private IOption<Control> elementOption;
        private Control elementControl;
        public GuiElementFactory(IOption<Control> elementOption)
        {
            this.elementOption = elementOption;
            elementControl = elementOption.Visit(() => default(Control), x => x);
        }
        public Control MakeElement(SpriteBatch spriteBatch)
        {
            return elementControl;
        }
    }
}
