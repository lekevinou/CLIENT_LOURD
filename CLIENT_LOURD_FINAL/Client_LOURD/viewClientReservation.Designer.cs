namespace Client_LOURD
{
    partial class viewClientReservation
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
            this.components = new System.ComponentModel.Container();
            this.btn_view_reservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_listClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamilonbaseDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamilonbaseDataSet1 = new Client_LOURD.gamilonbaseDataSet1();
            this.gamilonbaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Client_LOURD.gamilonbaseDataSet1TableAdapters.clientTableAdapter();
            this.listReservationUnClient = new System.Windows.Forms.ListView();
            this.label_noReservation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_view_reservation
            // 
            this.btn_view_reservation.Location = new System.Drawing.Point(406, 25);
            this.btn_view_reservation.Name = "btn_view_reservation";
            this.btn_view_reservation.Size = new System.Drawing.Size(75, 23);
            this.btn_view_reservation.TabIndex = 0;
            this.btn_view_reservation.Text = "Voir";
            this.btn_view_reservation.UseVisualStyleBackColor = true;
            this.btn_view_reservation.Click += new System.EventHandler(this.btn_view_reservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir un client";
            // 
            // combo_listClient
            // 
            this.combo_listClient.DataSource = this.clientBindingSource;
            this.combo_listClient.DisplayMember = "nom_client";
            this.combo_listClient.FormattingEnabled = true;
            this.combo_listClient.Location = new System.Drawing.Point(279, 25);
            this.combo_listClient.Name = "combo_listClient";
            this.combo_listClient.Size = new System.Drawing.Size(121, 21);
            this.combo_listClient.TabIndex = 2;
            this.combo_listClient.ValueMember = "id_client";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.gamilonbaseDataSet1BindingSource1;
            // 
            // gamilonbaseDataSet1BindingSource1
            // 
            this.gamilonbaseDataSet1BindingSource1.DataSource = this.gamilonbaseDataSet1;
            this.gamilonbaseDataSet1BindingSource1.Position = 0;
            // 
            // gamilonbaseDataSet1
            // 
            this.gamilonbaseDataSet1.DataSetName = "gamilonbaseDataSet1";
            this.gamilonbaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamilonbaseDataSet1BindingSource
            // 
            this.gamilonbaseDataSet1BindingSource.DataSource = this.gamilonbaseDataSet1;
            this.gamilonbaseDataSet1BindingSource.Position = 0;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // listReservationUnClient
            // 
            this.listReservationUnClient.Location = new System.Drawing.Point(12, 73);
            this.listReservationUnClient.Name = "listReservationUnClient";
            this.listReservationUnClient.Size = new System.Drawing.Size(677, 246);
            this.listReservationUnClient.TabIndex = 3;
            this.listReservationUnClient.UseCompatibleStateImageBehavior = false;
            // 
            // label_noReservation
            // 
            this.label_noReservation.AutoSize = true;
            this.label_noReservation.Location = new System.Drawing.Point(13, 73);
            this.label_noReservation.Name = "label_noReservation";
            this.label_noReservation.Size = new System.Drawing.Size(166, 13);
            this.label_noReservation.TabIndex = 4;
            this.label_noReservation.Text = "Aucune reservation pour ce client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewClientReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_noReservation);
            this.Controls.Add(this.listReservationUnClient);
            this.Controls.Add(this.combo_listClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_view_reservation);
            this.Name = "viewClientReservation";
            this.Text = "Reservation(s) d\'un client";
            this.Load += new System.EventHandler(this.viewClientReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamilonbaseDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_view_reservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_listClient;
        private System.Windows.Forms.BindingSource gamilonbaseDataSet1BindingSource1;
        private gamilonbaseDataSet1 gamilonbaseDataSet1;
        private System.Windows.Forms.BindingSource gamilonbaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private gamilonbaseDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ListView listReservationUnClient;
        private System.Windows.Forms.Label label_noReservation;
        private System.Windows.Forms.Button button1;
    }
}