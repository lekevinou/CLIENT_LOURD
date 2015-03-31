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
            this.btn_ajouterClient = new System.Windows.Forms.Button();
            this.vueClient_btn = new System.Windows.Forms.Button();
            this.btn_viewReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMagasin = new System.Windows.Forms.Label();
            this.labelMagasinAffiche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ajouterClient
            // 
            this.btn_ajouterClient.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ajouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ajouterClient.Location = new System.Drawing.Point(57, 146);
            this.btn_ajouterClient.Name = "btn_ajouterClient";
            this.btn_ajouterClient.Size = new System.Drawing.Size(165, 55);
            this.btn_ajouterClient.TabIndex = 0;
            this.btn_ajouterClient.Text = "Nouveau client";
            this.btn_ajouterClient.UseVisualStyleBackColor = false;
            this.btn_ajouterClient.Click += new System.EventHandler(this.btn_ajouterClient_Click);
            // 
            // vueClient_btn
            // 
            this.vueClient_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vueClient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vueClient_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vueClient_btn.Location = new System.Drawing.Point(321, 146);
            this.vueClient_btn.Name = "vueClient_btn";
            this.vueClient_btn.Size = new System.Drawing.Size(165, 55);
            this.vueClient_btn.TabIndex = 2;
            this.vueClient_btn.Text = "Liste des clients";
            this.vueClient_btn.UseVisualStyleBackColor = false;
            this.vueClient_btn.Click += new System.EventHandler(this.vueClient_btn_Click);
            // 
            // btn_viewReservation
            // 
            this.btn_viewReservation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_viewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_viewReservation.Location = new System.Drawing.Point(560, 146);
            this.btn_viewReservation.Name = "btn_viewReservation";
            this.btn_viewReservation.Size = new System.Drawing.Size(165, 55);
            this.btn_viewReservation.TabIndex = 3;
            this.btn_viewReservation.Text = "Voir reservation";
            this.btn_viewReservation.UseVisualStyleBackColor = false;
            this.btn_viewReservation.Click += new System.EventHandler(this.btn_viewReservation_Click);
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
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client_LOURD.Properties.Resources.logoGamilon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 294);
            this.Controls.Add(this.labelMagasinAffiche);
            this.Controls.Add(this.labelMagasin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_viewReservation);
            this.Controls.Add(this.vueClient_btn);
            this.Controls.Add(this.btn_ajouterClient);
            this.Name = "Index";
            this.Text = "Gamilon";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterClient;
        private System.Windows.Forms.Button vueClient_btn;
        private System.Windows.Forms.Button btn_viewReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMagasin;
        private System.Windows.Forms.Label labelMagasinAffiche;
    }
}