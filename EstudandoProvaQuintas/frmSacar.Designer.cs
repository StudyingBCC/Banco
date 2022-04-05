namespace EstudandoProvaQuintas
{
    partial class frmSacar
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
            this.btnSacar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(146, 73);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(142, 44);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(92, 23);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(196, 35);
            this.txtValor.TabIndex = 4;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(11, 23);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(75, 29);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 163);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Name = "Sacar";
            this.Text = "Sacar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
    }
}