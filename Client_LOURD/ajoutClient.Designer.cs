namespace Client_LOURD
{
    partial class ajoutClient
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
            this.SuspendLayout();
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(218, 227);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(75, 23);
            this.quitter.TabIndex = 0;
            this.quitter.Text = "Retour";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // prenom_client
            // 
            this.prenom_client.AutoSize = true;
            this.prenom_client.Location = new System.Drawing.Point(12, 29);
            this.prenom_client.Name = "prenom_client";
            this.prenom_client.Size = new System.Drawing.Size(43, 13);
            this.prenom_client.TabIndex = 1;
            this.prenom_client.Text = "Prénom";
            // 
            // nom_client
            // 
            this.nom_client.AutoSize = true;
            this.nom_client.Location = new System.Drawing.Point(12, 57);
            this.nom_client.Name = "nom_client";
            this.nom_client.Size = new System.Drawing.Size(29, 13);
            this.nom_client.TabIndex = 2;
            this.nom_client.Text = "Nom";
            // 
            // adresse1_client
            // 
            this.adresse1_client.AutoSize = true;
            this.adresse1_client.Location = new System.Drawing.Point(12, 85);
            this.adresse1_client.Name = "adresse1_client";
            this.adresse1_client.Size = new System.Drawing.Size(54, 13);
            this.adresse1_client.TabIndex = 3;
            this.adresse1_client.Text = "Adresse 1";
            // 
            // adresse2_client
            // 
            this.adresse2_client.AutoSize = true;
            this.adresse2_client.Location = new System.Drawing.Point(12, 113);
            this.adresse2_client.Name = "adresse2_client";
            this.adresse2_client.Size = new System.Drawing.Size(112, 13);
            this.adresse2_client.TabIndex = 4;
            this.adresse2_client.Text = "Adresse 2 (facultative)";
            // 
            // tel_client
            // 
            this.tel_client.AutoSize = true;
            this.tel_client.Location = new System.Drawing.Point(12, 141);
            this.tel_client.Name = "tel_client";
            this.tel_client.Size = new System.Drawing.Size(58, 13);
            this.tel_client.TabIndex = 5;
            this.tel_client.Text = "Telephone";
            // 
            // prenomClient
            // 
            this.prenomClient.Location = new System.Drawing.Point(129, 26);
            this.prenomClient.Name = "prenomClient";
            this.prenomClient.Size = new System.Drawing.Size(164, 20);
            this.prenomClient.TabIndex = 6;
            // 
            // nomClient
            // 
            this.nomClient.Location = new System.Drawing.Point(129, 56);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(164, 20);
            this.nomClient.TabIndex = 7;
            // 
            // adr1Client
            // 
            this.adr1Client.Location = new System.Drawing.Point(129, 86);
            this.adr1Client.Name = "adr1Client";
            this.adr1Client.Size = new System.Drawing.Size(164, 20);
            this.adr1Client.TabIndex = 8;
            // 
            // adr2Client
            // 
            this.adr2Client.Location = new System.Drawing.Point(129, 116);
            this.adr2Client.Name = "adr2Client";
            this.adr2Client.Size = new System.Drawing.Size(164, 20);
            this.adr2Client.TabIndex = 9;
            // 
            // telClient
            // 
            this.telClient.Location = new System.Drawing.Point(129, 146);
            this.telClient.Name = "telClient";
            this.telClient.Size = new System.Drawing.Size(164, 20);
            this.telClient.TabIndex = 10;
            // 
            // mailClient
            // 
            this.mailClient.Location = new System.Drawing.Point(129, 176);
            this.mailClient.Name = "mailClient";
            this.mailClient.Size = new System.Drawing.Size(164, 20);
            this.mailClient.TabIndex = 11;
            // 
            // mail_client
            // 
            this.mail_client.AutoSize = true;
            this.mail_client.Location = new System.Drawing.Point(12, 176);
            this.mail_client.Name = "mail_client";
            this.mail_client.Size = new System.Drawing.Size(66, 13);
            this.mail_client.TabIndex = 12;
            this.mail_client.Text = "Adresse mail";
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(129, 227);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 13;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // ajoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(336, 262);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ajoutClient";
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
    }
}

