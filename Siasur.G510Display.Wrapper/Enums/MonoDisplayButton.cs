using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siasur.G510Display.Wrapper.Enums
{
    /// <summary>
    /// Enumeration für die Buttons des Monochromdisplay
    /// </summary>
    public enum MonoDisplayButton
    {

        /// <summary>
        /// Der 1. Button
        /// </summary>
        Button1 = LcdConnector.LOGI_LCD_MONO_BUTTON_0,

        /// <summary>
        /// Der 2. Button
        /// </summary>
        Button2 = LcdConnector.LOGI_LCD_MONO_BUTTON_1,

        /// <summary>
        /// Der 3. Button
        /// </summary>
        Button3 = LcdConnector.LOGI_LCD_MONO_BUTTON_2,

        /// <summary>
        /// Der 4. Button
        /// </summary>
        Button4 = LcdConnector.LOGI_LCD_MONO_BUTTON_3
    }
}
