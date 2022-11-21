namespace TFC_John.UserControls
{
    partial class Frm_agent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.Label();
            this.etat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.feminin = new System.Windows.Forms.RadioButton();
            this.masculin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.postnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agence = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nationalite = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.adresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mod = new Guna.UI2.WinForms.Guna2Button();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.etat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.feminin);
            this.groupBox1.Controls.Add(this.masculin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.prenom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.postnom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDENTITE AGENT";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(246, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 18);
            this.id.TabIndex = 9;
            // 
            // etat
            // 
            this.etat.BackColor = System.Drawing.Color.Transparent;
            this.etat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.etat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.etat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.etat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.etat.FocusedState.Parent = this.etat;
            this.etat.Font = new System.Drawing.Font("Century", 11.25F);
            this.etat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.etat.HoverState.Parent = this.etat;
            this.etat.ItemHeight = 30;
            this.etat.Items.AddRange(new object[] {
            "Celibataire",
            "Marie(e)",
            "Divorce",
            "Veuf(ve)"});
            this.etat.ItemsAppearance.Parent = this.etat;
            this.etat.Location = new System.Drawing.Point(9, 325);
            this.etat.Name = "etat";
            this.etat.ShadowDecoration.Parent = this.etat;
            this.etat.Size = new System.Drawing.Size(324, 36);
            this.etat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Etat Civil Agent";
            // 
            // feminin
            // 
            this.feminin.AutoSize = true;
            this.feminin.Location = new System.Drawing.Point(165, 266);
            this.feminin.Name = "feminin";
            this.feminin.Size = new System.Drawing.Size(85, 22);
            this.feminin.TabIndex = 6;
            this.feminin.TabStop = true;
            this.feminin.Text = "Feminin";
            this.feminin.UseVisualStyleBackColor = true;
            // 
            // masculin
            // 
            this.masculin.AutoSize = true;
            this.masculin.Location = new System.Drawing.Point(8, 266);
            this.masculin.Name = "masculin";
            this.masculin.Size = new System.Drawing.Size(90, 22);
            this.masculin.TabIndex = 5;
            this.masculin.TabStop = true;
            this.masculin.Text = "Masculin";
            this.masculin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genre";
            // 
            // prenom
            // 
            this.prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom.DefaultText = "";
            this.prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.DisabledState.Parent = this.prenom;
            this.prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.FocusedState.Parent = this.prenom;
            this.prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.HoverState.Parent = this.prenom;
            this.prenom.Location = new System.Drawing.Point(10, 200);
            this.prenom.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.prenom.Name = "prenom";
            this.prenom.PasswordChar = '\0';
            this.prenom.PlaceholderText = "";
            this.prenom.SelectedText = "";
            this.prenom.ShadowDecoration.Parent = this.prenom;
            this.prenom.Size = new System.Drawing.Size(323, 37);
            this.prenom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "PreNom Agent";
            // 
            // postnom
            // 
            this.postnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.postnom.DefaultText = "";
            this.postnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.postnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.postnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.postnom.DisabledState.Parent = this.postnom;
            this.postnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.postnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.postnom.FocusedState.Parent = this.postnom;
            this.postnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.postnom.HoverState.Parent = this.postnom;
            this.postnom.Location = new System.Drawing.Point(10, 134);
            this.postnom.Margin = new System.Windows.Forms.Padding(6);
            this.postnom.Name = "postnom";
            this.postnom.PasswordChar = '\0';
            this.postnom.PlaceholderText = "";
            this.postnom.SelectedText = "";
            this.postnom.ShadowDecoration.Parent = this.postnom;
            this.postnom.Size = new System.Drawing.Size(323, 36);
            this.postnom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "PostNom Agent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Agent";
            // 
            // nom
            // 
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DefaultText = "";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.Parent = this.nom;
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.FocusedState.Parent = this.nom;
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.HoverState.Parent = this.nom;
            this.nom.Location = new System.Drawing.Point(8, 66);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(325, 36);
            this.nom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agence);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nationalite);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.contact);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.mail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.adresse);
            this.groupBox2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 373);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADRESSE CLIENT";
            // 
            // agence
            // 
            this.agence.BackColor = System.Drawing.Color.Transparent;
            this.agence.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.agence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agence.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.agence.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.agence.FocusedState.Parent = this.agence;
            this.agence.Font = new System.Drawing.Font("Century", 11.25F);
            this.agence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.agence.HoverState.Parent = this.agence;
            this.agence.ItemHeight = 30;
            this.agence.ItemsAppearance.Parent = this.agence;
            this.agence.Location = new System.Drawing.Point(10, 331);
            this.agence.Name = "agence";
            this.agence.ShadowDecoration.Parent = this.agence;
            this.agence.Size = new System.Drawing.Size(320, 36);
            this.agence.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Agence";
            // 
            // nationalite
            // 
            this.nationalite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nationalite.DefaultText = "";
            this.nationalite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nationalite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nationalite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalite.DisabledState.Parent = this.nationalite;
            this.nationalite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalite.FocusedState.Parent = this.nationalite;
            this.nationalite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalite.HoverState.Parent = this.nationalite;
            this.nationalite.Location = new System.Drawing.Point(10, 264);
            this.nationalite.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.nationalite.Name = "nationalite";
            this.nationalite.PasswordChar = '\0';
            this.nationalite.PlaceholderText = "";
            this.nationalite.SelectedText = "";
            this.nationalite.ShadowDecoration.Parent = this.nationalite;
            this.nationalite.Size = new System.Drawing.Size(320, 37);
            this.nationalite.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nationalité Agent";
            // 
            // contact
            // 
            this.contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contact.DefaultText = "";
            this.contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contact.DisabledState.Parent = this.contact;
            this.contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contact.FocusedState.Parent = this.contact;
            this.contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contact.HoverState.Parent = this.contact;
            this.contact.Location = new System.Drawing.Point(10, 200);
            this.contact.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.contact.Name = "contact";
            this.contact.PasswordChar = '\0';
            this.contact.PlaceholderText = "";
            this.contact.SelectedText = "";
            this.contact.ShadowDecoration.Parent = this.contact;
            this.contact.Size = new System.Drawing.Size(320, 37);
            this.contact.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contact Agent";
            // 
            // mail
            // 
            this.mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mail.DefaultText = "";
            this.mail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mail.DisabledState.Parent = this.mail;
            this.mail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mail.FocusedState.Parent = this.mail;
            this.mail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mail.HoverState.Parent = this.mail;
            this.mail.Location = new System.Drawing.Point(10, 134);
            this.mail.Margin = new System.Windows.Forms.Padding(6);
            this.mail.Name = "mail";
            this.mail.PasswordChar = '\0';
            this.mail.PlaceholderText = "";
            this.mail.SelectedText = "";
            this.mail.ShadowDecoration.Parent = this.mail;
            this.mail.Size = new System.Drawing.Size(320, 36);
            this.mail.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mail Agent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Adresse Agent";
            // 
            // adresse
            // 
            this.adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresse.DefaultText = "";
            this.adresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adresse.DisabledState.Parent = this.adresse;
            this.adresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adresse.FocusedState.Parent = this.adresse;
            this.adresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adresse.HoverState.Parent = this.adresse;
            this.adresse.Location = new System.Drawing.Point(8, 66);
            this.adresse.Margin = new System.Windows.Forms.Padding(4);
            this.adresse.Name = "adresse";
            this.adresse.PasswordChar = '\0';
            this.adresse.PlaceholderText = "";
            this.adresse.SelectedText = "";
            this.adresse.ShadowDecoration.Parent = this.adresse;
            this.adresse.Size = new System.Drawing.Size(322, 36);
            this.adresse.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mod);
            this.groupBox4.Controls.Add(this.add);
            this.groupBox4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(742, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 88);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // mod
            // 
            this.mod.CheckedState.Parent = this.mod;
            this.mod.CustomImages.Parent = this.mod;
            this.mod.Font = new System.Drawing.Font("Century", 12F);
            this.mod.ForeColor = System.Drawing.Color.White;
            this.mod.HoverState.Parent = this.mod;
            this.mod.Location = new System.Drawing.Point(192, 26);
            this.mod.Name = "mod";
            this.mod.ShadowDecoration.Parent = this.mod;
            this.mod.Size = new System.Drawing.Size(137, 45);
            this.mod.TabIndex = 1;
            this.mod.Text = "Modifier";
            this.mod.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // add
            // 
            this.add.CheckedState.Parent = this.add;
            this.add.CustomImages.Parent = this.add;
            this.add.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.Parent = this.add;
            this.add.Location = new System.Drawing.Point(33, 26);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.add.Size = new System.Drawing.Size(137, 45);
            this.add.TabIndex = 0;
            this.add.Text = "Ajouter";
            this.add.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 251);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(41, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1058, 292);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(742, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 251);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "groupControl1";
            // 
            // Frm_agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_agent";
            this.Size = new System.Drawing.Size(1135, 707);
            this.Load += new System.EventHandler(this.Frm_agent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton feminin;
        private System.Windows.Forms.RadioButton masculin;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox prenom;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox postnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox etat;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox nationalite;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox contact;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox mail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox adresse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button mod;
        private Guna.UI2.WinForms.Guna2Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Guna.UI2.WinForms.Guna2ComboBox agence;
        private System.Windows.Forms.Label id;
    }
}
