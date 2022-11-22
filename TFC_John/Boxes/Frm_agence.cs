using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFC_John.Boxes
{
    public partial class Frm_agence : Form
    {
        Classes.Myconnexion m = new Classes.Myconnexion();
        public Frm_agence()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                m.EXEC_UNIVERSEL("proc_agence", "'" + id.Text + "','" + designation.Text + "','" + adresse.Text + "'", "Agence Ajouter avec succes");
                m.chargementTableau(dataGridView1, "select * from Agence order by id desc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        private void Frm_agence_Load(object sender, EventArgs e)
        {
             m.chargementTableau(dataGridView1,"select * from Agence order by id desc");
        }
    }
}
