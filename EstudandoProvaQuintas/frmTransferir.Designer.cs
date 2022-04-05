namespace EstudandoProvaQuintas
{
    partial class frmTransferir
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
            this.btnTranferir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNumeroConta = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTranferir
            // 
            this.btnTranferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranferir.Location = new System.Drawing.Point(204, 138);
            this.btnTranferir.Name = "btnTranferir";
            this.btnTranferir.Size = new System.Drawing.Size(156, 44);
            this.btnTranferir.TabIndex = 8;
            this.btnTranferir.Text = "Transferir";
            this.btnTranferir.UseVisualStyleBackColor = true;
            this.btnTranferir.Click += new System.EventHandler(this.btnTranferir_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(133, 87);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(227, 35);
            this.txtValor.TabIndex = 7;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(55, 88);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(75, 29);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // lblNumeroConta
            // 
            this.lblNumeroConta.AutoSize = true;
            this.lblNumeroConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroConta.Location = new System.Drawing.Point(19, 38);
            this.lblNumeroConta.Name = "lblNumeroConta";
            this.lblNumeroConta.Size = new System.Drawing.Size(120, 29);
            this.lblNumeroConta.TabIndex = 9;
            this.lblNumeroConta.Text = "Nº Conta: ";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroConta.Location = new System.Drawing.Point(138, 36);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(222, 35);
            this.txtNumeroConta.TabIndex = 10;
            // 
            // frmTransferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 228);
            this.Controls.Add(this.txtNumeroConta);
            this.Controls.Add(this.lblNumeroConta);
            this.Controls.Add(this.btnTranferir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Name = "frmTransferir";
            this.Text = "frmTransferir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranferir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNumeroConta;
        private System.Windows.Forms.TextBox txtNumeroConta;
    }
}