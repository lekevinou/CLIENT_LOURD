namespace Client_LOURD
{
    partial class GestionEquipementAjout
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
            this.voirEquipement = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.reference = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.textBoxMarque = new System.Windows.Forms.TextBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voirEquipement
            // 
            this.voirEquipement.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.voirEquipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voirEquipement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.voirEquipement.Location = new System.Drawing.Point(33, 177);
            this.voirEquipement.Name = "voirEquipement";
            this.voirEquipement.Size = new System.Drawing.Size(88, 37);
            this.voirEquipement.TabIndex = 39;
            this.voirEquipement.Text = "Voir les équipements";
            this.voirEquipement.UseVisualStyleBackColor = false;
            this.voirEquipement.Click += new System.EventHandler(this.voirEquipement_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(49, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Type";
            // 
            // reference
            // 
            this.reference.AutoSize = true;
            this.reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reference.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reference.Location = new System.Drawing.Point(49, 114);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(66, 13);
            this.reference.TabIndex = 37;
            this.reference.Text = "Réference";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(49, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Marque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nom";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(121, 137);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 33;
            // 
            // textBoxReference
            // 
            this.textBoxReference.Location = new System.Drawing.Point(121, 111);
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.Size = new System.Drawing.Size(100, 20);
            this.textBoxReference.TabIndex = 32;
            // 
            // textBoxMarque
            // 
            this.textBoxMarque.Location = new System.Drawing.Point(121, 85);
            this.textBoxMarque.Name = "textBoxMarque";
            this.textBoxMarque.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarque.TabIndex = 31;
            this.textBoxMarque.Text = "  ";
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(121, 59);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrix.TabIndex = 30;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(121, 33);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(176, 206);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouterClient.Location = new System.Drawing.Point(176, 177);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterClient.TabIndex = 27;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // GestionEquipementAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.voirEquipement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxReference);
            this.Controls.Add(this.textBoxMarque);
            this.Controls.Add(this.textBoxPrix);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAjouterClient);
            this.Name = "GestionEquipementAjout";
            this.Text = "GestionEquipementAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voirEquipement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label reference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.TextBox textBoxMarque;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAjouterClient;
    }
}