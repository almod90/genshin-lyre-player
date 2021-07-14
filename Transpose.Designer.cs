namespace GenshinLyrePlayer
{
    partial class Transpose
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
            this.uiTransposeOK = new System.Windows.Forms.Button();
            this.uiTransposeCancel = new System.Windows.Forms.Button();
            this.uiTransposeSemitones = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.uiTransposeSemitonesValue = new System.Windows.Forms.Label();
            this.uiTransposeReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiTransposeSemitones)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTransposeOK
            // 
            this.uiTransposeOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uiTransposeOK.Location = new System.Drawing.Point(15, 73);
            this.uiTransposeOK.Name = "uiTransposeOK";
            this.uiTransposeOK.Size = new System.Drawing.Size(75, 23);
            this.uiTransposeOK.TabIndex = 1;
            this.uiTransposeOK.Text = "Yes, please";
            this.uiTransposeOK.UseVisualStyleBackColor = true;
            // 
            // uiTransposeCancel
            // 
            this.uiTransposeCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiTransposeCancel.Location = new System.Drawing.Point(225, 73);
            this.uiTransposeCancel.Name = "uiTransposeCancel";
            this.uiTransposeCancel.Size = new System.Drawing.Size(75, 23);
            this.uiTransposeCancel.TabIndex = 2;
            this.uiTransposeCancel.Text = "No, thanks";
            this.uiTransposeCancel.UseVisualStyleBackColor = true;
            // 
            // uiTransposeSemitones
            // 
            this.uiTransposeSemitones.LargeChange = 4;
            this.uiTransposeSemitones.Location = new System.Drawing.Point(12, 25);
            this.uiTransposeSemitones.Maximum = 24;
            this.uiTransposeSemitones.Minimum = -24;
            this.uiTransposeSemitones.Name = "uiTransposeSemitones";
            this.uiTransposeSemitones.Size = new System.Drawing.Size(288, 45);
            this.uiTransposeSemitones.TabIndex = 0;
            this.uiTransposeSemitones.ValueChanged += new System.EventHandler(this.uiTransposeSemitones_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you want to transpose MIDI file?";
            // 
            // uiTransposeSemitonesValue
            // 
            this.uiTransposeSemitonesValue.Location = new System.Drawing.Point(12, 56);
            this.uiTransposeSemitonesValue.Name = "uiTransposeSemitonesValue";
            this.uiTransposeSemitonesValue.Size = new System.Drawing.Size(288, 14);
            this.uiTransposeSemitonesValue.TabIndex = 4;
            this.uiTransposeSemitonesValue.Text = "0 semitones";
            this.uiTransposeSemitonesValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiTransposeReset
            // 
            this.uiTransposeReset.Location = new System.Drawing.Point(122, 73);
            this.uiTransposeReset.Name = "uiTransposeReset";
            this.uiTransposeReset.Size = new System.Drawing.Size(75, 23);
            this.uiTransposeReset.TabIndex = 5;
            this.uiTransposeReset.Text = "Reset";
            this.uiTransposeReset.UseVisualStyleBackColor = true;
            this.uiTransposeReset.Click += new System.EventHandler(this.uiTransposeReset_Click);
            // 
            // Transpose
            // 
            this.AcceptButton = this.uiTransposeOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uiTransposeCancel;
            this.ClientSize = new System.Drawing.Size(312, 107);
            this.Controls.Add(this.uiTransposeReset);
            this.Controls.Add(this.uiTransposeSemitonesValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiTransposeSemitones);
            this.Controls.Add(this.uiTransposeCancel);
            this.Controls.Add(this.uiTransposeOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transpose";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transpose";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.uiTransposeSemitones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiTransposeOK;
        private System.Windows.Forms.Button uiTransposeCancel;
        private System.Windows.Forms.TrackBar uiTransposeSemitones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uiTransposeSemitonesValue;
        private System.Windows.Forms.Button uiTransposeReset;
    }
}