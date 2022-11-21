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
    public partial class Frm_Client : UserControl
    {
        Classes.Myconnexion m = new Classes.Myconnexion();
        String sexe = "M";
        public Frm_Client()
        {
            InitializeComponent();
            mod.Enabled = false;
            masculin.Checked = true;
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
            if (nom.Text.Equals("") || postnom.Text.Equals("") || prenom.Text.Equals("") || adresse.Text.Equals("") || contact.Text.Equals("") || mail.Text.Equals("") || nationalite.Text.Equals(""))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp !");
            }
            else
            {
                m.EXEC_UNIVERSEL("proc_client", " '" + id.Text + "','" + nom.Text + "','" + postnom.Text + "','" + prenom.Text + "','" + contact.Text + "','" + mail.Text + "','" + adresse.Text + "','" + sexe + "','" + nationalite.Text + "' ", "Client Ajouter Avec succes");
                m.chargementTableau(dataGridView1, "select * from aff_client order by id desc");
                innit();
                //m.chartchargement(chart1, "select GENRE,count(*) from aff_client group BY GENRE");
            }
            
        }

        private void Frm_Client_Load(object sender, EventArgs e)
        {
            m.chargementTableau(dataGridView1, "select * from aff_client order by id desc");
            m.chartchargement(chart1, "select GENRE,count(*) from aff_client group BY GENRE");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            postnom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            prenom.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            adresse.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            contact.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            nationalite.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
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
            if (nom.Text.Equals("") || postnom.Text.Equals("") || prenom.Text.Equals("") || adresse.Text.Equals("") || contact.Text.Equals("") || mail.Text.Equals("") || nationalite.Text.Equals(""))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp !");
            }
            else
            {
                m.EXEC_UNIVERSEL("proc_client", " '" + id.Text + "','" + nom.Text + "','" + postnom.Text + "','" + prenom.Text + "','" + contact.Text + "','" + mail.Text + "','" + adresse.Text + "','" + sexe + "','" + nationalite.Text + "' ", "Client Modifier Avec succes");
                m.chargementTableau(dataGridView1, "select * from aff_client order by id desc");
                mod.Enabled = false;
                add.Enabled = true;
                innit();
            }
            
        }
    }
}
