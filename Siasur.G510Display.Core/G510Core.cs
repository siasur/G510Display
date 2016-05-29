#region License

// <copyright file="G510Core.cs" company="Siasur Development">
//     Copyright (c) 2016 Mischa Behrend (Siasur)
// </copyright>

#endregion

using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Siasur.G510Display.Core
{
    public delegate void ImageChangedEventHandler(object sender, Bitmap image);

    public class G510Core
    {
        #region Felder

        /// <summary>
        /// Hält das <see cref="G510Data"/>-Objekt welches zum Zeichnen auf das Display verwendet wird
        /// </summary>
        private G510Data _data;

        #endregion

        #region Konstruktoren

        public G510Core()
        {
            _data = new G510Data
                    {
                        FontName = "Arial",
                        FontSize = 34
                    };
        }

        #endregion

        #region Öffentliche Ereignisse

        public event ImageChangedEventHandler ImageChanged;

        #endregion

        #region Öffentliche Eigenschaften

        /// <summary>
        /// Holt das aktuelle <see cref="G510Data"/>-Objekt
        /// </summary>
        public G510Data G510Data => _data;

        #endregion

        #region Öffentliche Methoden

        /// <summary>
        /// Lädt ein G510 Image vom übergebenen Pfad
        /// </summary>
        /// <param name="path">Der Pfad an dem das G510 Image liegt</param>
        /// <returns><code>true</code> wenn das G510 Image geladen wurde</returns>
        public bool LoadFromFile(string path)
        {
            IFormatter form = new BinaryFormatter();
            using (Stream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (DeflateStream gzipStream = new DeflateStream(fileStream, CompressionMode.Decompress))
                {
                    _data = form.Deserialize(gzipStream) as G510Data;
                    RefreshDisplay();
                }
            }
            return true;
        }

        /// <summary>
        /// Zeichnet das Display der Logitech G510 neu
        /// </summary>
        public void RefreshDisplay()
        {
            Bitmap image = G510Drawer.Draw(_data);
            OnImageChanged(image);
        }

        /// <summary>
        /// Schreibt das aktuelle G510 Image in eine Datei
        /// </summary>
        /// <param name="path">Der Pfad zur Datei in die das G510 Image gespeichert werden soll</param>
        /// <remarks>Wenn die Datei bereits existiert wird sie überschrieben</remarks>
        public void SaveToFile(string path)
        {
            IFormatter form = new BinaryFormatter();
            using (Stream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (DeflateStream gzipStream = new DeflateStream(fileStream, CompressionMode.Compress))
                {
                    form.Serialize(gzipStream, _data);
                }
            }
        }

        #endregion

        #region Methoden

        protected virtual void OnImageChanged(Bitmap bitmap)
        {
            ImageChanged?.Invoke(this, bitmap);
        }

        #endregion
    }
}
