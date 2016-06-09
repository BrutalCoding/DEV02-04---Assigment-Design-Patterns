using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace assignmentOP4
{
    class ButtonType : IElementType
    {
        Vector2 position;
        SpriteFont font;
        Texture2D texture;
        string text;
        Action action;

        public ButtonType(Vector2 position, Texture2D texture, string text, SpriteFont font, Action action)
        {
            this.position = position;
            this.font = font;
            this.texture = texture;
            this.text = text;
            this.action = action;
        }

        public GUIElement Visit(Func<EmptyButton, Label, Action, GUIElement> OnButton, Func<Vector2, Texture2D, GUIElement> OnEmptyButton, Func<Vector2, string, SpriteFont, GUIElement> OnLabel)
        {
            return OnButton(new EmptyButton(this.position, this.texture), new Label(this.position, this.text, this.font), this.action);
        }
    }
}
