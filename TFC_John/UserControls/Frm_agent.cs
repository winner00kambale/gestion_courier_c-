using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFC_John.UserControls
{
    public partial class Frm_agent : UserControl
    {
        Classes.Myconnexion m = new Classes.Myconnexion();
        string sexe = "M";
        public Frm_agent()
        {
            InitializeComponent();
            masculin.Checked = true;
            mod.Enabled = false;
        }
        public void innit()
        {
            id.Text = "";
            nom.Text = "";
            postnom.Text = "";
            prenom.Text = "";
            nationalite.Text = "";
            mail.Text = "";
            adresse.Text = "";
            contact.Text = "";
            agence.SelectedIndex = -1;
            etat.SelectedIndex = -1;

        }

        private void Frm_agent_Load(object sender, EventArgs e)
        {
            m.chargementTableau(dataGridView1, "select * from aff_agent");
            m.chargementCombo(agence,"select Designation from Agence");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             if (masculin.Checked == true)
            {
                sexe = "M";
            }
            else if (feminin.Checked == true)
            {
                sexe = "F";
            }
             if (nom.Text.Equals("") || postnom.Text.Equals("") || prenom.Text.Equals("") || adresse.Text.Equals("") || contact.Text.Equals("") || mail.Text.Equals("") || nationalite.Text.Equals("") || agence.SelectedIndex.Equals(-1) || etat.SelectedIndex.Equals(-1))
             {
                 MessageBox.Show("Tous les champs sont obligatoires svp !");
             }
             else
             {
                 m.EXEC_UNIVERSEL("proc_agent", "'" + id.Text + "','" + nom.Text + "','" + postnom.Text + "','" + prenom.Text + "','" + adresse.TextAlign + "','" + mail.Text + "','" + etat.Text + "','" + sexe + "','" + agence.Text + "','" + contact.Text + "','" + nationalite.Text + "'", "Agent '" + nom.Text + "' ajouter avec succes");
                 m.chargementTableau(dataGridView1, "select * from aff_agent");
                 innit();
             }
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (masculin.Checked == true)
            {
                sexe = "M";
            }
            else if (feminin.Checked == true)
            {
                sexe = "F";
            }
            if (nom.Text.Equals("") || postnom.Text.Equals("") || prenom.Text.Equals("") || adresse.Text.Equals("") || contact.Text.Equals("") || mail.Text.Equals("") || nationalite.Text.Equals("") || agence.TabIndex.Equals(0) || etat.TabIndex.Equals(0))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp !");
            }
            else
            {
                m.EXEC_UNIVERSEL("proc_agent", "'" + id.Text + "','" + nom.Text + "','" + postnom.Text + "','" + prenom.Text + "','" + adresse.TextAlign + "','" + mail.Text + "','" + etat.Text + "','" + sexe + "','" + agence.Text + "','" + contact.Text + "','" + nationalite.Text + "'", "Agent '" + nom.Text + "' ajouter avec succes");
                m.chargementTableau(dataGridView1, "select * from aff_agent");
                mod.Enabled = false;
                add.Enabled = true;
                innit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            postnom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            prenom.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            etat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            adresse.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            contact.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            nationalite.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            agence.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Equals("Masculin"))
            {
                masculin.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Equals("Feminin"))
            {
                feminin.Checked = true;
            }
            mod.Enabled = true;
            add.Enabled = false;
        }
    }
}
