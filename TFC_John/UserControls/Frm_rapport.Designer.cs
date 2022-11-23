namespace TFC_John.UserControls
{
    partial class Frm_rapport
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.debut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(155, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapport Journalier";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.debut);
            this.groupBox2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date debut";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fin);
            this.groupBox3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(226, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date fin";
            // 
            // fin
            // 
            this.fin.CheckedState.Parent = this.fin;
            this.fin.FillColor = System.Drawing.Color.SteelBlue;
            this.fin.Font = new System.Drawing.Font("Century", 12F);
            this.fin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fin.HoverState.Parent = this.fin;
            this.fin.Location = new System.Drawing.Point(6, 22);
            this.fin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fin.Name = "fin";
            this.fin.ShadowDecoration.Parent = this.fin;
            this.fin.Size = new System.Drawing.Size(193, 36);
            this.fin.TabIndex = 4;
            this.fin.Value = new System.DateTime(2022, 11, 23, 8, 18, 35, 128);
            // 
            // debut
            // 
            this.debut.CheckedState.Parent = this.debut;
            this.debut.FillColor = System.Drawing.Color.SteelBlue;
            this.debut.Font = new System.Drawing.Font("Century", 12F);
            this.debut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.debut.HoverState.Parent = this.debut;
            this.debut.Location = new System.Drawing.Point(6, 22);
            this.debut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.debut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.debut.Name = "debut";
            this.debut.ShadowDecoration.Parent = this.debut;
            this.debut.Size = new System.Drawing.Size(193, 36);
            this.debut.TabIndex = 5;
            this.debut.Value = new System.DateTime(2022, 11, 23, 8, 18, 35, 128);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.guna2Button1);
            this.groupBox4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 70);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rapport Expedition";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Century", 14.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(6, 20);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(398, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Imprimer";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.guna2Button2);
            this.groupBox5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(21, 217);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(410, 70);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rapport Recettes";
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Century", 14.25F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(6, 20);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(398, 45);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Imprimer";
            // 
            // Frm_rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_rapport";
            this.Size = new System.Drawing.Size(1135, 707);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DateTimePicker fin;
        private Guna.UI2.WinForms.Guna2DateTimePicker debut;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
