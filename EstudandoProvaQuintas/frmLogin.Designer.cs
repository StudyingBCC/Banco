namespace EstudandoProvaQuintas
{
    partial class frmLogin
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
            this.lblNumeroConta = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroConta
            // 
            this.lblNumeroConta.AutoSize = true;
            this.lblNumeroConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroConta.Location = new System.Drawing.Point(12, 40);
            this.lblNumeroConta.Name = "lblNumeroConta";
            this.lblNumeroConta.Size = new System.Drawing.Size(120, 29);
            this.lblNumeroConta.TabIndex = 0;
            this.lblNumeroConta.Text = "Nº Conta: ";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(36, 91);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(88, 29);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(138, 40);
            this.txtNumeroConta.Multiline = true;
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(315, 29);
            this.txtNumeroConta.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(138, 91);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(315, 29);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Tag = "";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(292, 150);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(161, 64);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 230);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNumeroConta);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNumeroConta);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroConta;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
    }
}