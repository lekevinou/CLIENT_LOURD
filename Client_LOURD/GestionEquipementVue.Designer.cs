namespace Client_LOURD
{
    partial class btnAjouterEquipement
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
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            this.Nom_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse1_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse2_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_DataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn_refresh_list_view_client = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_rechercheEquipement = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridClient.Location = new System.Drawing.Point(12, 62);
            this.dataGridClient.MultiSelect = false;
            this.dataGridClient.Name = "dataGridClient";
            this.dataGridClient.ReadOnly = true;
            this.dataGridClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClient.Size = new System.Drawing.Size(650, 330);
            this.dataGridClient.TabIndex = 11;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(14, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btn_refresh_list_view_client
            // 
            this.btn_refresh_list_view_client.Location = new System.Drawing.Point(602, 20);
            this.btn_refresh_list_view_client.Name = "btn_refresh_list_view_client";
            this.btn_refresh_list_view_client.Size = new System.Drawing.Size(103, 23);
            this.btn_refresh_list_view_client.TabIndex = 16;
            this.btn_refresh_list_view_client.Text = "Rafraichir la liste";
            this.btn_refresh_list_view_client.UseVisualStyleBackColor = true;
            this.btn_refresh_list_view_client.Click += new System.EventHandler(this.btn_refresh_list_view_client_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recherche équipement";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_rechercheEquipement
            // 
            this.text_rechercheEquipement.Location = new System.Drawing.Point(296, 22);
            this.text_rechercheEquipement.Name = "text_rechercheEquipement";
            this.text_rechercheEquipement.Size = new System.Drawing.Size(100, 20);
            this.text_rechercheEquipement.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ajouter un équipement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(402, 19);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 18;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnAjouterEquipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 404);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_refresh_list_view_client);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_rechercheEquipement);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridClient);
            this.Name = "btnAjouterEquipement";
            this.Text = "GestionEquipementVue";
            this.Load += new System.EventHandler(this.GestionEquipementVue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse1_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse2_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_DataGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn_refresh_list_view_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_rechercheEquipement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRecherche;
    }
}