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
    public partial class Frm_expedition : UserControl
    {
        Classes.Myconnexion m = new Classes.Myconnexion();
        
        public Frm_expedition()
        {
            InitializeComponent();
            mod.Enabled = false;
            ajout.Enabled = false;
            modifier.Enabled = false;
            
        }

        private void Frm_expedition_Load(object sender, EventArgs e)
        {
            m.chargementCombo(client, "select NOM+'   '+POSTNOM+'   '+PRENOM client from tClient");
            m.chargementCombo(agent, "select Nom+'  '+postnom+'  '+prenom agent from Agent");
            m.chargementCombo(type, "select Designation from TypeCourrier");
            m.chargementCombo(moyen, "select Designation from Moyen");
            m.chargementTableau(dataGridView1, "select * from aff_expedition order by id desc");
            m.chargementTableau(guna2DataGridView1, "select * from aff_detail order by id desc");

        }
        public void innit()
        {
            id2.Text = "";
            poids.Text = "";
            nom.Text = "";
            adresse.Text = "";
            conditionnement.Text = "";
            contact.Text = "";
            mail.Text = "";
            depart.Text = "";
            arrivee.Text = "";
            expedition.Text = "";
            type.SelectedIndex = -1;
            moyen.SelectedIndex = -1;
            agent.SelectedIndex = -1;

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (client.SelectedIndex.Equals(-1) || date.Text.Equals(""))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp !");
            }
            else
            {
                m.EXEC_UNIVERSEL("proc_expedition", "'" + id.Text + "','" + client.Text + "','" + date.Value.ToString("yyyy-MM-dd") + "'", "Expedition avec succes");
                m.chargementTableau(dataGridView1, "select * from aff_expedition order by id desc");
                id.Text = "";
                client.SelectedIndex = -1;
                date.Text = "";
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            expedition.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            client.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            date.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            add.Enabled = false;
            mod.Enabled = true;
            ajout.Enabled = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (client.SelectedIndex.Equals(-1) || date.Text.Equals(""))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp !");
            }
            else
            {
                m.EXEC_UNIVERSEL("proc_expedition", "'" + id.Text + "','" + client.Text + "','" + date.Value.ToString("yyyy-MM-dd") + "'", "Expedition Modifier avec succes");
                m.chargementTableau(dataGridView1, "select * from aff_expedition order by id desc");
                id.Text = "";
                client.SelectedIndex = -1;
                date.Text = "";
                add.Enabled = true;
                mod.Enabled = false;
                
            }
        }
      

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (poids.Text.Equals("") || nom.Text.Equals("") || adresse.Text.Equals("") || conditionnement.Text.Equals("") || contact.Text.Equals("") || mail.Text.Equals("") || depart.Text.Equals("") || arrivee.Text.Equals("") || expedition.Text.Equals("") || type.SelectedIndex.Equals(-1) || moyen.SelectedIndex.Equals(-1) || agent.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp !");
            }
            else
            {
                m.EXPEDITION("proc_detailexp", "'" + id2.Text + "','" + poids.Text + "','" + nom.Text + "','" + adresse.Text + "','" + contact.Text + "','" + mail.Text + "','" + depart.Text + "','" + arrivee.Text + "','" + conditionnement.Text + "','" + expedition.Text + "','" + type.Text + "','" + moyen.Text + "','" + agent.Text + "'");
                m.chargementTableau(guna2DataGridView1, "select * from aff_detail order by id desc");
                innit();
            }
            
        }
         

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (id2.Text.Equals("") || poids.Text.Equals("") || nom.Text.Equals("") || adresse.Text.Equals("") || conditionnement.Text.Equals("") || contact.Text.Equals("") || mail.Text.Equals("") || depart.Text.Equals("") || arrivee.Text.Equals("") || expedition.Text.Equals("") || type.SelectedIndex.Equals(-1) || moyen.SelectedIndex.Equals(-1) || agent.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Tous les champs sont obligatoires svp !");
            }
            else
            {
                m.EXPEDITION("proc_detailexp", "'" + id2.Text + "','" + poids.Text + "','" + nom.Text + "','" + adresse.Text + "','" + contact.Text + "','" + mail.Text + "','" + depart.Text + "','" + arrivee.Text + "','" + conditionnement.Text + "','" + expedition.Text + "','" + type.Text + "','" + moyen.Text + "','" + agent.Text + "'");
                m.chargementTableau(guna2DataGridView1, "select * from aff_detail order by id desc");
                modifier.Enabled = false;
                innit();
            }
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id2.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            nom.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            adresse.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            contact.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            mail.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            depart.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            arrivee.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
            conditionnement.Text = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
            poids.Text = guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
            expedition.Text = guna2DataGridView1.CurrentRow.Cells[9].Value.ToString();
            type.Text = guna2DataGridView1.CurrentRow.Cells[10].Value.ToString();
            moyen.Text = guna2DataGridView1.CurrentRow.Cells[11].Value.ToString();
            agent.Text = guna2DataGridView1.CurrentRow.Cells[12].Value.ToString();
            ajout.Enabled = false;
            modifier.Enabled = true;
        }
    }
}
