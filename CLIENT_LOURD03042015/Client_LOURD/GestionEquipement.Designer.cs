namespace Client_LOURD
{
    partial class GestionEquipement
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
            this.AjouterEquipement = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.VoirEquipement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AjouterEquipement
            // 
            this.AjouterEquipement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AjouterEquipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterEquipement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AjouterEquipement.Location = new System.Drawing.Point(12, 12);
            this.AjouterEquipement.Name = "AjouterEquipement";
            this.AjouterEquipement.Size = new System.Drawing.Size(125, 42);
            this.AjouterEquipement.TabIndex = 1;
            this.AjouterEquipement.Text = "Nouvel équipement";
            this.AjouterEquipement.UseVisualStyleBackColor = false;
            this.AjouterEquipement.Click += new System.EventHandler(this.AjouterEquipement_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(193, 77);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // VoirEquipement
            // 
            this.VoirEquipement.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VoirEquipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoirEquipement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VoirEquipement.Location = new System.Drawing.Point(143, 12);
            this.VoirEquipement.Name = "VoirEquipement";
            this.VoirEquipement.Size = new System.Drawing.Size(125, 42);
            this.VoirEquipement.TabIndex = 3;
            this.VoirEquipement.Text = "Voir les équipements";
            this.VoirEquipement.UseVisualStyleBackColor = false;
            this.VoirEquipement.Click += new System.EventHandler(this.VoirEquipement_Click);
            // 
            // GestionEquipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(276, 108);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.VoirEquipement);
            this.Controls.Add(this.AjouterEquipement);
            this.Name = "GestionEquipement";
            this.Text = "GestionEquipement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AjouterEquipement;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button VoirEquipement;
    }
}