namespace Biblioteca.Frm
{
    partial class FrmConfiguracionUpdate
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
            this.lbNumDiasPrestamo1 = new System.Windows.Forms.Label();
            this.lbNumDiasPrestamo2 = new System.Windows.Forms.Label();
            this.lbMaxPrestamoUsuario = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.nudNumDiasPrestamo1 = new System.Windows.Forms.NumericUpDown();
            this.nudNumDiasPrestamo2 = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPrestamoUsuario = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDiasPrestamo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDiasPrestamo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrestamoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumDiasPrestamo1
            // 
            this.lbNumDiasPrestamo1.AutoSize = true;
            this.lbNumDiasPrestamo1.Location = new System.Drawing.Point(12, 15);
            this.lbNumDiasPrestamo1.Name = "lbNumDiasPrestamo1";
            this.lbNumDiasPrestamo1.Size = new System.Drawing.Size(225, 13);
            this.lbNumDiasPrestamo1.TabIndex = 8;
            this.lbNumDiasPrestamo1.Text = "Cantidad de dias de un préstamo por defecto: ";
            // 
            // lbNumDiasPrestamo2
            // 
            this.lbNumDiasPrestamo2.AutoSize = true;
            this.lbNumDiasPrestamo2.Location = new System.Drawing.Point(15, 41);
            this.lbNumDiasPrestamo2.Name = "lbNumDiasPrestamo2";
            this.lbNumDiasPrestamo2.Size = new System.Drawing.Size(222, 13);
            this.lbNumDiasPrestamo2.TabIndex = 9;
            this.lbNumDiasPrestamo2.Text = "Cantidad de días ampliables de un préstamo: ";
            // 
            // lbMaxPrestamoUsuario
            // 
            this.lbMaxPrestamoUsuario.AutoSize = true;
            this.lbMaxPrestamoUsuario.Location = new System.Drawing.Point(23, 68);
            this.lbMaxPrestamoUsuario.Name = "lbMaxPrestamoUsuario";
            this.lbMaxPrestamoUsuario.Size = new System.Drawing.Size(214, 13);
            this.lbMaxPrestamoUsuario.TabIndex = 10;
            this.lbMaxPrestamoUsuario.Text = "Cantidad máxima de préstamos por usuario: ";
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(131, 111);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(212, 111);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // nudNumDiasPrestamo1
            // 
            this.nudNumDiasPrestamo1.Location = new System.Drawing.Point(243, 13);
            this.nudNumDiasPrestamo1.Name = "nudNumDiasPrestamo1";
            this.nudNumDiasPrestamo1.Size = new System.Drawing.Size(44, 20);
            this.nudNumDiasPrestamo1.TabIndex = 0;
            // 
            // nudNumDiasPrestamo2
            // 
            this.nudNumDiasPrestamo2.Location = new System.Drawing.Point(243, 39);
            this.nudNumDiasPrestamo2.Name = "nudNumDiasPrestamo2";
            this.nudNumDiasPrestamo2.Size = new System.Drawing.Size(44, 20);
            this.nudNumDiasPrestamo2.TabIndex = 1;
            // 
            // nudMaxPrestamoUsuario
            // 
            this.nudMaxPrestamoUsuario.Location = new System.Drawing.Point(243, 66);
            this.nudMaxPrestamoUsuario.Name = "nudMaxPrestamoUsuario";
            this.nudMaxPrestamoUsuario.Size = new System.Drawing.Size(44, 20);
            this.nudMaxPrestamoUsuario.TabIndex = 2;
            // 
            // FrmConfiguracionUpdate
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(299, 146);
            this.Controls.Add(this.nudMaxPrestamoUsuario);
            this.Controls.Add(this.nudNumDiasPrestamo2);
            this.Controls.Add(this.nudNumDiasPrestamo1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbMaxPrestamoUsuario);
            this.Controls.Add(this.lbNumDiasPrestamo2);
            this.Controls.Add(this.lbNumDiasPrestamo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracionUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfiguracionUpdate";
            this.Load += new System.EventHandler(this.FrmConfiguracionUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDiasPrestamo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDiasPrestamo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrestamoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumDiasPrestamo1;
        private System.Windows.Forms.Label lbNumDiasPrestamo2;
        private System.Windows.Forms.Label lbMaxPrestamoUsuario;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.NumericUpDown nudNumDiasPrestamo1;
        private System.Windows.Forms.NumericUpDown nudNumDiasPrestamo2;
        private System.Windows.Forms.NumericUpDown nudMaxPrestamoUsuario;
    }
}