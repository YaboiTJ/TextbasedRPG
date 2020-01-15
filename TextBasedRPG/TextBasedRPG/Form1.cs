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
    public partial class formTitleScreen : Form
    {
        public formTitleScreen()
        {
            InitializeComponent();
        }

        private void TitleScreen_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 combatForm = new Form2();
            combatForm.Show();
            this.Hide();
        }
    }
}
