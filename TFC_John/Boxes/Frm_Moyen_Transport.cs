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
    public partial class Frm_Moyen_Transport : Form
    {
        Classes.Myconnexion m = new Classes.Myconnexion();
        public Frm_Moyen_Transport()
        {
            InitializeComponent();
            id.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (designation.Text.Equals(""))
            {
                MessageBox.Show("tous les champs sont obligatoires svp");
            }
            else
            {
                m.EXEC_UNIVERSEL("proc_moyen", "'" + id.Text + "','" + designation.Text + "'", "Moyen Ajouter Avec succes");
            }
            
        }
    }
}
