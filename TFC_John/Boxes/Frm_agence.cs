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
            mod.Enabled = false;
            id.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (designation.Text.Equals("") || adresse.Text.Equals("") || ville.Text.Equals(""))
            {
                MessageBox.Show("tous les champs sont obligatoires svp !");
            }
            else
            {
                try
                {
                    m.EXEC_UNIVERSEL("proc_agence", "'" + id.Text + "','" + designation.Text + "','" + adresse.Text + "','" + ville.Text + "'", "Agence Ajouter avec succes");
                    m.chargementTableau(dataGridView1, "select * from Agence order by id desc");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("l'agence " + designation.Text + " Existe deja " +ex.Message);
                }
            }
           
        }

        private void Frm_agence_Load(object sender, EventArgs e)
        {
             m.chargementTableau(dataGridView1,"select * from Agence order by id desc");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            designation.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            adresse.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ville.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mod.Enabled = true;
            add.Enabled = false;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (id.Text.Equals("") || designation.Text.Equals("") || adresse.Text.Equals("") || ville.Text.Equals(""))
            {
                MessageBox.Show("tous les champs sont obligatoires svp !");
            }
            else
            {
                try
                {
                    m.EXEC_UNIVERSEL("proc_agence", "'" + id.Text + "','" + designation.Text + "','" + adresse.Text + "','" + ville.Text + "'", "Agence Modifier avec succes");
                    m.chargementTableau(dataGridView1, "select * from Agence order by id desc");
                    mod.Enabled = false; ;
                    add.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("l'agence " + designation.Text + " Existe deja " + ex.Message);
                }
            }
        }
    }
}
