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
            lblNom = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblPrenom = new Label();
            textBox3 = new TextBox();
            lblMDP = new Label();
            btnConnecter = new Button();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(7, 13);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 3;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(7, 42);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(49, 15);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prénom";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(60, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 23);
            textBox3.TabIndex = 5;
            // 
            // lblMDP
            // 
            lblMDP.AutoSize = true;
            lblMDP.Location = new Point(7, 71);
            lblMDP.Name = "lblMDP";
            lblMDP.Size = new Size(32, 15);
            lblMDP.TabIndex = 4;
            lblMDP.Text = "Mdp";
            // 
            // btnConnecter
            // 
            btnConnecter.Location = new Point(148, 95);
            btnConnecter.Name = "btnConnecter";
            btnConnecter.Size = new Size(97, 23);
            btnConnecter.TabIndex = 6;
            btnConnecter.Text = "Se connecter";
            btnConnecter.UseVisualStyleBackColor = true;
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 130);
            Controls.Add(btnConnecter);
            Controls.Add(textBox3);
            Controls.Add(lblMDP);
            Controls.Add(textBox2);
            Controls.Add(lblPrenom);
            Controls.Add(textBox1);
            Controls.Add(lblNom);
            Name = "FrmConnexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblPrenom;
        private TextBox textBox3;
        private Label lblMDP;
        private Button btnConnecter;
    }
}