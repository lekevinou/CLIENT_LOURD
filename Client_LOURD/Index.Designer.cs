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
            this.btn_viewReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMagasin = new System.Windows.Forms.Label();
            this.labelMagasinAffiche = new System.Windows.Forms.Label();
            this.btn_EquipementSup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_viewReservation
            // 
            this.btn_viewReservation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_viewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_viewReservation.Location = new System.Drawing.Point(316, 149);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gestion des clients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client_LOURD.Properties.Resources.message1;
            this.pictureBox1.Location = new System.Drawing.Point(736, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client_LOURD.Properties.Resources.logoGamilon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 294);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_EquipementSup);
            this.Controls.Add(this.labelMagasinAffiche);
            this.Controls.Add(this.labelMagasin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_viewReservation);
            this.Name = "Index";
            this.Text = "Gamilon";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_viewReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMagasin;
        private System.Windows.Forms.Label labelMagasinAffiche;
        private System.Windows.Forms.Button btn_EquipementSup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}