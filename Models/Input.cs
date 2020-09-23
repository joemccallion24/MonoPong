using System;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;



namespace MyProject.Models
{
    public class Input
    {
        TouchCollection touchCollection;

        public Input() {
            touchCollection = TouchPanel.GetState();

        }
    }
}
