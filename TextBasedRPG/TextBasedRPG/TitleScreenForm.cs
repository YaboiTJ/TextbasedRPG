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
    public partial class formTitleScreen : Form
    {
        Thread sssthread;
        public formTitleScreen()
        {
            InitializeComponent();
        }

        private void TitleScreen_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            sssthread = new Thread(openSkillSelectScreen);
            sssthread.SetApartmentState(ApartmentState.STA);
            sssthread.Start();
        }

        private void openSkillSelectScreen()
        {
            Application.Run(new SkillSelectScreen());
        }
    }
}
