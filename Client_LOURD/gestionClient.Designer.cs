namespace Client_LOURD
{
    partial class gestionClient
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
            this.vueClient_btn = new System.Windows.Forms.Button();
            this.btn_ajouterClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_vue_journee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vueClient_btn
            // 
            this.vueClient_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vueClient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vueClient_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vueClient_btn.Location = new System.Drawing.Point(12, 34);
            this.vueClient_btn.Name = "vueClient_btn";
            this.vueClient_btn.Size = new System.Drawing.Size(165, 55);
            this.vueClient_btn.TabIndex = 4;
            this.vueClient_btn.Text = "Liste des clients";
            this.vueClient_btn.UseVisualStyleBackColor = false;
            this.vueClient_btn.Click += new System.EventHandler(this.vueClient_btn_Click);
            // 
            // btn_ajouterClient
            // 
            this.btn_ajouterClient.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ajouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ajouterClient.Location = new System.Drawing.Point(192, 34);
            this.btn_ajouterClient.Name = "btn_ajouterClient";
            this.btn_ajouterClient.Size = new System.Drawing.Size(165, 55);
            this.btn_ajouterClient.TabIndex = 3;
            this.btn_ajouterClient.Text = "Nouveau client";
            this.btn_ajouterClient.UseVisualStyleBackColor = false;
            this.btn_ajouterClient.Click += new System.EventHandler(this.btn_ajouterClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_vue_journee
            // 
            this.btn_vue_journee.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_vue_journee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vue_journee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_vue_journee.Location = new System.Drawing.Point(398, 34);
            this.btn_vue_journee.Name = "btn_vue_journee";
            this.btn_vue_journee.Size = new System.Drawing.Size(132, 55);
            this.btn_vue_journee.TabIndex = 6;
            this.btn_vue_journee.Text = "Test vue emploi du temps";
            this.btn_vue_journee.UseVisualStyleBackColor = false;
            this.btn_vue_journee.Click += new System.EventHandler(this.btn_vue_journee_Click);
            // 
            // gestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 152);
            this.Controls.Add(this.btn_vue_journee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vueClient_btn);
            this.Controls.Add(this.btn_ajouterClient);
            this.Name = "gestionClient";
            this.Text = "Gestion des clients";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vueClient_btn;
        private System.Windows.Forms.Button btn_ajouterClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_vue_journee;
    }
}