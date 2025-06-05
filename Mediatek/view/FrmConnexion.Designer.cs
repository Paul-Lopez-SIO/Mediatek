namespace Mediatek.view
{
    partial class FrmConnexion
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
            txtboxLogin = new TextBox();
            lblLogin = new Label();
            txtboxMdp = new TextBox();
            lblMDP = new Label();
            btnConnecter = new Button();
            SuspendLayout();
            // 
            // txtboxLogin
            // 
            txtboxLogin.Location = new Point(58, 12);
            txtboxLogin.Name = "txtboxLogin";
            txtboxLogin.Size = new Size(187, 23);
            txtboxLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(5, 17);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // txtboxMdp
            // 
            txtboxMdp.Location = new Point(58, 41);
            txtboxMdp.Name = "txtboxMdp";
            txtboxMdp.Size = new Size(187, 23);
            txtboxMdp.TabIndex = 5;
            txtboxMdp.UseSystemPasswordChar = true;
            // 
            // lblMDP
            // 
            lblMDP.AutoSize = true;
            lblMDP.Location = new Point(5, 46);
            lblMDP.Name = "lblMDP";
            lblMDP.Size = new Size(32, 15);
            lblMDP.TabIndex = 4;
            lblMDP.Text = "Mdp";
            // 
            // btnConnecter
            // 
            btnConnecter.Location = new Point(148, 70);
            btnConnecter.Name = "btnConnecter";
            btnConnecter.Size = new Size(97, 23);
            btnConnecter.TabIndex = 6;
            btnConnecter.Text = "Se connecter";
            btnConnecter.UseVisualStyleBackColor = true;
            btnConnecter.Click += btnConnecter_Click;
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 103);
            Controls.Add(btnConnecter);
            Controls.Add(txtboxMdp);
            Controls.Add(lblMDP);
            Controls.Add(txtboxLogin);
            Controls.Add(lblLogin);
            Name = "FrmConnexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private TextBox txtboxNom;
        private TextBox txtboxLogin;
        private Label lblLogin;
        private TextBox txtboxMdp;
        private Label lblMDP;
        private Button btnConnecter;
    }
}