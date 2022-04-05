namespace EstudandoProvaQuintas
{
    partial class frmDepositar
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(30, 28);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(75, 29);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(111, 28);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(196, 35);
            this.txtValor.TabIndex = 1;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(165, 78);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(142, 44);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 144);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Name = "Depositar";
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnDepositar;
    }
}