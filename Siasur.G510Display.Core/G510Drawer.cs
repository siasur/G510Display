#region License

// <copyright file="G510Drawer.cs" company="Siasur Development">
//     Copyright (c) 2016 Mischa Behrend (Siasur)
// </copyright>

#endregion

using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using g15wrapper = extendedg15wrapper.extendedg15wrapper;

namespace Siasur.G510Display.Core
{
    public static class G510Drawer
    {
        #region Statische Felder

        private static readonly Bitmap Image;
        private static readonly g15wrapper Wrapper;

        #endregion

        #region Konstruktoren

        static G510Drawer()
        {
            Wrapper = new g15wrapper("G510Display", false);
            Image = new Bitmap(Wrapper.GetBitmapsizeX, Wrapper.GetBitmapsizeY, PixelFormat.Format24bppRgb);
        }

        #endregion

        #region Öffentliche Methoden

        public static Bitmap Draw(G510Data data)
        {
            using (Graphics G = Graphics.FromImage(Image))
            {
                G.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

                G.FillRectangle(data.Invert ? Brushes.White : Brushes.Black, 0, 0, Wrapper.GetBitmapsizeX, Wrapper.GetBitmapsizeY);
                using (Font font = new Font(data.FontName, data.FontSize))
                {
                    G.DrawString(data.Text, font, data.Invert ? Brushes.Black : Brushes.White, data.Location);
                }
            }

            Wrapper.SetBitmap(Image);
            return Image;
        }

        #endregion
    }
}
