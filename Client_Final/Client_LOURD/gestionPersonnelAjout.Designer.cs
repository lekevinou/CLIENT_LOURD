namespace Client_LOURD
{
    partial class gestionPersonnelAjout
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nomPersonnel = new System.Windows.Forms.TextBox();
            this.prenomPersonnel = new System.Windows.Forms.TextBox();
            this.telPersonnel = new System.Windows.Forms.TextBox();
            this.magasinPersonnel = new System.Windows.Forms.ComboBox();
            this.magasinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamilonbaseDataSet1 = new Client_LOURD.gamilonbaseDataSet1();
            this.adr1Personnel = new System.Windows.Forms.TextBox();
            this.adr2Personnel = new System.Windows.Forms.TextBox();
            this.villePersonnel = new System.Windows.Forms.TextBox();
            this.cpPersonnel = new System.Windows.Forms.TextBox();
            this.ajouterPersonnel = new System.Windows.Forms.Button();
            this.annulerPersonnel = new System.Windows.Forms.Button();
            this.magasinTableAdapter = new Client_LOURD.gamilonbaseDataSet1TableAdapters.magasinTableAdapter();
            this.date_entree = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.postePersonnel = new System.Windows.Forms.ComboBox();
            this.posteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.posteTableAdapter = new Client_LOURD.gamilonbaseDataSet1TableAdapters.posteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.magasinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Complément adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prénom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(867, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Code postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(822, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Magasin";
            // 
            // nomPersonnel
            // 
            this.nomPersonnel.Location = new System.Drawing.Point(26, 38);
            this.nomPersonnel.Name = "nomPersonnel";
            this.nomPersonnel.Size = new System.Drawing.Size(143, 20);
            this.nomPersonnel.TabIndex = 8;
            // 
            // prenomPersonnel
            // 
            this.prenomPersonnel.Location = new System.Drawing.Point(215, 38);
            this.prenomPersonnel.Name = "prenomPersonnel";
            this.prenomPersonnel.Size = new System.Drawing.Size(138, 20);
            this.prenomPersonnel.TabIndex = 9;
            // 
            // telPersonnel
            // 
            this.telPersonnel.Location = new System.Drawing.Point(427, 38);
            this.telPersonnel.Name = "telPersonnel";
            this.telPersonnel.Size = new System.Drawing.Size(100, 20);
            this.telPersonnel.TabIndex = 10;
            // 
            // magasinPersonnel
            // 
            this.magasinPersonnel.DataSource = this.magasinBindingSource;
            this.magasinPersonnel.DisplayMember = "ville_magasin";
            this.magasinPersonnel.FormattingEnabled = true;
            this.magasinPersonnel.Location = new System.Drawing.Point(825, 38);
            this.magasinPersonnel.Name = "magasinPersonnel";
            this.magasinPersonnel.Size = new System.Drawing.Size(121, 21);
            this.magasinPersonnel.TabIndex = 11;
            this.magasinPersonnel.ValueMember = "id_magasin";
            // 
            // magasinBindingSource
            // 
            this.magasinBindingSource.DataMember = "magasin";
            this.magasinBindingSource.DataSource = this.gamilonbaseDataSet1;
            // 
            // gamilonbaseDataSet1
            // 
            this.gamilonbaseDataSet1.DataSetName = "gamilonbaseDataSet1";
            this.gamilonbaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adr1Personnel
            // 
            this.adr1Personnel.Location = new System.Drawing.Point(22, 180);
            this.adr1Personnel.Name = "adr1Personnel";
            this.adr1Personnel.Size = new System.Drawing.Size(229, 20);
            this.adr1Personnel.TabIndex = 12;
            // 
            // adr2Personnel
            // 
            this.adr2Personnel.Location = new System.Drawing.Point(331, 180);
            this.adr2Personnel.Name = "adr2Personnel";
            this.adr2Personnel.Size = new System.Drawing.Size(222, 20);
            this.adr2Personnel.TabIndex = 13;
            // 
            // villePersonnel
            // 
            this.villePersonnel.Location = new System.Drawing.Point(607, 180);
            this.villePersonnel.Name = "villePersonnel";
            this.villePersonnel.Size = new System.Drawing.Size(210, 20);
            this.villePersonnel.TabIndex = 14;
            // 
            // cpPersonnel
            // 
            this.cpPersonnel.Location = new System.Drawing.Point(870, 180);
            this.cpPersonnel.Name = "cpPersonnel";
            this.cpPersonnel.Size = new System.Drawing.Size(75, 20);
            this.cpPersonnel.TabIndex = 15;
            // 
            // ajouterPersonnel
            // 
            this.ajouterPersonnel.Location = new System.Drawing.Point(441, 239);
            this.ajouterPersonnel.Name = "ajouterPersonnel";
            this.ajouterPersonnel.Size = new System.Drawing.Size(125, 37);
            this.ajouterPersonnel.TabIndex = 16;
            this.ajouterPersonnel.Text = "Ajouter";
            this.ajouterPersonnel.UseVisualStyleBackColor = true;
            this.ajouterPersonnel.Click += new System.EventHandler(this.ajouterPersonnel_Click);
            // 
            // annulerPersonnel
            // 
            this.annulerPersonnel.Location = new System.Drawing.Point(26, 244);
            this.annulerPersonnel.Name = "annulerPersonnel";
            this.annulerPersonnel.Size = new System.Drawing.Size(93, 26);
            this.annulerPersonnel.TabIndex = 17;
            this.annulerPersonnel.Text = "Annuler";
            this.annulerPersonnel.UseVisualStyleBackColor = true;
            // 
            // magasinTableAdapter
            // 
            this.magasinTableAdapter.ClearBeforeFill = true;
            // 
            // date_entree
            // 
            this.date_entree.CustomFormat = "dd-mm-aaaa";
            this.date_entree.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_entree.Location = new System.Drawing.Point(569, 39);
            this.date_entree.Name = "date_entree";
            this.date_entree.Size = new System.Drawing.Size(200, 20);
            this.date_entree.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Date d\'embauche";
            // 
            // postePersonnel
            // 
            this.postePersonnel.DataSource = this.posteBindingSource;
            this.postePersonnel.DisplayMember = "nom_poste";
            this.postePersonnel.FormattingEnabled = true;
            this.postePersonnel.Location = new System.Drawing.Point(215, 103);
            this.postePersonnel.Name = "postePersonnel";
            this.postePersonnel.Size = new System.Drawing.Size(121, 21);
            this.postePersonnel.TabIndex = 20;
            this.postePersonnel.ValueMember = "id_poste";
            // 
            // posteBindingSource
            // 
            this.posteBindingSource.DataMember = "poste";
            this.posteBindingSource.DataSource = this.gamilonbaseDataSet1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Poste";
            // 
            // posteTableAdapter
            // 
            this.posteTableAdapter.ClearBeforeFill = true;
            // 
            // gestionPersonnelAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 303);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.postePersonnel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date_entree);
            this.Controls.Add(this.annulerPersonnel);
            this.Controls.Add(this.ajouterPersonnel);
            this.Controls.Add(this.cpPersonnel);
            this.Controls.Add(this.villePersonnel);
            this.Controls.Add(this.adr2Personnel);
            this.Controls.Add(this.adr1Personnel);
            this.Controls.Add(this.magasinPersonnel);
            this.Controls.Add(this.telPersonnel);
            this.Controls.Add(this.prenomPersonnel);
            this.Controls.Add(this.nomPersonnel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gestionPersonnelAjout";
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.gestionPersonnelAjout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magasinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nomPersonnel;
        private System.Windows.Forms.TextBox prenomPersonnel;
        private System.Windows.Forms.TextBox telPersonnel;
        private System.Windows.Forms.ComboBox magasinPersonnel;
        private System.Windows.Forms.TextBox adr1Personnel;
        private System.Windows.Forms.TextBox adr2Personnel;
        private System.Windows.Forms.TextBox villePersonnel;
        private System.Windows.Forms.TextBox cpPersonnel;
        private System.Windows.Forms.Button ajouterPersonnel;
        private System.Windows.Forms.Button annulerPersonnel;
        private gamilonbaseDataSet1 gamilonbaseDataSet1;
        private System.Windows.Forms.BindingSource magasinBindingSource;
        private gamilonbaseDataSet1TableAdapters.magasinTableAdapter magasinTableAdapter;
        private System.Windows.Forms.DateTimePicker date_entree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox postePersonnel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource posteBindingSource;
        private gamilonbaseDataSet1TableAdapters.posteTableAdapter posteTableAdapter;
    }
}