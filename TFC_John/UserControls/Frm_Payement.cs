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
    public partial class Frm_Payement : UserControl
    {
        Classes.Myconnexion m = new Classes.Myconnexion();
        public Frm_Payement()
        {
            InitializeComponent();
            print.Enabled = false;
        }

        private void Frm_Payement_Load(object sender, EventArgs e)
        {
            m.chargementTableau(dataGridView1,"select * from detail where id not in(select detailExpedition from Paiement)");
            m.chargementTableau(dataGridView2, "select * from aff_payement");
            m.chartchargement(chart1, "select datePaiement,COUNT(*) from aff_payement group by datePaiement");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            expe.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a_payer.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            type.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(a_payer.Text);
            float b = float.Parse(montant.Text);
            if (expe.Text.Equals("") || montant.Text.Equals("") || libelle.Text.Equals("") || date.Text.Equals("") || a_payer.Text.Equals("") || type.Text.Equals(""))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp !");
            }else if (a > b || a<b ){
                MessageBox.Show("Le montant doit etre égal au montant à payé");
            }
            else
            {
                m.EXEC_UNIVERSEL("proc_paiement", "'" + id.Text + "','" + expe.Text + "','" + montant.Text + "','" + libelle.Text + "'", "Payement avec succes");
                m.chargementTableau(dataGridView2, "select * from aff_payement");
                m.chargementTableau(dataGridView1, "select * from detail where id not in(select detailExpedition from Paiement)");
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (id.Text.Equals(""))
            {
                MessageBox.Show("veillez d'abord selectionner");
            }
            else
            {
                sorties.facture c = new sorties.facture();
                c.DataSource = m.get_Report_Z("*", " facture", " where id =" + id.Text + "");
                using (ReportPrintTool printTool = new ReportPrintTool(c))
                {
                    printTool.ShowPreviewDialog();
                }
                print.Enabled = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            print.Enabled = true;
        }
    }
}
