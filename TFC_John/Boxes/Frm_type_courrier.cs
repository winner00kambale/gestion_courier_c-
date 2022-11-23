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
    public partial class Frm_type_courrier : Form
    {
        Classes.Myconnexion m = new Classes.Myconnexion();
        public Frm_type_courrier()
        {
            InitializeComponent();
            id.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (designation.Text.Equals("") || pu.Text.Equals(""))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp");
            }
            else
            {
                try
                {
                    m.EXEC_UNIVERSEL("proc_TypeCour", "'" + id.Text + "','" + designation.Text + "','"+pu.Text+"'", "Type Ajouter Avec succes");
                    m.chargementTableau(guna2DataGridView1, "select * from TypeCourrier order by id desc");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ce Type Existe deja" +ex.Message);
                }
            }
            
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (id.Text.Equals("") || designation.Text.Equals("") || pu.Text.Equals(""))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp");
            }
            else
            {
                try
                {
                    m.EXEC_UNIVERSEL("proc_TypeCour", "'" + id.Text + "','" + designation.Text + "','" + pu.Text + "'", "Type Modifier Avec succes");
                    m.chargementTableau(guna2DataGridView1,"select * from TypeCourrier order by id desc");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ce Type Existe deja" + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_type_courrier_Load(object sender, EventArgs e)
        {
            m.chargementTableau(guna2DataGridView1, "select * from TypeCourrier order by id desc");
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            designation.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            pu.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
