namespace Siasur.G510Display.GUI
{
    partial class G510Gui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.lblSchriftart = new System.Windows.Forms.Label();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.lblSchriftgroesse = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.numPosX = new System.Windows.Forms.NumericUpDown();
            this.numPosY = new System.Windows.Forms.NumericUpDown();
            this.txtText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(160, 43);
            this.picPreview.TabIndex = 2;
            this.picPreview.TabStop = false;
            this.picPreview.Click += new System.EventHandler(this.UpdateScreen);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(92, 61);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Laden";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cboFont
            // 
            this.cboFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(247, 12);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(205, 21);
            this.cboFont.TabIndex = 5;
            // 
            // lblSchriftart
            // 
            this.lblSchriftart.AutoSize = true;
            this.lblSchriftart.Location = new System.Drawing.Point(192, 15);
            this.lblSchriftart.Name = "lblSchriftart";
            this.lblSchriftart.Size = new System.Drawing.Size(49, 13);
            this.lblSchriftart.TabIndex = 6;
            this.lblSchriftart.Text = "Schriftart";
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(247, 38);
            this.numFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(205, 20);
            this.numFontSize.TabIndex = 7;
            this.numFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSchriftgroesse
            // 
            this.lblSchriftgroesse.AutoSize = true;
            this.lblSchriftgroesse.Location = new System.Drawing.Point(177, 40);
            this.lblSchriftgroesse.Name = "lblSchriftgroesse";
            this.lblSchriftgroesse.Size = new System.Drawing.Size(64, 13);
            this.lblSchriftgroesse.TabIndex = 8;
            this.lblSchriftgroesse.Text = "Schriftgröße";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(197, 66);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Position";
            // 
            // numPosX
            // 
            this.numPosX.Location = new System.Drawing.Point(247, 64);
            this.numPosX.Name = "numPosX";
            this.numPosX.Size = new System.Drawing.Size(100, 20);
            this.numPosX.TabIndex = 10;
            this.numPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numPosY
            // 
            this.numPosY.Location = new System.Drawing.Point(352, 64);
            this.numPosY.Name = "numPosY";
            this.numPosY.Size = new System.Drawing.Size(100, 20);
            this.numPosY.TabIndex = 11;
            this.numPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 90);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(440, 110);
            this.txtText.TabIndex = 12;
            // 
            // G510Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 212);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.numPosY);
            this.Controls.Add(this.numPosX);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblSchriftgroesse);
            this.Controls.Add(this.numFontSize);
            this.Controls.Add(this.lblSchriftart);
            this.Controls.Add(this.cboFont);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "G510Gui";
            this.Text = "G510Display";
            this.Load += new System.EventHandler(this.G510Gui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Label lblSchriftart;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.Label lblSchriftgroesse;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.NumericUpDown numPosX;
        private System.Windows.Forms.NumericUpDown numPosY;
        private System.Windows.Forms.TextBox txtText;
    }
}

