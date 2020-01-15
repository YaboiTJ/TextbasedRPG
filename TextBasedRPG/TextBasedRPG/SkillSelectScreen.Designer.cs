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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skillingButton = new System.Windows.Forms.Button();
            this.combatButton = new System.Windows.Forms.Button();
            this.zoneButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.tavernButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainText = new System.Windows.Forms.Label();
            this.atkLbl = new System.Windows.Forms.Label();
            this.avoidLbl = new System.Windows.Forms.Label();
            this.atkLblHead = new System.Windows.Forms.Label();
            this.atkLblTorso = new System.Windows.Forms.Label();
            this.atkLblLower = new System.Windows.Forms.Label();
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
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(12, 99);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(75, 23);
            this.shopButton.TabIndex = 5;
            this.shopButton.Text = "Shop";
            this.shopButton.UseVisualStyleBackColor = true;
            // 
            // tavernButton
            // 
            this.tavernButton.Location = new System.Drawing.Point(12, 128);
            this.tavernButton.Name = "tavernButton";
            this.tavernButton.Size = new System.Drawing.Size(75, 23);
            this.tavernButton.TabIndex = 6;
            this.tavernButton.Text = "Tavern";
            this.tavernButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 426);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Location = new System.Drawing.Point(105, 22);
            this.mainText.MaximumSize = new System.Drawing.Size(474, 0);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(0, 13);
            this.mainText.TabIndex = 8;
            // 
            // atkLbl
            // 
            this.atkLbl.AutoSize = true;
            this.atkLbl.BackColor = System.Drawing.Color.White;
            this.atkLbl.Location = new System.Drawing.Point(135, 70);
            this.atkLbl.Name = "atkLbl";
            this.atkLbl.Size = new System.Drawing.Size(38, 13);
            this.atkLbl.TabIndex = 9;
            this.atkLbl.Text = "Attack";
            this.atkLbl.Click += new System.EventHandler(this.atkLbl_Click);
            this.atkLbl.MouseLeave += new System.EventHandler(this.atkLbl_MouseLeave);
            this.atkLbl.MouseHover += new System.EventHandler(this.atkLbl_MouseHover);
            // 
            // avoidLbl
            // 
            this.avoidLbl.AutoSize = true;
            this.avoidLbl.BackColor = System.Drawing.Color.White;
            this.avoidLbl.ForeColor = System.Drawing.Color.Silver;
            this.avoidLbl.Location = new System.Drawing.Point(135, 99);
            this.avoidLbl.Name = "avoidLbl";
            this.avoidLbl.Size = new System.Drawing.Size(34, 13);
            this.avoidLbl.TabIndex = 10;
            this.avoidLbl.Text = "Avoid";
            // 
            // atkLblHead
            // 
            this.atkLblHead.AutoSize = true;
            this.atkLblHead.BackColor = System.Drawing.Color.Transparent;
            this.atkLblHead.Location = new System.Drawing.Point(135, 70);
            this.atkLblHead.Name = "atkLblHead";
            this.atkLblHead.Size = new System.Drawing.Size(33, 13);
            this.atkLblHead.TabIndex = 11;
            this.atkLblHead.Text = "Head";
            // 
            // atkLblTorso
            // 
            this.atkLblTorso.AutoSize = true;
            this.atkLblTorso.Location = new System.Drawing.Point(135, 104);
            this.atkLblTorso.Name = "atkLblTorso";
            this.atkLblTorso.Size = new System.Drawing.Size(34, 13);
            this.atkLblTorso.TabIndex = 12;
            this.atkLblTorso.Text = "Torso";
            // 
            // atkLblLower
            // 
            this.atkLblLower.AutoSize = true;
            this.atkLblLower.Location = new System.Drawing.Point(135, 138);
            this.atkLblLower.Name = "atkLblLower";
            this.atkLblLower.Size = new System.Drawing.Size(36, 13);
            this.atkLblLower.TabIndex = 13;
            this.atkLblLower.Text = "Lower";
            // 
            // SkillSelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atkLblLower);
            this.Controls.Add(this.atkLblTorso);
            this.Controls.Add(this.atkLblHead);
            this.Controls.Add(this.avoidLbl);
            this.Controls.Add(this.atkLbl);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tavernButton);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.zoneButton);
            this.Controls.Add(this.combatButton);
            this.Controls.Add(this.skillingButton);
            this.Controls.Add(this.groupBox2);
            this.Name = "SkillSelectScreen";
            this.Text = "SkillSelectScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button skillingButton;
        private System.Windows.Forms.Button combatButton;
        private System.Windows.Forms.Button zoneButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button tavernButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Label atkLbl;
        private System.Windows.Forms.Label avoidLbl;
        private System.Windows.Forms.Label atkLblHead;
        private System.Windows.Forms.Label atkLblTorso;
        private System.Windows.Forms.Label atkLblLower;
    }
}