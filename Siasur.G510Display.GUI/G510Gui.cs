#region License

// <copyright file="G510Gui.cs" company="Siasur Development">
//     Copyright (c) 2016 Mischa Behrend (Siasur)
// </copyright>

#endregion

using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Siasur.G510Display.Core;

namespace Siasur.G510Display.GUI
{
    public partial class G510Gui : Form
    {
        #region Felder

        private readonly G510Core _core;
        private bool _blockUpdate;
        private string _lastPath;

        #endregion

        #region Konstruktoren

        public G510Gui(G510Core core)
        {
            InitializeComponent();
            _core = core;

            cboFont.DataSource = FontFamily.Families.Where(font => font.IsStyleAvailable(FontStyle.Regular)).Select(font => font.Name).ToList();
            _core.ImageChanged += UpdatePreview;

            numPosX.Maximum = int.MaxValue;
            numPosX.Minimum = int.MinValue;
            numPosY.Maximum = int.MaxValue;
            numPosY.Minimum = int.MinValue;
        }

        #endregion

        #region Öffentliche Methoden

        public void UpdatePreview(object sender, Bitmap image)
        {
            if (sender != _core)
            {
                return;
            }

            picPreview.Image = image;
        }

        #endregion

        #region Methoden

        private void AttachToEvents()
        {
            cboFont.SelectedValueChanged += UpdateScreen;
            numFontSize.ValueChanged += UpdateScreen;
            numPosX.ValueChanged += UpdateScreen;
            numPosY.ValueChanged += UpdateScreen;
            txtText.TextChanged += UpdateScreen;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            bool success = false;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "G510 Image|*.g510";
                fileDialog.InitialDirectory = string.IsNullOrEmpty(_lastPath) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : _lastPath;
                fileDialog.CheckFileExists = true;
                fileDialog.Multiselect = false;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    _lastPath = Path.GetDirectoryName(fileDialog.FileName);
                    success = _core.LoadFromFile(fileDialog.FileName);
                }
            }

            if (!success)
            {
                return;
            }

            _blockUpdate = true;
            G510Data data = _core.G510Data;
            cboFont.SelectedItem = data.FontName;
            numFontSize.Value = data.FontSize;
            numPosX.Value = data.X;
            numPosY.Value = data.Y;
            txtText.Text = data.Text;
            _blockUpdate = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog svDialog = new SaveFileDialog())
            {
                svDialog.Filter = "G510 Image|*.g510";
                svDialog.InitialDirectory = string.IsNullOrEmpty(_lastPath) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : _lastPath;
                svDialog.AddExtension = true;
                svDialog.FileName = "Tastaturtext";

                if (svDialog.ShowDialog() == DialogResult.OK)
                {
                    _lastPath = Path.GetDirectoryName(svDialog.FileName);
                    _core.SaveToFile(svDialog.FileName);
                }
            }
        }

        private void G510Gui_Load(object sender, EventArgs e)
        {
            cboFont.SelectedItem = _core.G510Data.FontName;
            numFontSize.Value = _core.G510Data.FontSize;

            AttachToEvents();

            UpdateScreen(this, EventArgs.Empty);
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (_blockUpdate)
            {
                return;
            }

            G510Data data = _core.G510Data;
            data.FontName = (string)cboFont.SelectedItem;
            data.FontSize = (int)numFontSize.Value;
            data.Text = txtText.Text;
            data.X = (int)numPosX.Value;
            data.Y = (int)numPosY.Value;

            _core.RefreshDisplay();
        }

        #endregion
    }
}
