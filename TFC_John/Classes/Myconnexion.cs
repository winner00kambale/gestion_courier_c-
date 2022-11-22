using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TFC_John.Classes
{
    class Myconnexion
    {
        public static string imgLon = "";
        public static string chemin = @"Data Source=DESKTOP-8MK45AK\SA;Initial Catalog=JOHN_TFC;User ID=sa;Password=winner";
        public static SqlConnection con = new SqlConnection("" + chemin);
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader dr;
        public static SqlDataAdapter dt = null;
        public static DataSet ds = new DataSet();

        public DataSet get_Report_Z(string colonnes, string nomTable, string refh)
        {
            DataSet dst;
            try
            {
                //   innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT  " + colonnes + " FROM " + nomTable + "" + refh, con);
                //  cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
                Console.WriteLine("SELECT  " + colonnes + " FROM " + nomTable + "" + refh);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("SELECT  " + colonnes + " FROM " + nomTable + "" + refh);
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        public void login(string username, string password, Form s)
        {
            con.Open();
            try
            {
                cmd.CommandText = "select * from tuser where username='" + username + "' and password_='" + password + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    //new Form1("" + dr[1].ToString()).Show();
                    s.Hide();

                }
                else
                {
                    MessageBox.Show("le mot de passe est incorrect", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void chargementTableau(DataGridView dg, string rqt)
        {
            con.Open();
            try
            {

                cmd = con.CreateCommand();
                SqlDataAdapter da = new SqlDataAdapter(rqt, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "CLIENT");
                dg.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();

        }
        public void EXEC_UNIVERSEL(String proc, string parametre, string message)
        {
            con.Open();
            try
            {

                cmd.CommandText = "EXEC " + proc + " " + parametre;
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "Avec Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        public void chartchargement(Chart a, string rqt)
        {


            try
            {
                //  a.Series["Series1"].Points.re
                con.Open();
                cmd.CommandText = "" + rqt;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a.Series["Series1"].Points.AddXY("" + dr[0].ToString(), int.Parse(dr[1].ToString()));
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void chargementCombo(ComboBox cmb, string rqt)
        {
            cmb.Items.Clear();

            try
            {
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr[0].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void chargementLabel(Label lab, string rqt)
        {
            try
            {
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lab.Text = dr[0].ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CHOISIR_IMAGE(PictureBox picture)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
            dlg.Title = "Selectionner une image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLon = dlg.FileName.ToString();
                picture.ImageLocation = imgLon;
            }
        }
        public void EXEC_UNIVERSEL_picture(String proc, string parametre, string message)
        {
            con.Open();
            try
            {
                byte[] img = null;

                cmd.Parameters.Clear();
                FileStream fs = new FileStream(imgLon, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                cmd.CommandText = "EXEC " + proc + " " + parametre;
                cmd.Parameters.Add(new SqlParameter("@IMAGE", img));
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "Reussite", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        public void GET_PHOTO(string RQT, PictureBox picemp, int row)
        {
            con.Open();
            try
            {

                cmd.CommandText = RQT + "";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    byte[] img = (byte[])(dr[row]);
                    if (img == null)
                        picemp.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picemp.Image = System.Drawing.Image.FromStream(ms);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }
        public void UNIVERSALLabel(string RQT, Label prenom, int row)
        {
            con.Open();

            try
            {

                cmd.CommandText = "" + RQT;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    prenom.Text = dr[row].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void EXPEDITION(String proc, string parametre)
        {
            
            con.Open();
            try
            {
               
                cmd.CommandText = "EXEC " + proc + " " + parametre;
                
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (int.Parse(dr[0].ToString()) == 1)
                    {
                        
                        MessageBox.Show("cette expedition a deja ete effectuee");

                    }
                    else if (int.Parse(dr[0].ToString()) == 2)
                    {
                        MessageBox.Show("Modification avec succes");
                        
                    }
                    else if (int.Parse(dr[0].ToString()) == 3)
                    {
                        MessageBox.Show("Detail Ajouter Avec Succes");
                       
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
    }
}
