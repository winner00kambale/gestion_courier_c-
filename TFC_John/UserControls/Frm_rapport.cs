using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TFC_John.UserControls
{
    public partial class Frm_rapport : UserControl
    {
        Classes.Myconnexion m = new Classes.Myconnexion();
        public Frm_rapport()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sorties.rapport_journalier_expedition r = new sorties.rapport_journalier_expedition();
            r.DataSource = m.get_Rapport("aff_rapport", "'" + debut.Value.ToString("yyyy-MM-dd") + "','" + fin.Value.ToString("yyyy-MM-dd") + "' ");
            using (ReportPrintTool printTool = new ReportPrintTool(r))
            {
                printTool.ShowPreviewDialog();
            }
        }
    }
}
