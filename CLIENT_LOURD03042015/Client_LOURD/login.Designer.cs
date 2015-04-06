namespace Client_LOURD
{
    partial class login
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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.quitter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(133, 26);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(84, 20);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Identifiant:";
            // 
            // password_label
            // 
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(121, 116);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(119, 20);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Mot de passe:";
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(56, 49);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(242, 20);
            this.username_textBox.TabIndex = 2;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(56, 140);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(242, 20);
            this.password_textBox.TabIndex = 3;
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(56, 201);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 4;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // quitter_btn
            // 
            this.quitter_btn.Location = new System.Drawing.Point(223, 201);
            this.quitter_btn.Name = "quitter_btn";
            this.quitter_btn.Size = new System.Drawing.Size(75, 23);
            this.quitter_btn.TabIndex = 5;
            this.quitter_btn.Text = "Cancel";
            this.quitter_btn.UseVisualStyleBackColor = true;
            this.quitter_btn.Click += new System.EventHandler(this.quitter_btn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 286);
            this.Controls.Add(this.quitter_btn);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button quitter_btn;
    }
}