#region License

// <copyright file="G510Data.cs" company="Siasur Development">
//     Copyright (c) 2016 Mischa Behrend (Siasur)
// </copyright>

#endregion

using System;
using System.Drawing;
using System.Linq;

namespace Siasur.G510Display.Core
{
    [Serializable]
    public class G510Data
    {
        #region Felder

        private string _fontName;
        private int _fontSize;
        private bool _invert;
        private Point _location;
        private string _textData;

        #endregion

        #region Öffentliche Eigenschaften

        public string FontName
        {
            get
            {
                return _fontName;
            }
            set
            {
                if (FontFamily.Families.All(font => font.Name != value))
                {
                    if (string.IsNullOrEmpty(_fontName))
                    {
                        // Um Exceptions beim zeichnen zu vermeiden muss unbedingt eine Schriftart gesetzt werden!
                        _fontName = FontFamily.Families.FirstOrDefault()?.Name;
                    }

                    return;

                    //throw new ArgumentOutOfRangeException(nameof(value), "Das System unterstützt die übergebene Schriftart nicht");
                }

                _fontName = value;
            }
        }

        public int FontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;
            }
        }

        public bool Invert
        {
            get
            {
                return _invert;
            }
            set
            {
                _invert = value;
            }
        }

        public Point Location => _location;

        public string Text
        {
            get
            {
                return _textData;
            }
            set
            {
                _textData = value;
            }
        }

        public int X
        {
            get
            {
                return _location.X;
            }
            set
            {
                _location.X = value;
            }
        }

        public int Y
        {
            get
            {
                return _location.Y;
            }
            set
            {
                _location.Y = value;
            }
        }

        #endregion
    }
}
