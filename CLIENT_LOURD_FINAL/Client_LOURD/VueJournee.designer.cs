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
            this.numericUpDown_jj = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_mm = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_aaaa = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.reservee_rectangle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libre_rectangle = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_ParJour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_jj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aaaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservee_rectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libre_rectangle)).BeginInit();
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
            this.datagridview_ParJour.Size = new System.Drawing.Size(539, 340);
            this.datagridview_ParJour.TabIndex = 0;
            this.datagridview_ParJour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_ParJour_CellClick);
            // 
            // heure
            // 
            this.heure.HeaderText = "Heure";
            this.heure.Name = "heure";
            this.heure.ReadOnly = true;
            // 
            // numericUpDown_jj
            // 
            this.numericUpDown_jj.Location = new System.Drawing.Point(162, 13);
            this.numericUpDown_jj.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_jj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_jj.Name = "numericUpDown_jj";
            this.numericUpDown_jj.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown_jj.TabIndex = 1;
            this.numericUpDown_jj.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // numericUpDown_mm
            // 
            this.numericUpDown_mm.Location = new System.Drawing.Point(210, 13);
            this.numericUpDown_mm.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_mm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_mm.Name = "numericUpDown_mm";
            this.numericUpDown_mm.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_mm.TabIndex = 2;
            this.numericUpDown_mm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_aaaa
            // 
            this.numericUpDown_aaaa.Location = new System.Drawing.Point(259, 13);
            this.numericUpDown_aaaa.Maximum = new decimal(new int[] {
            2080,
            0,
            0,
            0});
            this.numericUpDown_aaaa.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_aaaa.Name = "numericUpDown_aaaa";
            this.numericUpDown_aaaa.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown_aaaa.TabIndex = 3;
            this.numericUpDown_aaaa.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Voir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reservee_rectangle
            // 
            this.reservee_rectangle.Location = new System.Drawing.Point(566, 37);
            this.reservee_rectangle.Name = "reservee_rectangle";
            this.reservee_rectangle.Size = new System.Drawing.Size(68, 23);
            this.reservee_rectangle.TabIndex = 8;
            this.reservee_rectangle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "= Salle reservée";
            // 
            // libre_rectangle
            // 
            this.libre_rectangle.Location = new System.Drawing.Point(566, 78);
            this.libre_rectangle.Name = "libre_rectangle";
            this.libre_rectangle.Size = new System.Drawing.Size(68, 23);
            this.libre_rectangle.TabIndex = 10;
            this.libre_rectangle.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "= Salle libre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VueJournee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 545);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.libre_rectangle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservee_rectangle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_aaaa);
            this.Controls.Add(this.numericUpDown_mm);
            this.Controls.Add(this.numericUpDown_jj);
            this.Controls.Add(this.datagridview_ParJour);
            this.Name = "VueJournee";
            this.Text = "Planning";
            this.Load += new System.EventHandler(this.VueJournee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_ParJour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_jj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_aaaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservee_rectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libre_rectangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_ParJour;
        private System.Windows.Forms.NumericUpDown numericUpDown_jj;
        private System.Windows.Forms.NumericUpDown numericUpDown_mm;
        private System.Windows.Forms.NumericUpDown numericUpDown_aaaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox reservee_rectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox libre_rectangle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}