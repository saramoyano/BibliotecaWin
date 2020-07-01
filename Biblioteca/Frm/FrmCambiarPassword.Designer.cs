namespace Biblioteca.Frm
{
    partial class FrmCambiarPassword
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
            this.lbPass1 = new System.Windows.Forms.Label();
            this.lbPass2 = new System.Windows.Forms.Label();
            this.tbPass1 = new System.Windows.Forms.TextBox();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPass1
            // 
            this.lbPass1.AutoSize = true;
            this.lbPass1.Location = new System.Drawing.Point(11, 72);
            this.lbPass1.Name = "lbPass1";
            this.lbPass1.Size = new System.Drawing.Size(98, 13);
            this.lbPass1.TabIndex = 4;
            this.lbPass1.Text = "Nueva contraseña:";
            // 
            // lbPass2
            // 
            this.lbPass2.AutoSize = true;
            this.lbPass2.Location = new System.Drawing.Point(12, 103);
            this.lbPass2.Name = "lbPass2";
            this.lbPass2.Size = new System.Drawing.Size(97, 13);
            this.lbPass2.TabIndex = 5;
            this.lbPass2.Text = "Repita contraseña:";
            // 
            // tbPass1
            // 
            this.tbPass1.Location = new System.Drawing.Point(115, 69);
            this.tbPass1.Name = "tbPass1";
            this.tbPass1.PasswordChar = '*';
            this.tbPass1.Size = new System.Drawing.Size(165, 20);
            this.tbPass1.TabIndex = 0;
            this.tbPass1.TextChanged += new System.EventHandler(this.TbPass1_TextChanged);
            // 
            // tbPass2
            // 
            this.tbPass2.Location = new System.Drawing.Point(115, 100);
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.PasswordChar = '*';
            this.tbPass2.Size = new System.Drawing.Size(165, 20);
            this.tbPass2.TabIndex = 1;
            this.tbPass2.TextChanged += new System.EventHandler(this.TbPass2_TextChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(205, 201);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(124, 201);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(35, 140);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(224, 20);
            this.lbError.TabIndex = 6;
            this.lbError.Text = "Las contraseñas no coinciden!";
            this.lbError.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 57);
            this.label8.TabIndex = 129;
            this.label8.Text = "Cambiar Contraseña";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCambiarPassword
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(292, 236);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbPass2);
            this.Controls.Add(this.tbPass1);
            this.Controls.Add(this.lbPass2);
            this.Controls.Add(this.lbPass1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCambiarPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPass1;
        private System.Windows.Forms.Label lbPass2;
        private System.Windows.Forms.TextBox tbPass1;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label8;
    }
}