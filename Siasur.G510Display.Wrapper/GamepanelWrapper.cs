using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siasur.G510Display.Wrapper
{

    public delegate void ButtonPressedEventHandler(object sender, ButtonPressedEventArgs args);

    public class GamepanelWrapper
    {

        public event ButtonPressedEventHandler ButtonPressed;

        protected void OnButtonPressed(ButtonPressedEventArgs args)
        {
            ButtonPressed?.Invoke(this, args);
        }
    }
}
