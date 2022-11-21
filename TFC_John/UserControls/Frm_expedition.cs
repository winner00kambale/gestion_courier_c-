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
        }

        private void Frm_expedition_Load(object sender, EventArgs e)
        {
            m.chargementCombo(client, "select NOM+'   '+POSTNOM+'   '+PRENOM client from tClient");
            m.chargementCombo(agent, "select Nom+'   '+postnom+'   '+prenom agent from Agent");
            m.chargementCombo(type, "select Designation from TypeCourrier");
            m.chargementCombo(moyen, "select Designation from Moyen");
            m.chargementTableau(dataGridView1, "select * from aff_expedition order by id desc");
            m.chargementTableau(guna2DataGridView1, "select * from DetailExpedition");
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
            m.EXEC_UNIVERSEL("proc_detailexp", "'"+id2.Text+"','"+poids.Text+"','"+nom.Text+"','"+adresse.Text+"','"+contact.Text+"','"+mail.Text+"','"+depart.Text+"','"+arrivee.Text+"','"+conditionnement.Text+"','"+expedition.Text+"','"+type.Text+"','"+moyen.Text+"','"+agent.Text+"'", "Detail enregistrer avec succes");
            m.chargementTableau(guna2DataGridView1,"select * from DetailExpedition");
        }
    }
}
