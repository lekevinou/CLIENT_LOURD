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
<<<<<<< HEAD
            this.cp_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_erreur_cp = new System.Windows.Forms.Label();
            this.ville_txt = new System.Windows.Forms.TextBox();
            this.gamilonbaseDataSet1 = new Client_LOURD.gamilonbaseDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).BeginInit();
=======
            this.btn_VoirClients = new System.Windows.Forms.Button();
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            this.SuspendLayout();
            // 
            // quitter
            // 
<<<<<<< HEAD
            this.quitter.Location = new System.Drawing.Point(218, 288);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(75, 23);
            this.quitter.TabIndex = 15;
=======
            this.quitter.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.quitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quitter.Location = new System.Drawing.Point(254, 249);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(87, 23);
            this.quitter.TabIndex = 0;
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
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
<<<<<<< HEAD
            this.nom_client.Location = new System.Drawing.Point(12, 61);
=======
            this.nom_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_client.Location = new System.Drawing.Point(14, 57);
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            this.nom_client.Name = "nom_client";
            this.nom_client.Size = new System.Drawing.Size(32, 13);
            this.nom_client.TabIndex = 2;
            this.nom_client.Text = "Nom";
            // 
            // adresse1_client
            // 
            this.adresse1_client.AutoSize = true;
<<<<<<< HEAD
            this.adresse1_client.Location = new System.Drawing.Point(12, 93);
=======
            this.adresse1_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresse1_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresse1_client.Location = new System.Drawing.Point(14, 85);
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            this.adresse1_client.Name = "adresse1_client";
            this.adresse1_client.Size = new System.Drawing.Size(63, 13);
            this.adresse1_client.TabIndex = 3;
            this.adresse1_client.Text = "Adresse 1";
            // 
            // adresse2_client
            // 
            this.adresse2_client.AutoSize = true;
<<<<<<< HEAD
            this.adresse2_client.Location = new System.Drawing.Point(12, 189);
=======
            this.adresse2_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresse2_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresse2_client.Location = new System.Drawing.Point(14, 113);
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            this.adresse2_client.Name = "adresse2_client";
            this.adresse2_client.Size = new System.Drawing.Size(135, 13);
            this.adresse2_client.TabIndex = 4;
            this.adresse2_client.Text = "Adresse 2 (facultative)";
            // 
            // tel_client
            // 
            this.tel_client.AutoSize = true;
<<<<<<< HEAD
            this.tel_client.Location = new System.Drawing.Point(12, 221);
=======
            this.tel_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tel_client.Location = new System.Drawing.Point(14, 141);
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
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
<<<<<<< HEAD
            this.nomClient.Location = new System.Drawing.Point(129, 58);
=======
            this.nomClient.Location = new System.Drawing.Point(150, 56);
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(191, 20);
            this.nomClient.TabIndex = 7;
            // 
            // adr1Client
            // 
<<<<<<< HEAD
            this.adr1Client.Location = new System.Drawing.Point(129, 90);
=======
            this.adr1Client.Location = new System.Drawing.Point(150, 86);
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            this.adr1Client.Name = "adr1Client";
            this.adr1Client.Size = new System.Drawing.Size(191, 20);
            this.adr1Client.TabIndex = 8;
            // 
            // adr2Client
            // 
<<<<<<< HEAD
            this.adr2Client.Location = new System.Drawing.Point(129, 187);
            this.adr2Client.Name = "adr2Client";
            this.adr2Client.Size = new System.Drawing.Size(164, 20);
            this.adr2Client.TabIndex = 11;
            // 
            // telClient
            // 
            this.telClient.Location = new System.Drawing.Point(129, 219);
            this.telClient.Name = "telClient";
            this.telClient.Size = new System.Drawing.Size(164, 20);
            this.telClient.TabIndex = 12;
            // 
            // mailClient
            // 
            this.mailClient.Location = new System.Drawing.Point(129, 251);
            this.mailClient.Name = "mailClient";
            this.mailClient.Size = new System.Drawing.Size(164, 20);
            this.mailClient.TabIndex = 13;
=======
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
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            // 
            // mail_client
            // 
            this.mail_client.AutoSize = true;
<<<<<<< HEAD
            this.mail_client.Location = new System.Drawing.Point(12, 253);
=======
            this.mail_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mail_client.Location = new System.Drawing.Point(14, 176);
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            this.mail_client.Name = "mail_client";
            this.mail_client.Size = new System.Drawing.Size(78, 13);
            this.mail_client.TabIndex = 12;
            this.mail_client.Text = "Adresse mail";
            // 
            // ajouter
            // 
<<<<<<< HEAD
            this.ajouter.Location = new System.Drawing.Point(129, 288);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 14;
=======
            this.ajouter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ajouter.Location = new System.Drawing.Point(254, 224);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(87, 23);
            this.ajouter.TabIndex = 13;
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
<<<<<<< HEAD
            // cp_txtBox
            // 
            this.cp_txtBox.Location = new System.Drawing.Point(129, 122);
            this.cp_txtBox.Name = "cp_txtBox";
            this.cp_txtBox.Size = new System.Drawing.Size(164, 20);
            this.cp_txtBox.TabIndex = 9;
            this.cp_txtBox.TextChanged += new System.EventHandler(this.cp_txtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "CP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ville";
            // 
            // label_erreur_cp
            // 
            this.label_erreur_cp.AutoSize = true;
            this.label_erreur_cp.ForeColor = System.Drawing.Color.Red;
            this.label_erreur_cp.Location = new System.Drawing.Point(299, 125);
            this.label_erreur_cp.Name = "label_erreur_cp";
            this.label_erreur_cp.Size = new System.Drawing.Size(115, 13);
            this.label_erreur_cp.TabIndex = 18;
            this.label_erreur_cp.Text = "Code postal non valide";
            this.label_erreur_cp.Visible = false;
            // 
            // ville_txt
            // 
            this.ville_txt.Location = new System.Drawing.Point(129, 157);
            this.ville_txt.Name = "ville_txt";
            this.ville_txt.Size = new System.Drawing.Size(164, 20);
            this.ville_txt.TabIndex = 19;
            // 
            // gamilonbaseDataSet1
            // 
            this.gamilonbaseDataSet1.DataSetName = "gamilonbaseDataSet1";
            this.gamilonbaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionClientAjout
=======
            // btn_VoirClients
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
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
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(432, 381);
            this.Controls.Add(this.ville_txt);
            this.Controls.Add(this.label_erreur_cp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cp_txtBox);
=======
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(357, 287);
            this.Controls.Add(this.btn_VoirClients);
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
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
<<<<<<< HEAD
            this.ForeColor = System.Drawing.SystemColors.ControlText;
=======
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            this.Name = "gestionClientAjout";
            this.Text = "Ajouter un client";
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).EndInit();
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
<<<<<<< HEAD
        private System.Windows.Forms.TextBox cp_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_erreur_cp;
        private System.Windows.Forms.TextBox ville_txt;
        private gamilonbaseDataSet1 gamilonbaseDataSet1;
=======
        private System.Windows.Forms.Button btn_VoirClients;
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
    }
}

