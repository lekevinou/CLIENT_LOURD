namespace Client_LOURD
{
    partial class VueJournee
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
            this.datagridview_ParJour = new System.Windows.Forms.DataGridView();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_ParJour)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview_ParJour
            // 
            this.datagridview_ParJour.AllowUserToAddRows = false;
            this.datagridview_ParJour.AllowUserToDeleteRows = false;
            this.datagridview_ParJour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_ParJour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heure});
            this.datagridview_ParJour.Location = new System.Drawing.Point(21, 37);
            this.datagridview_ParJour.Name = "datagridview_ParJour";
            this.datagridview_ParJour.ReadOnly = true;
            this.datagridview_ParJour.Size = new System.Drawing.Size(658, 434);
            this.datagridview_ParJour.TabIndex = 0;
            // 
            // heure
            // 
            this.heure.HeaderText = "";
            this.heure.Name = "heure";
            this.heure.ReadOnly = true;
            // 
            // VueJournee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 545);
            this.Controls.Add(this.datagridview_ParJour);
            this.Name = "VueJournee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VueJournee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_ParJour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_ParJour;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
    }
}