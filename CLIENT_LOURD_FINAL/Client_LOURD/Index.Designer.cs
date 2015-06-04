namespace Client_LOURD
{
    partial class Index
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelMagasin = new System.Windows.Forms.Label();
            this.labelMagasinAffiche = new System.Windows.Forms.Label();
            this.btn_EquipementSup = new System.Windows.Forms.Button();
            this.gestion_client = new System.Windows.Forms.Button();
            this.gestion_personnel = new System.Windows.Forms.Button();
            this.btn_ajout_res = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connecté en tant que:";
            // 
            // labelMagasin
            // 
            this.labelMagasin.AutoSize = true;
            this.labelMagasin.Location = new System.Drawing.Point(173, 9);
            this.labelMagasin.Name = "labelMagasin";
            this.labelMagasin.Size = new System.Drawing.Size(0, 13);
            this.labelMagasin.TabIndex = 5;
            // 
            // labelMagasinAffiche
            // 
            this.labelMagasinAffiche.AutoSize = true;
            this.labelMagasinAffiche.Location = new System.Drawing.Point(223, 9);
            this.labelMagasinAffiche.Name = "labelMagasinAffiche";
            this.labelMagasinAffiche.Size = new System.Drawing.Size(0, 13);
            this.labelMagasinAffiche.TabIndex = 6;
            // 
            // btn_EquipementSup
            // 
            this.btn_EquipementSup.Location = new System.Drawing.Point(520, 149);
            this.btn_EquipementSup.Name = "btn_EquipementSup";
            this.btn_EquipementSup.Size = new System.Drawing.Size(165, 52);
            this.btn_EquipementSup.TabIndex = 7;
            this.btn_EquipementSup.Text = "Equipements supplémentaires";
            this.btn_EquipementSup.UseVisualStyleBackColor = true;
            this.btn_EquipementSup.Click += new System.EventHandler(this.btn_EquipementSup_Click);
            // 
            // gestion_client
            // 
            this.gestion_client.Location = new System.Drawing.Point(122, 149);
            this.gestion_client.Name = "gestion_client";
            this.gestion_client.Size = new System.Drawing.Size(165, 55);
            this.gestion_client.TabIndex = 8;
            this.gestion_client.Text = "Gestion des clients";
            this.gestion_client.UseVisualStyleBackColor = true;
            this.gestion_client.Click += new System.EventHandler(this._Click);
            // 
            // gestion_personnel
            // 
            this.gestion_personnel.Location = new System.Drawing.Point(316, 149);
            this.gestion_personnel.Name = "gestion_personnel";
            this.gestion_personnel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gestion_personnel.Size = new System.Drawing.Size(165, 51);
            this.gestion_personnel.TabIndex = 10;
            this.gestion_personnel.Text = "Gestion personnel";
            this.gestion_personnel.UseVisualStyleBackColor = true;
            this.gestion_personnel.Click += new System.EventHandler(this.gestion_personnel_Click);
            // 
            // btn_ajout_res
            // 
            this.btn_ajout_res.Location = new System.Drawing.Point(316, 222);
            this.btn_ajout_res.Name = "btn_ajout_res";
            this.btn_ajout_res.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ajout_res.Size = new System.Drawing.Size(165, 51);
            this.btn_ajout_res.TabIndex = 11;
            this.btn_ajout_res.Text = "Ajouter une réservation";
            this.btn_ajout_res.UseVisualStyleBackColor = true;
            this.btn_ajout_res.Click += new System.EventHandler(this.btn_ajout_res_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client_LOURD.Properties.Resources.logoGamilon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 306);
            this.Controls.Add(this.btn_ajout_res);
            this.Controls.Add(this.gestion_personnel);
            this.Controls.Add(this.gestion_client);
            this.Controls.Add(this.btn_EquipementSup);
            this.Controls.Add(this.labelMagasinAffiche);
            this.Controls.Add(this.labelMagasin);
            this.Controls.Add(this.label1);
            this.Name = "Index";
            this.Text = "Gamilon";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMagasin;
        private System.Windows.Forms.Label labelMagasinAffiche;
        private System.Windows.Forms.Button btn_EquipementSup;
        private System.Windows.Forms.Button gestion_client;
        private System.Windows.Forms.Button gestion_personnel;
        private System.Windows.Forms.Button btn_ajout_res;
    }
}