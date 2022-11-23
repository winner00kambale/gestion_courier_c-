using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFC_John
{
    public partial class Form1 : Form
    {
        Classes.Appel a = new Classes.Appel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new UserControls.Frm_Client(), principal);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new UserControls.Frm_agent(), principal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new UserControls.Frm_expedition(), principal);
        }

        private void newAgenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Boxes.Frm_agence().ShowDialog();
        }

        private void typeCourrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Boxes.Frm_type_courrier().ShowDialog();
        }

        private void moyenTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Boxes.Frm_Moyen_Transport().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new UserControls.Frm_Payement(), principal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a.APPEL_PANEL(new UserControls.Frm_rapport(), principal);
        }
    }
}
