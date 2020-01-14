using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TextBasedRPG
{
    public partial class SkillSelectScreen : Form
    {
        Thread skilling, combat, tavern, zone, shop;
        public SkillSelectScreen()
        {
            InitializeComponent();
        }

        private void skillingButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void combatButton_Click(object sender, EventArgs e)
        {

        }

        private void zoneButton_Click(object sender, EventArgs e)
        {

        }

        private void shopButton_Click(object sender, EventArgs e)
        {

        }

        private void tavernButton_Click(object sender, EventArgs e)
        {

        }
    }
}
