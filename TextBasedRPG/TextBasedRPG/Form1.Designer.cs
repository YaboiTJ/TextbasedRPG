﻿namespace TextBasedRPG
{
    partial class formTitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTitleScreen));
            this.TitleScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TitleScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleScreen
            // 
            this.TitleScreen.BackColor = System.Drawing.Color.White;
            this.TitleScreen.Image = global::TextBasedRPG.Properties.Resources.TitleScreen;
            this.TitleScreen.Location = new System.Drawing.Point(12, 12);
            this.TitleScreen.Name = "TitleScreen";
            this.TitleScreen.Size = new System.Drawing.Size(776, 426);
            this.TitleScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleScreen.TabIndex = 0;
            this.TitleScreen.TabStop = false;
            this.TitleScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TitleScreen_MouseClick);
            // 
            // formTitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TitleScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formTitleScreen";
            this.Text = "Text Based RPG Title";
            ((System.ComponentModel.ISupportInitialize)(this.TitleScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TitleScreen;
    }
}

