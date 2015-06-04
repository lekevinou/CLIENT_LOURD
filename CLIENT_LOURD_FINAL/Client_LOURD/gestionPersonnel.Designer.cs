namespace Client_LOURD
{
    partial class gestionPersonnel
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
            this.btn_recherche = new System.Windows.Forms.Button();
            this.recherche = new System.Windows.Forms.TextBox();
            this.addPersonnel = new System.Windows.Forms.Button();
            this.dataGridPersonnel = new System.Windows.Forms.DataGridView();
            this.id_personnel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_personnel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom_personnel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_magasin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affiche = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(153, 104);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(75, 23);
            this.btn_recherche.TabIndex = 8;
            this.btn_recherche.Text = "Rechercher";
            this.btn_recherche.UseVisualStyleBackColor = true;
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(12, 107);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(119, 20);
            this.recherche.TabIndex = 7;
            // 
            // addPersonnel
            // 
            this.addPersonnel.Location = new System.Drawing.Point(54, 20);
            this.addPersonnel.Name = "addPersonnel";
            this.addPersonnel.Size = new System.Drawing.Size(156, 43);
            this.addPersonnel.TabIndex = 6;
            this.addPersonnel.Text = "Ajouter un employé";
            this.addPersonnel.UseMnemonic = false;
            this.addPersonnel.UseVisualStyleBackColor = true;
            this.addPersonnel.Click += new System.EventHandler(this.addPersonnel_Click);
            // 
            // dataGridPersonnel
            // 
            this.dataGridPersonnel.AllowUserToAddRows = false;
            this.dataGridPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_personnel,
            this.nom_personnel,
            this.prenom_personnel,
            this.id_magasin,
            this.affiche});
            this.dataGridPersonnel.Location = new System.Drawing.Point(283, 20);
            this.dataGridPersonnel.Name = "dataGridPersonnel";
            this.dataGridPersonnel.Size = new System.Drawing.Size(445, 220);
            this.dataGridPersonnel.TabIndex = 5;
            this.dataGridPersonnel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPersonnel_CellContentClick);
            // 
            // id_personnel
            // 
            this.id_personnel.HeaderText = "id personnel";
            this.id_personnel.Name = "id_personnel";
            this.id_personnel.Visible = false;
            // 
            // nom_personnel
            // 
            this.nom_personnel.HeaderText = "nom";
            this.nom_personnel.Name = "nom_personnel";
            // 
            // prenom_personnel
            // 
            this.prenom_personnel.HeaderText = "prenom";
            this.prenom_personnel.Name = "prenom_personnel";
            // 
            // id_magasin
            // 
            this.id_magasin.HeaderText = "Ville magasin";
            this.id_magasin.Name = "id_magasin";
            // 
            // affiche
            // 
            this.affiche.HeaderText = "Afficher";
            this.affiche.Name = "affiche";
            this.affiche.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.affiche.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 267);
            this.Controls.Add(this.btn_recherche);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.addPersonnel);
            this.Controls.Add(this.dataGridPersonnel);
            this.Name = "gestionPersonnel";
            this.Text = "gestionPersonnel";
            this.Load += new System.EventHandler(this.gestionPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.Button addPersonnel;
        private System.Windows.Forms.DataGridView dataGridPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_personnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_personnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom_personnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_magasin;
        private System.Windows.Forms.DataGridViewButtonColumn affiche;
    }
}