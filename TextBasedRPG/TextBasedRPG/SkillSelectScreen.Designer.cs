namespace TextBasedRPG
{
    partial class SkillSelectScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillSelectScreen));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skillingButton = new System.Windows.Forms.Button();
            this.combatButton = new System.Windows.Forms.Button();
            this.zoneButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.tavernButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(592, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory";
            // 
            // skillingButton
            // 
            this.skillingButton.Location = new System.Drawing.Point(12, 12);
            this.skillingButton.Name = "skillingButton";
            this.skillingButton.Size = new System.Drawing.Size(75, 23);
            this.skillingButton.TabIndex = 2;
            this.skillingButton.Text = "Skilling";
            this.skillingButton.UseVisualStyleBackColor = true;
            this.skillingButton.Click += new System.EventHandler(this.skillingButton_Click);
            // 
            // combatButton
            // 
            this.combatButton.Location = new System.Drawing.Point(12, 41);
            this.combatButton.Name = "combatButton";
            this.combatButton.Size = new System.Drawing.Size(75, 23);
            this.combatButton.TabIndex = 3;
            this.combatButton.Text = "Combat";
            this.combatButton.UseVisualStyleBackColor = true;
            this.combatButton.Click += new System.EventHandler(this.combatButton_Click);
            // 
            // zoneButton
            // 
            this.zoneButton.Location = new System.Drawing.Point(12, 70);
            this.zoneButton.Name = "zoneButton";
            this.zoneButton.Size = new System.Drawing.Size(75, 23);
            this.zoneButton.TabIndex = 4;
            this.zoneButton.Text = "Zone Select";
            this.zoneButton.UseVisualStyleBackColor = true;
            this.zoneButton.Click += new System.EventHandler(this.zoneButton_Click);
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(12, 99);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(75, 23);
            this.shopButton.TabIndex = 5;
            this.shopButton.Text = "Shop";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // tavernButton
            // 
            this.tavernButton.Location = new System.Drawing.Point(12, 128);
            this.tavernButton.Name = "tavernButton";
            this.tavernButton.Size = new System.Drawing.Size(75, 23);
            this.tavernButton.TabIndex = 6;
            this.tavernButton.Text = "Tavern";
            this.tavernButton.UseVisualStyleBackColor = true;
            this.tavernButton.Click += new System.EventHandler(this.tavernButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 426);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SkillSelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tavernButton);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.zoneButton);
            this.Controls.Add(this.combatButton);
            this.Controls.Add(this.skillingButton);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkillSelectScreen";
            this.Text = "City of Textmora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button skillingButton;
        private System.Windows.Forms.Button combatButton;
        private System.Windows.Forms.Button zoneButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button tavernButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}