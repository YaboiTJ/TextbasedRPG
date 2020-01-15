using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBasedRPG
{
    public partial class SkillSelectScreen : Form
    {
        public SkillSelectScreen()
        {
            InitializeComponent();
            mainText.Text = "";
            atkLbl.Visible = false;
            avoidLbl.Visible = false;
            atkLblHead.Visible = false;
            atkLblTorso.Visible = false;
            atkLblLower.Visible = false;
        }

        private void combatButton_Click(object sender, EventArgs e)
        {
            mainText.Text = "This is the Combat Test Zone, you see a dummy. It looks enchanted with a spell that makes it invincible. What would you like to do?";
            atkLbl.Visible = true;
            avoidLbl.Visible = true;
        }

        private void atkLbl_Click(object sender, EventArgs e)
        {
            atkLbl.Visible = false;
            avoidLbl.Visible = false;
            atkLblHead.Visible = true;
            atkLblTorso.Visible = true;
            atkLblLower.Visible = true;
        }

        private void atkLbl_MouseHover(object sender, EventArgs e)
        {
            atkLbl.ForeColor = Color.LightSkyBlue;
        }
        private void atkLbl_MouseLeave(object sender, EventArgs e)
        {
            atkLbl.ForeColor = Color.Black;
        }
    }
}
