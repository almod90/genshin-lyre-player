using GenshinLyrePlayer.Controls;

namespace GenshinLyrePlayer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiHeader = new System.Windows.Forms.Panel();
            this.uiReadyText = new GenshinLyrePlayer.Controls.ShadowLabel();
            this.uiReady = new GenshinLyrePlayer.Controls.ShadowLabel();
            this.uiClose = new GenshinLyrePlayer.Controls.ShadowLabel();
            this.uiOptions = new GenshinLyrePlayer.Controls.ShadowLabel();
            this.uiLoadMidi = new GenshinLyrePlayer.Controls.ShadowLabel();
            this.uiFooter = new System.Windows.Forms.Panel();
            this.uiStatusValue = new GenshinLyrePlayer.Controls.ShadowLabel();
            this.uiStatusText = new GenshinLyrePlayer.Controls.ShadowLabel();
            this.uiHeader.SuspendLayout();
            this.uiFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiHeader
            // 
            this.uiHeader.Controls.Add(this.uiReadyText);
            this.uiHeader.Controls.Add(this.uiReady);
            this.uiHeader.Controls.Add(this.uiClose);
            this.uiHeader.Controls.Add(this.uiOptions);
            this.uiHeader.Controls.Add(this.uiLoadMidi);
            this.uiHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiHeader.Location = new System.Drawing.Point(0, 0);
            this.uiHeader.Name = "uiHeader";
            this.uiHeader.Size = new System.Drawing.Size(320, 72);
            this.uiHeader.TabIndex = 3;
            this.uiHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Helper_MouseDown);
            // 
            // uiReadyText
            // 
            this.uiReadyText.BackColor = System.Drawing.Color.Transparent;
            this.uiReadyText.Font = new System.Drawing.Font("Motorwerk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.uiReadyText.ForeColor = System.Drawing.Color.White;
            this.uiReadyText.Location = new System.Drawing.Point(32, 42);
            this.uiReadyText.Name = "uiReadyText";
            this.uiReadyText.ShadowColor = System.Drawing.Color.Black;
            this.uiReadyText.ShadowMargin = new System.Drawing.Point(1, 1);
            this.uiReadyText.Size = new System.Drawing.Size(276, 23);
            this.uiReadyText.TabIndex = 3;
            this.uiReadyText.Text = "Midi Not Loaded";
            this.uiReadyText.UseCompatibleTextRendering = true;
            this.uiReadyText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Helper_MouseDown);
            // 
            // uiReady
            // 
            this.uiReady.AutoSize = true;
            this.uiReady.BackColor = System.Drawing.Color.Transparent;
            this.uiReady.Font = new System.Drawing.Font("Motorwerk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.uiReady.ForeColor = System.Drawing.Color.Red;
            this.uiReady.Location = new System.Drawing.Point(12, 41);
            this.uiReady.Name = "uiReady";
            this.uiReady.ShadowColor = System.Drawing.Color.Black;
            this.uiReady.ShadowMargin = new System.Drawing.Point(1, 1);
            this.uiReady.Size = new System.Drawing.Size(14, 23);
            this.uiReady.TabIndex = 4;
            this.uiReady.Text = "X";
            this.uiReady.UseCompatibleTextRendering = true;
            // 
            // uiClose
            // 
            this.uiClose.AutoSize = true;
            this.uiClose.BackColor = System.Drawing.Color.Transparent;
            this.uiClose.Font = new System.Drawing.Font("Motorwerk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.uiClose.ForeColor = System.Drawing.Color.White;
            this.uiClose.Location = new System.Drawing.Point(272, 9);
            this.uiClose.Name = "uiClose";
            this.uiClose.ShadowColor = System.Drawing.Color.Black;
            this.uiClose.ShadowMargin = new System.Drawing.Point(1, 1);
            this.uiClose.Size = new System.Drawing.Size(36, 23);
            this.uiClose.TabIndex = 5;
            this.uiClose.Text = "[ X ]";
            this.uiClose.UseCompatibleTextRendering = true;
            this.uiClose.Click += new System.EventHandler(this.uiClose_Click);
            // 
            // uiOptions
            // 
            this.uiOptions.AutoSize = true;
            this.uiOptions.BackColor = System.Drawing.Color.Transparent;
            this.uiOptions.Font = new System.Drawing.Font("Motorwerk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.uiOptions.ForeColor = System.Drawing.Color.White;
            this.uiOptions.Location = new System.Drawing.Point(119, 9);
            this.uiOptions.Name = "uiOptions";
            this.uiOptions.ShadowColor = System.Drawing.Color.Black;
            this.uiOptions.ShadowMargin = new System.Drawing.Point(1, 1);
            this.uiOptions.Size = new System.Drawing.Size(84, 23);
            this.uiOptions.TabIndex = 6;
            this.uiOptions.Text = "[ Options ]";
            this.uiOptions.UseCompatibleTextRendering = true;
            this.uiOptions.Click += new System.EventHandler(this.uiOptions_Click);
            // 
            // uiLoadMidi
            // 
            this.uiLoadMidi.AutoSize = true;
            this.uiLoadMidi.BackColor = System.Drawing.Color.Transparent;
            this.uiLoadMidi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiLoadMidi.Font = new System.Drawing.Font("Motorwerk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.uiLoadMidi.ForeColor = System.Drawing.Color.White;
            this.uiLoadMidi.Location = new System.Drawing.Point(12, 9);
            this.uiLoadMidi.Name = "uiLoadMidi";
            this.uiLoadMidi.ShadowColor = System.Drawing.Color.Black;
            this.uiLoadMidi.ShadowMargin = new System.Drawing.Point(1, 1);
            this.uiLoadMidi.Size = new System.Drawing.Size(101, 23);
            this.uiLoadMidi.TabIndex = 7;
            this.uiLoadMidi.Text = "[ Load MIDI ]";
            this.uiLoadMidi.UseCompatibleTextRendering = true;
            this.uiLoadMidi.Click += new System.EventHandler(this.uiLoadMidi_Click);
            // 
            // uiFooter
            // 
            this.uiFooter.Controls.Add(this.uiStatusValue);
            this.uiFooter.Controls.Add(this.uiStatusText);
            this.uiFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiFooter.Location = new System.Drawing.Point(0, 473);
            this.uiFooter.Name = "uiFooter";
            this.uiFooter.Size = new System.Drawing.Size(320, 39);
            this.uiFooter.TabIndex = 4;
            // 
            // uiStatusValue
            // 
            this.uiStatusValue.AutoSize = true;
            this.uiStatusValue.BackColor = System.Drawing.Color.Transparent;
            this.uiStatusValue.Font = new System.Drawing.Font("Motorwerk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.uiStatusValue.ForeColor = System.Drawing.Color.White;
            this.uiStatusValue.Location = new System.Drawing.Point(77, 9);
            this.uiStatusValue.Name = "uiStatusValue";
            this.uiStatusValue.ShadowColor = System.Drawing.Color.Black;
            this.uiStatusValue.ShadowMargin = new System.Drawing.Point(1, 1);
            this.uiStatusValue.Size = new System.Drawing.Size(140, 23);
            this.uiStatusValue.TabIndex = 3;
            this.uiStatusValue.Text = "Waiting for input";
            this.uiStatusValue.UseCompatibleTextRendering = true;
            // 
            // uiStatusText
            // 
            this.uiStatusText.AutoSize = true;
            this.uiStatusText.BackColor = System.Drawing.Color.Transparent;
            this.uiStatusText.Font = new System.Drawing.Font("Motorwerk", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.uiStatusText.ForeColor = System.Drawing.Color.White;
            this.uiStatusText.Location = new System.Drawing.Point(12, 9);
            this.uiStatusText.Name = "uiStatusText";
            this.uiStatusText.ShadowColor = System.Drawing.Color.Black;
            this.uiStatusText.ShadowMargin = new System.Drawing.Point(1, 1);
            this.uiStatusText.Size = new System.Drawing.Size(59, 23);
            this.uiStatusText.TabIndex = 3;
            this.uiStatusText.Text = "Status:";
            this.uiStatusText.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::GenshinLyrePlayer.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 512);
            this.Controls.Add(this.uiFooter);
            this.Controls.Add(this.uiHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genshin Lyre Player";
            this.uiHeader.ResumeLayout(false);
            this.uiHeader.PerformLayout();
            this.uiFooter.ResumeLayout(false);
            this.uiFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uiHeader;
        private ShadowLabel uiReadyText;
        private ShadowLabel uiReady;
        private ShadowLabel uiClose;
        private ShadowLabel uiOptions;
        private ShadowLabel uiLoadMidi;
        private System.Windows.Forms.Panel uiFooter;
        private ShadowLabel uiStatusValue;
        private ShadowLabel uiStatusText;
    }
}