namespace Client_LOURD
{
    partial class gestionClientAjout
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.quitter = new System.Windows.Forms.Button();
            this.prenom_client = new System.Windows.Forms.Label();
            this.nom_client = new System.Windows.Forms.Label();
            this.adresse1_client = new System.Windows.Forms.Label();
            this.adresse2_client = new System.Windows.Forms.Label();
            this.tel_client = new System.Windows.Forms.Label();
            this.prenomClient = new System.Windows.Forms.TextBox();
            this.nomClient = new System.Windows.Forms.TextBox();
            this.adr1Client = new System.Windows.Forms.TextBox();
            this.adr2Client = new System.Windows.Forms.TextBox();
            this.telClient = new System.Windows.Forms.TextBox();
            this.mailClient = new System.Windows.Forms.TextBox();
            this.mail_client = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.btn_VoirClients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitter
            // 
            this.quitter.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.quitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quitter.Location = new System.Drawing.Point(254, 249);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(87, 23);
            this.quitter.TabIndex = 0;
            this.quitter.Text = "Retour";
            this.quitter.UseVisualStyleBackColor = false;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // prenom_client
            // 
            this.prenom_client.AutoSize = true;
            this.prenom_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prenom_client.Location = new System.Drawing.Point(14, 29);
            this.prenom_client.Name = "prenom_client";
            this.prenom_client.Size = new System.Drawing.Size(49, 13);
            this.prenom_client.TabIndex = 1;
            this.prenom_client.Text = "Prénom";
            // 
            // nom_client
            // 
            this.nom_client.AutoSize = true;
            this.nom_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_client.Location = new System.Drawing.Point(14, 57);
            this.nom_client.Name = "nom_client";
            this.nom_client.Size = new System.Drawing.Size(32, 13);
            this.nom_client.TabIndex = 2;
            this.nom_client.Text = "Nom";
            // 
            // adresse1_client
            // 
            this.adresse1_client.AutoSize = true;
            this.adresse1_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresse1_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresse1_client.Location = new System.Drawing.Point(14, 85);
            this.adresse1_client.Name = "adresse1_client";
            this.adresse1_client.Size = new System.Drawing.Size(63, 13);
            this.adresse1_client.TabIndex = 3;
            this.adresse1_client.Text = "Adresse 1";
            // 
            // adresse2_client
            // 
            this.adresse2_client.AutoSize = true;
            this.adresse2_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresse2_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresse2_client.Location = new System.Drawing.Point(14, 113);
            this.adresse2_client.Name = "adresse2_client";
            this.adresse2_client.Size = new System.Drawing.Size(135, 13);
            this.adresse2_client.TabIndex = 4;
            this.adresse2_client.Text = "Adresse 2 (facultative)";
            // 
            // tel_client
            // 
            this.tel_client.AutoSize = true;
            this.tel_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tel_client.Location = new System.Drawing.Point(14, 141);
            this.tel_client.Name = "tel_client";
            this.tel_client.Size = new System.Drawing.Size(67, 13);
            this.tel_client.TabIndex = 5;
            this.tel_client.Text = "Telephone";
            // 
            // prenomClient
            // 
            this.prenomClient.Location = new System.Drawing.Point(150, 26);
            this.prenomClient.Name = "prenomClient";
            this.prenomClient.Size = new System.Drawing.Size(191, 20);
            this.prenomClient.TabIndex = 6;
            // 
            // nomClient
            // 
            this.nomClient.Location = new System.Drawing.Point(150, 56);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(191, 20);
            this.nomClient.TabIndex = 7;
            // 
            // adr1Client
            // 
            this.adr1Client.Location = new System.Drawing.Point(150, 86);
            this.adr1Client.Name = "adr1Client";
            this.adr1Client.Size = new System.Drawing.Size(191, 20);
            this.adr1Client.TabIndex = 8;
            // 
            // adr2Client
            // 
            this.adr2Client.Location = new System.Drawing.Point(150, 116);
            this.adr2Client.Name = "adr2Client";
            this.adr2Client.Size = new System.Drawing.Size(191, 20);
            this.adr2Client.TabIndex = 9;
            // 
            // telClient
            // 
            this.telClient.Location = new System.Drawing.Point(150, 146);
            this.telClient.Name = "telClient";
            this.telClient.Size = new System.Drawing.Size(191, 20);
            this.telClient.TabIndex = 10;
            // 
            // mailClient
            // 
            this.mailClient.Location = new System.Drawing.Point(150, 176);
            this.mailClient.Name = "mailClient";
            this.mailClient.Size = new System.Drawing.Size(191, 20);
            this.mailClient.TabIndex = 11;
            // 
            // mail_client
            // 
            this.mail_client.AutoSize = true;
            this.mail_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mail_client.Location = new System.Drawing.Point(14, 176);
            this.mail_client.Name = "mail_client";
            this.mail_client.Size = new System.Drawing.Size(78, 13);
            this.mail_client.TabIndex = 12;
            this.mail_client.Text = "Adresse mail";
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ajouter.Location = new System.Drawing.Point(254, 224);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(87, 23);
            this.ajouter.TabIndex = 13;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // btn_VoirClients
            // 
            this.btn_VoirClients.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_VoirClients.Location = new System.Drawing.Point(150, 224);
            this.btn_VoirClients.Name = "btn_VoirClients";
            this.btn_VoirClients.Size = new System.Drawing.Size(89, 48);
            this.btn_VoirClients.TabIndex = 14;
            this.btn_VoirClients.Text = "Voir les clients";
            this.btn_VoirClients.UseVisualStyleBackColor = false;
            this.btn_VoirClients.Click += new System.EventHandler(this.btn_VoirClients_Click);
            // 
            // gestionClientAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(357, 287);
            this.Controls.Add(this.btn_VoirClients);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.mail_client);
            this.Controls.Add(this.mailClient);
            this.Controls.Add(this.telClient);
            this.Controls.Add(this.adr2Client);
            this.Controls.Add(this.adr1Client);
            this.Controls.Add(this.nomClient);
            this.Controls.Add(this.prenomClient);
            this.Controls.Add(this.tel_client);
            this.Controls.Add(this.adresse2_client);
            this.Controls.Add(this.adresse1_client);
            this.Controls.Add(this.nom_client);
            this.Controls.Add(this.prenom_client);
            this.Controls.Add(this.quitter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "gestionClientAjout";
            this.Text = "Ajouter un client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Label prenom_client;
        private System.Windows.Forms.Label nom_client;
        private System.Windows.Forms.Label adresse1_client;
        private System.Windows.Forms.Label adresse2_client;
        private System.Windows.Forms.Label tel_client;
        private System.Windows.Forms.TextBox prenomClient;
        private System.Windows.Forms.TextBox nomClient;
        private System.Windows.Forms.TextBox adr1Client;
        private System.Windows.Forms.TextBox adr2Client;
        private System.Windows.Forms.TextBox telClient;
        private System.Windows.Forms.TextBox mailClient;
        private System.Windows.Forms.Label mail_client;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button btn_VoirClients;
    }
}

