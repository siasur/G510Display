#region License

// <copyright file="LcdConnector.cs" company="Siasur Development">
//     Copyright (c) 2016 Mischa Behrend (Siasur)
// </copyright>

#endregion

using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace Siasur.G510Display.Wrapper
{
    public class LcdConnector
    {
        #region Konstanten

        public const int LOGI_LCD_COLOR_BUTTON_CANCEL = 0x00000800;
        public const int LOGI_LCD_COLOR_BUTTON_DOWN = 0x00002000;
        public const int LOGI_LCD_COLOR_BUTTON_LEFT = 0x00000100;
        public const int LOGI_LCD_COLOR_BUTTON_MENU = 0x00004000;
        public const int LOGI_LCD_COLOR_BUTTON_OK = 0x00000400;
        public const int LOGI_LCD_COLOR_BUTTON_RIGHT = 0x00000200;
        public const int LOGI_LCD_COLOR_BUTTON_UP = 0x00001000;

        public const int LOGI_LCD_COLOR_HEIGHT = 240;
        public const int LOGI_LCD_COLOR_WIDTH = 320;

        public const int LOGI_LCD_MONO_BUTTON_0 = 0x00000001;
        public const int LOGI_LCD_MONO_BUTTON_1 = 0x00000002;
        public const int LOGI_LCD_MONO_BUTTON_2 = 0x00000004;
        public const int LOGI_LCD_MONO_BUTTON_3 = 0x00000008;

        public const int LOGI_LCD_MONO_HEIGHT = 43;
        public const int LOGI_LCD_MONO_WIDTH = 160;

        public const int LOGI_LCD_TYPE_COLOR = 0x00000002;
        public const int LOGI_LCD_TYPE_MONO = 0x00000001;

        #endregion

        #region Öffentliche Methoden

        /// <summary>
        /// This function sets the specified image as a background on the connected color lcd device.
        /// </summary>
        /// <param name="colorBitmap">the array of pixels that define the actual color bitmap</param>
        /// <returns>true, if succeeds</returns>
        /// <remarks>The image MUST be 320x240</remarks>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LogiLcdColorSetBackground(byte[] colorBitmap);

        /// <summary>
        /// This function sets the specified text in the requested line on the connected color lcd device
        /// </summary>
        /// <param name="lineNumber">the line on the screen you want the text to appear. (0-3)</param>
        /// <param name="text">the text you want to display</param>
        /// <param name="red">the color value for red (default: 255)</param>
        /// <param name="green">the color value for green (default: 255)</param>
        /// <param name="blue">the color value for blue (default: 255)</param>
        /// <returns>true, if succeeds</returns>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LogiLcdColorSetText(int lineNumber, String text, int red, int green, int blue);

        /// <summary>
        /// This function sets the specified text in a bigger font size on the first line of the connected color lcd device.
        /// </summary>
        /// <param name="text">the text you want to display</param>
        /// <param name="red">the color value for red (default: 255)</param>
        /// <param name="green">the color value for green (default: 255)</param>
        /// <param name="blue">the color value for blue (default: 255)</param>
        /// <returns>true, if succeeds</returns>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LogiLcdColorSetTitle(String text, int red, int green, int blue);

        /// <summary>
        /// This function function makes necessary initializations. 
        /// </summary>
        /// <param name="friendlyName">The name of your applet</param>
        /// <param name="lcdType">defines the Type of your lcd target</param>
        /// <returns><code>true</code>, if the function succeeds</returns>
        /// <remarks>You must call this function prior to any other function in the library.</remarks>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LogiLcdInit(String friendlyName, int lcdType);

        /// <summary>
        /// This function checks if a specified button is pressed.
        /// </summary>
        /// <param name="button">the button that should be checked</param>
        /// <returns>true, if the specified button is pressed</returns>
        /// <remarks>this function will only return true, if your applet is the active one</remarks>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LogiLcdIsButtonPressed(int button);

        /// <summary>
        /// This function checks if a device of the specified type is connected.
        /// </summary>
        /// <param name="lcdType">the lcd type to look for</param>
        /// <returns>true, if a device supporting the specified lcd type is found</returns>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LogiLcdIsConnected(int lcdType);

        /// <summary>
        /// This function sets the specified image as a background on the connected monochrome lcd device.
        /// </summary>
        /// <param name="monoBitmap">the array of pixels that define the actual monochrome bitmap</param>
        /// <returns>true, if succeeds</returns>
        /// <remarks>
        /// The image size MUST be 160x34!
        /// A pixel is counted as "on" if the assigned value ist <code>&gt;=</code> 128.
        /// </remarks>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LogiLcdMonoSetBackground(byte[] monoBitmap);

        /// <summary>
        /// This function sets the specified text in the requested line on the connected monochrome lcd device
        /// </summary>
        /// <param name="lineNumber">the line on the screen you want the text to appear. (0-3)</param>
        /// <param name="text">the text you want to display</param>
        /// <returns>true, if succeeds</returns>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LogiLcdMonoSetText(int lineNumber, String text);

        /// <summary>
        /// This function kills the applet and frees memory used by the SDK
        /// </summary>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LogiLcdShutdown();

        /// <summary>
        /// This function updates the lcd display.
        /// </summary>
        /// <remarks>
        /// You have to call this function in a loop to keep the lcd updated.
        /// </remarks>
        [DllImport("LogitechLcdEnginesWrapper ", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LogiLcdUpdate();

        #endregion
    }
}
