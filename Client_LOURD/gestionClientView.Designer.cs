namespace Client_LOURD
{
    partial class gestionClientView
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
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamilonbaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamilonbaseDataSet1 = new Client_LOURD.gamilonbaseDataSet1();
            this.clientTableAdapter = new Client_LOURD.gamilonbaseDataSet1TableAdapters.clientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.text_rechercheClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_valider_recherche = new System.Windows.Forms.Button();
            this.btn_refresh_list_view_client = new System.Windows.Forms.Button();
            this.back_fromViewClient = new System.Windows.Forms.Button();
            this.modif_listeClients = new System.Windows.Forms.Button();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            this.Nom_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse1_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse2_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.gamilonbaseDataSet1BindingSource;
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
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter un client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_rechercheClient
            // 
            this.text_rechercheClient.Location = new System.Drawing.Point(355, 16);
            this.text_rechercheClient.Name = "text_rechercheClient";
            this.text_rechercheClient.Size = new System.Drawing.Size(100, 20);
            this.text_rechercheClient.TabIndex = 3;
            this.text_rechercheClient.TextChanged += new System.EventHandler(this.text_rechercheClient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recherche client";
            // 
            // btn_valider_recherche
            // 
            this.btn_valider_recherche.Location = new System.Drawing.Point(461, 14);
            this.btn_valider_recherche.Name = "btn_valider_recherche";
            this.btn_valider_recherche.Size = new System.Drawing.Size(75, 23);
            this.btn_valider_recherche.TabIndex = 5;
            this.btn_valider_recherche.Text = "Rechercher";
            this.btn_valider_recherche.UseVisualStyleBackColor = true;
            this.btn_valider_recherche.Click += new System.EventHandler(this.btn_valider_recherche_Click);
            // 
            // btn_refresh_list_view_client
            // 
            this.btn_refresh_list_view_client.Location = new System.Drawing.Point(600, 14);
            this.btn_refresh_list_view_client.Name = "btn_refresh_list_view_client";
            this.btn_refresh_list_view_client.Size = new System.Drawing.Size(103, 23);
            this.btn_refresh_list_view_client.TabIndex = 6;
            this.btn_refresh_list_view_client.Text = "Rafraichir la liste";
            this.btn_refresh_list_view_client.UseVisualStyleBackColor = true;
            this.btn_refresh_list_view_client.Click += new System.EventHandler(this.btn_refresh_list_view_client_Click);
            // 
            // back_fromViewClient
            // 
            this.back_fromViewClient.Location = new System.Drawing.Point(12, 14);
            this.back_fromViewClient.Name = "back_fromViewClient";
            this.back_fromViewClient.Size = new System.Drawing.Size(75, 23);
            this.back_fromViewClient.TabIndex = 7;
            this.back_fromViewClient.Text = "Retour";
            this.back_fromViewClient.UseVisualStyleBackColor = true;
            this.back_fromViewClient.Click += new System.EventHandler(this.back_fromViewClient_Click);
            // 
            // modif_listeClients
            // 
            this.modif_listeClients.Location = new System.Drawing.Point(710, 413);
            this.modif_listeClients.Name = "modif_listeClients";
            this.modif_listeClients.Size = new System.Drawing.Size(75, 23);
            this.modif_listeClients.TabIndex = 8;
            this.modif_listeClients.Text = "Modifier";
            this.modif_listeClients.UseVisualStyleBackColor = true;
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(600, 415);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(100, 20);
            this.testTextBox.TabIndex = 9;
            // 
            // dataGridClient
            // 
            this.dataGridClient.AllowUserToAddRows = false;
            this.dataGridClient.AllowUserToDeleteRows = false;
            this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom_DataGridView,
            this.Prenom_DataGridView,
            this.Adresse1_DataGridView,
            this.Adresse2_DataGridView,
            this.Tel_DataGridView,
            this.Mail_DataGridView});
            this.dataGridClient.Location = new System.Drawing.Point(12, 56);
            this.dataGridClient.MultiSelect = false;
            this.dataGridClient.Name = "dataGridClient";
            this.dataGridClient.ReadOnly = true;
            this.dataGridClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClient.Size = new System.Drawing.Size(650, 330);
            this.dataGridClient.TabIndex = 10;
            this.dataGridClient.DoubleClick += new System.EventHandler(this.dataGridClient_DoubleClick);
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
            // Adresse1_DataGridView
            // 
            this.Adresse1_DataGridView.HeaderText = "Adresse1";
            this.Adresse1_DataGridView.Name = "Adresse1_DataGridView";
            this.Adresse1_DataGridView.ReadOnly = true;
            // 
            // Adresse2_DataGridView
            // 
            this.Adresse2_DataGridView.HeaderText = "Adresse2";
            this.Adresse2_DataGridView.Name = "Adresse2_DataGridView";
            this.Adresse2_DataGridView.ReadOnly = true;
            // 
            // Tel_DataGridView
            // 
            this.Tel_DataGridView.HeaderText = "Telephone";
            this.Tel_DataGridView.Name = "Tel_DataGridView";
            this.Tel_DataGridView.ReadOnly = true;
            // 
            // Mail_DataGridView
            // 
            this.Mail_DataGridView.HeaderText = "Mail";
            this.Mail_DataGridView.Name = "Mail_DataGridView";
            this.Mail_DataGridView.ReadOnly = true;
            // 
            // gestionClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.dataGridClient);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.modif_listeClients);
            this.Controls.Add(this.back_fromViewClient);
            this.Controls.Add(this.btn_refresh_list_view_client);
            this.Controls.Add(this.btn_valider_recherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_rechercheClient);
            this.Controls.Add(this.button1);
            this.Name = "gestionClientView";
            this.Text = "Visualisation des clients";
            this.Load += new System.EventHandler(this.viewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gamilonbaseDataSet1BindingSource;
        private gamilonbaseDataSet1 gamilonbaseDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private gamilonbaseDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_rechercheClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_valider_recherche;
        private System.Windows.Forms.Button btn_refresh_list_view_client;
        private System.Windows.Forms.Button back_fromViewClient;
        private System.Windows.Forms.Button modif_listeClients;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.DataGridView dataGridClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse1_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse2_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_DataGridView;
    }
}