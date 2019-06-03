using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Formel_Ön_Muhasebe_Programı
{
    public partial class FormTanitim : Office2007Form
    {
        public FormTanitim()
        {
            InitializeComponent();
        }

        private void FormTanitim_Load(object sender, EventArgs e)
        {
            MediaPlayer.URL = Application.StartupPath.ToString() + "\\Rihanna-Man Down.mp4";
        }

        private void FormTanitim_FormClosing(object sender, FormClosingEventArgs e)
        {
            MediaPlayer.close();
        }
    }
}
