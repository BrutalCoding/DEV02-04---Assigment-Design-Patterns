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
        private Control test;
        public GuiElementFactory(IOption<Control> elementOption)
        {
            this.elementOption = elementOption;
        }

        private void Visit()
        {
            test = elementOption.Visit(() => default(Control), x => x);
        }

        public void MakeElement(SpriteBatch spriteBatch)
        {
            Visit();
            test.Draw(spriteBatch);
        }

        public void DoUpdate(GameTime gameTime)
        {
            Visit();
            test.Update(gameTime);
        }

        //public void DoUpdate(GameTime gameTime)
        //{
        //    if (elementOption.Visit(() => false, _ => true))
        //    {
        //        Control test = elementOption.Visit(() => default(Control), x => x);
        //        test.Update(gameTime);
        //    }
        //}
    }
}
