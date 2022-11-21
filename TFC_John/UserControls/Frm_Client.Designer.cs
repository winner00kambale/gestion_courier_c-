namespace TFC_John.UserControls
{
    partial class Frm_Client
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.nationalite = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mod = new Guna.UI2.WinForms.Guna2Button();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.id = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id);
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
            this.groupBox1.Location = new System.Drawing.Point(45, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDENTITE CLIENT";
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
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "PreNom Client";
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
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "PostNom Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Client";
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
            this.groupBox2.Controls.Add(this.nationalite);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.contact);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.adresse);
            this.groupBox2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(403, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADRESSE CLIENT";
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
            this.nationalite.Location = new System.Drawing.Point(10, 267);
            this.nationalite.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.nationalite.Name = "nationalite";
            this.nationalite.PasswordChar = '\0';
            this.nationalite.PlaceholderText = "";
            this.nationalite.SelectedText = "";
            this.nationalite.ShadowDecoration.Parent = this.nationalite;
            this.nationalite.Size = new System.Drawing.Size(318, 40);
            this.nationalite.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nationalité Client";
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
            this.contact.Size = new System.Drawing.Size(318, 37);
            this.contact.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contact Client";
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
            this.mail.Size = new System.Drawing.Size(318, 36);
            this.mail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mail Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Adresse Client";
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
            this.adresse.Size = new System.Drawing.Size(320, 36);
            this.adresse.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(45, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1075, 360);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1059, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mod);
            this.groupBox4.Controls.Add(this.add);
            this.groupBox4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(748, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 88);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // mod
            // 
            this.mod.CheckedState.Parent = this.mod;
            this.mod.CustomImages.Parent = this.mod;
            this.mod.Font = new System.Drawing.Font("Century", 12F);
            this.mod.ForeColor = System.Drawing.Color.White;
            this.mod.HoverState.Parent = this.mod;
            this.mod.Location = new System.Drawing.Point(194, 26);
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
            this.add.Location = new System.Drawing.Point(35, 26);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.add.Size = new System.Drawing.Size(137, 45);
            this.add.TabIndex = 0;
            this.add.Text = "Ajouter";
            this.add.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart1);
            this.groupBox5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(748, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(366, 223);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Statistique ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 26);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(354, 188);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(225, 25);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 18);
            this.id.TabIndex = 7;
            // 
            // Frm_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Client";
            this.Size = new System.Drawing.Size(1135, 707);
            this.Load += new System.EventHandler(this.Frm_Client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox postnom;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox prenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton masculin;
        private System.Windows.Forms.RadioButton feminin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox contact;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox adresse;
        private Guna.UI2.WinForms.Guna2TextBox nationalite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2Button mod;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label id;
    }
}
