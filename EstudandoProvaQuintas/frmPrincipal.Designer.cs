namespace EstudandoProvaQuintas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblPIX = new System.Windows.Forms.Label();
            this.lblSifrao = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.lstExtrato = new System.Windows.Forms.ListBox();
            this.lblExtrato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(12, 23);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(202, 29);
            this.lblNomeUsuario.TabIndex = 0;
            this.lblNomeUsuario.Text = "Nome do Usuário";
            // 
            // lblPIX
            // 
            this.lblPIX.AutoSize = true;
            this.lblPIX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIX.Location = new System.Drawing.Point(530, 32);
            this.lblPIX.Name = "lblPIX";
            this.lblPIX.Size = new System.Drawing.Size(52, 29);
            this.lblPIX.TabIndex = 1;
            this.lblPIX.Text = "PIX";
            this.lblPIX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPIX.Click += new System.EventHandler(this.lblPIX_Click);
            // 
            // lblSifrao
            // 
            this.lblSifrao.AutoSize = true;
            this.lblSifrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifrao.Location = new System.Drawing.Point(27, 66);
            this.lblSifrao.Name = "lblSifrao";
            this.lblSifrao.Size = new System.Drawing.Size(59, 37);
            this.lblSifrao.TabIndex = 2;
            this.lblSifrao.Text = "R$";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(86, 66);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(84, 37);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "0,00";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(12, 138);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(212, 77);
            this.btnDeposito.TabIndex = 4;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(12, 231);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(212, 77);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(12, 332);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(212, 77);
            this.btnTransferir.TabIndex = 6;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lstExtrato
            // 
            this.lstExtrato.FormattingEnabled = true;
            this.lstExtrato.ItemHeight = 20;
            this.lstExtrato.Location = new System.Drawing.Point(247, 138);
            this.lstExtrato.Name = "lstExtrato";
            this.lstExtrato.Size = new System.Drawing.Size(527, 264);
            this.lstExtrato.TabIndex = 7;
            // 
            // lblExtrato
            // 
            this.lblExtrato.AutoSize = true;
            this.lblExtrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrato.Location = new System.Drawing.Point(408, 90);
            this.lblExtrato.Name = "lblExtrato";
            this.lblExtrato.Size = new System.Drawing.Size(189, 29);
            this.lblExtrato.TabIndex = 8;
            this.lblExtrato.Text = "Extrato da Conta";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 445);
            this.Controls.Add(this.lblExtrato);
            this.Controls.Add(this.lstExtrato);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSifrao);
            this.Controls.Add(this.lblPIX);
            this.Controls.Add(this.lblNomeUsuario);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblPIX;
        private System.Windows.Forms.Label lblSifrao;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.ListBox lstExtrato;
        private System.Windows.Forms.Label lblExtrato;
    }
}

