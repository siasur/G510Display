#region License

// <copyright file="ColorDisplayButton.cs" company="Siasur Development">
//     Copyright (c) 2016 Mischa Behrend (Siasur)
// </copyright>

#endregion

namespace Siasur.G510Display.Wrapper.Enums
{
    /// <summary>
    /// Enumeration für die Buttons des Farbdisplay
    /// </summary>
    public enum ColorDisplayButton
    {
        /// <summary>
        /// Der <code>Left</code>-Button
        /// </summary>
        Left = LcdConnector.LOGI_LCD_COLOR_BUTTON_LEFT,

        /// <summary>
        /// Der <code>Right</code>-Button
        /// </summary>
        Right = LcdConnector.LOGI_LCD_COLOR_BUTTON_RIGHT,

        /// <summary>
        /// Der <code>Up</code>-Button
        /// </summary>
        Up = LcdConnector.LOGI_LCD_COLOR_BUTTON_UP,

        /// <summary>
        /// Der <code>Down</code>-Button
        /// </summary>
        Down = LcdConnector.LOGI_LCD_COLOR_BUTTON_DOWN,

        /// <summary>
        /// Der <code>Ok</code>-Button
        /// </summary>
        Ok = LcdConnector.LOGI_LCD_COLOR_BUTTON_OK,

        /// <summary>
        /// Der <code>Cancel</code>-Button
        /// </summary>
        Cancel = LcdConnector.LOGI_LCD_COLOR_BUTTON_CANCEL,

        /// <summary>
        /// Der <code>Menu</code>-Button
        /// </summary>
        Menu = LcdConnector.LOGI_LCD_COLOR_BUTTON_MENU
    }
}
