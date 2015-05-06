using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValueEngine.Input;
using System.Windows.Forms;

namespace ValueEngine
{
    public class VerticalMenu
    {
        Vector _position = new Vector();
        Input.Input _input;
        List<Button> _buttons = new List<Button>();
        public double Spacing { get; set; }

        public VerticalMenu(double x, double y, Input.Input input)
        {
            _input = input;
            _position = new Vector(x, y, 0);
            Spacing = 50;
        }

        public void AddButton(Button button)
        {
            double _currentY = _position.Y;

            if (_buttons.Count != 0)
            {
                _currentY = _buttons.Last().Position.Y;
                _currentY -= Spacing;
            }
            else
            {
                //It's the first button
                button.OnGainFocus();
            }

            button.Position = new Vector(_position.X, _currentY, 0);
            _buttons.Add(button);
        }

        public void Render(Renderer renderer)
        {
            _buttons.ForEach(x => x.Render(renderer));
        }

    }
}
