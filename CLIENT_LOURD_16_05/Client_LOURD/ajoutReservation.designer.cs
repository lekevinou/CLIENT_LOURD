namespace Client_LOURD
{
    partial class ajoutReservation
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
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamilonbaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamilonbaseDataSet1 = new Client_LOURD.gamilonbaseDataSet1();
            this.btn_recherche_nom = new System.Windows.Forms.Button();
            this.textBox_recherche_nom = new System.Windows.Forms.TextBox();
            this.Gridview_Client = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSalle = new System.Windows.Forms.ComboBox();
            this.sallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sallesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sallesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_jour = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_heure_debut = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_heure_fin = new System.Windows.Forms.DateTimePicker();
            this.btn_ajouter_reservation = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Client_LOURD.gamilonbaseDataSet1TableAdapters.clientTableAdapter();
            this.sallesTableAdapter = new Client_LOURD.gamilonbaseDataSet1TableAdapters.sallesTableAdapter();
            this.sallesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sallesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(137, 22);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.ReadOnly = true;
            this.textBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nom.TabIndex = 0;
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.Location = new System.Drawing.Point(137, 48);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.ReadOnly = true;
            this.textBox_Prenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prenom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom :";
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "client";
            this.clientBindingSource1.DataSource = this.gamilonbaseDataSet1BindingSource;
            // 
            // gamilonbaseDataSet1BindingSource
            // 
            this.gamilonbaseDataSet1BindingSource.DataSource = this.gamilonbaseDataSet1;
            this.gamilonbaseDataSet1BindingSource.Position = 0;
            // 
            // gamilonbaseDataSet1
            // 
            this.gamilonbaseDataSet1.DataSetName = "gamilonbaseDataSet1";
            this.gamilonbaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_recherche_nom
            // 
            this.btn_recherche_nom.Location = new System.Drawing.Point(373, 18);
            this.btn_recherche_nom.Name = "btn_recherche_nom";
            this.btn_recherche_nom.Size = new System.Drawing.Size(121, 23);
            this.btn_recherche_nom.TabIndex = 6;
            this.btn_recherche_nom.Text = "Rechercher ce nom";
            this.btn_recherche_nom.UseVisualStyleBackColor = true;
            this.btn_recherche_nom.Click += new System.EventHandler(this.btn_recherche_nom_Click_1);
            // 
            // textBox_recherche_nom
            // 
            this.textBox_recherche_nom.Location = new System.Drawing.Point(373, 68);
            this.textBox_recherche_nom.Name = "textBox_recherche_nom";
            this.textBox_recherche_nom.Size = new System.Drawing.Size(138, 20);
            this.textBox_recherche_nom.TabIndex = 7;
            // 
            // Gridview_Client
            // 
            this.Gridview_Client.AllowUserToAddRows = false;
            this.Gridview_Client.AllowUserToDeleteRows = false;
            this.Gridview_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nom_DataGridView,
            this.Prenom_DataGridView});
            this.Gridview_Client.Location = new System.Drawing.Point(527, 21);
            this.Gridview_Client.MultiSelect = false;
            this.Gridview_Client.Name = "Gridview_Client";
            this.Gridview_Client.ReadOnly = true;
            this.Gridview_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridview_Client.Size = new System.Drawing.Size(255, 325);
            this.Gridview_Client.TabIndex = 11;
            this.Gridview_Client.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview_Client_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "id_client";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nom_DataGridView
            // 
            this.Nom_DataGridView.HeaderText = "Nom";
            this.Nom_DataGridView.Name = "Nom_DataGridView";
            this.Nom_DataGridView.ReadOnly = true;
            // 
            // Prenom_DataGridView
            // 
            this.Prenom_DataGridView.HeaderText = "Prenom";
            this.Prenom_DataGridView.Name = "Prenom_DataGridView";
            this.Prenom_DataGridView.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salle :";
            // 
            // cbSalle
            // 
            this.cbSalle.DataSource = this.sallesBindingSource1;
            this.cbSalle.DisplayMember = "libelle_salle";
            this.cbSalle.FormattingEnabled = true;
            this.cbSalle.Location = new System.Drawing.Point(137, 76);
            this.cbSalle.Name = "cbSalle";
            this.cbSalle.Size = new System.Drawing.Size(100, 21);
            this.cbSalle.TabIndex = 13;
            this.cbSalle.ValueMember = "id_salle";
            // 
            // sallesBindingSource
            // 
            this.sallesBindingSource.DataMember = "salles";
            this.sallesBindingSource.DataSource = this.gamilonbaseDataSet1BindingSource;
            // 
            // sallesBindingSource1
            // 
            this.sallesBindingSource1.DataMember = "salles";
            this.sallesBindingSource1.DataSource = this.gamilonbaseDataSet1BindingSource;
            // 
            // sallesBindingSource2
            // 
            this.sallesBindingSource2.DataMember = "salles";
            this.sallesBindingSource2.DataSource = this.gamilonbaseDataSet1BindingSource;
            // 
            // dateTimePicker_jour
            // 
            this.dateTimePicker_jour.CustomFormat = "";
            this.dateTimePicker_jour.Location = new System.Drawing.Point(137, 103);
            this.dateTimePicker_jour.Name = "dateTimePicker_jour";
            this.dateTimePicker_jour.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_jour.TabIndex = 14;
            // 
            // dateTimePicker_heure_debut
            // 
            this.dateTimePicker_heure_debut.CustomFormat = "HH:mm";
            this.dateTimePicker_heure_debut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_heure_debut.Location = new System.Drawing.Point(137, 129);
            this.dateTimePicker_heure_debut.Name = "dateTimePicker_heure_debut";
            this.dateTimePicker_heure_debut.ShowUpDown = true;
            this.dateTimePicker_heure_debut.Size = new System.Drawing.Size(55, 20);
            this.dateTimePicker_heure_debut.TabIndex = 15;
            this.dateTimePicker_heure_debut.Value = new System.DateTime(2015, 5, 15, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Heure de début :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Heure de fin :";
            // 
            // dateTimePicker_heure_fin
            // 
            this.dateTimePicker_heure_fin.CustomFormat = "HH:mm";
            this.dateTimePicker_heure_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_heure_fin.Location = new System.Drawing.Point(137, 157);
            this.dateTimePicker_heure_fin.Name = "dateTimePicker_heure_fin";
            this.dateTimePicker_heure_fin.ShowUpDown = true;
            this.dateTimePicker_heure_fin.Size = new System.Drawing.Size(55, 20);
            this.dateTimePicker_heure_fin.TabIndex = 18;
            this.dateTimePicker_heure_fin.Value = new System.DateTime(2015, 5, 15, 0, 0, 0, 0);
            // 
            // btn_ajouter_reservation
            // 
            this.btn_ajouter_reservation.Location = new System.Drawing.Point(639, 387);
            this.btn_ajouter_reservation.Name = "btn_ajouter_reservation";
            this.btn_ajouter_reservation.Size = new System.Drawing.Size(114, 23);
            this.btn_ajouter_reservation.TabIndex = 20;
            this.btn_ajouter_reservation.Text = "Ajouter Réservation";
            this.btn_ajouter_reservation.UseVisualStyleBackColor = true;
            this.btn_ajouter_reservation.Click += new System.EventHandler(this.btn_ajouter_reservation_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.gamilonbaseDataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // sallesTableAdapter
            // 
            this.sallesTableAdapter.ClearBeforeFill = true;
            // 
            // sallesBindingSource3
            // 
            this.sallesBindingSource3.DataMember = "salles";
            this.sallesBindingSource3.DataSource = this.gamilonbaseDataSet1;
            // 
            // sallesBindingSource4
            // 
            this.sallesBindingSource4.DataMember = "salles";
            this.sallesBindingSource4.DataSource = this.gamilonbaseDataSet1BindingSource;
            // 
            // ajoutReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 486);
            this.Controls.Add(this.btn_ajouter_reservation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_heure_fin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_heure_debut);
            this.Controls.Add(this.dateTimePicker_jour);
            this.Controls.Add(this.cbSalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gridview_Client);
            this.Controls.Add(this.textBox_recherche_nom);
            this.Controls.Add(this.btn_recherche_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Prenom);
            this.Controls.Add(this.textBox_Nom);
            this.Name = "ajoutReservation";
            this.Text = "Ajouter une Réservation";
            this.Load += new System.EventHandler(this.AjoutReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sallesBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gamilonbaseDataSet1BindingSource;
        private gamilonbaseDataSet1 gamilonbaseDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private gamilonbaseDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.Button btn_recherche_nom;
        private System.Windows.Forms.TextBox textBox_recherche_nom;
        private System.Windows.Forms.DataGridView Gridview_Client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSalle;
        private System.Windows.Forms.BindingSource sallesBindingSource;
        private gamilonbaseDataSet1TableAdapters.sallesTableAdapter sallesTableAdapter;
        private System.Windows.Forms.BindingSource sallesBindingSource1;
        private System.Windows.Forms.BindingSource sallesBindingSource2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_jour;
        private System.Windows.Forms.DateTimePicker dateTimePicker_heure_debut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_heure_fin;
        private System.Windows.Forms.Button btn_ajouter_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom_DataGridView;
        private System.Windows.Forms.BindingSource sallesBindingSource3;
        private System.Windows.Forms.BindingSource sallesBindingSource4;
    }
}