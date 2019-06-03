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
    public partial class CariRapor : Office2007Form
    {
        public CariRapor()
        {
            InitializeComponent();
        }

        private void CariRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MuhasebeDataSet.CariList' table. You can move, or remove it, as needed.
            this.CariListTableAdapter.Fill(this.MuhasebeDataSet.CariList);

            this.report_Cari.RefreshReport();
        }
    }
}
