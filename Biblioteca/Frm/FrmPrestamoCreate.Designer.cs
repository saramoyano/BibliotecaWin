namespace Biblioteca.Frm
{
    partial class FrmPrestamoCreate
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
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbLibro = new System.Windows.Forms.Label();
            this.cbLibro = new System.Windows.Forms.ComboBox();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.tbFechaInicio = new System.Windows.Forms.TextBox();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.tbFechaFin = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btAñadirUsuario = new System.Windows.Forms.Button();
            this.btAñadirLibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbUsuario
            // 
            this.cbUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(128, 105);
            this.cbUsuario.MinimumSize = new System.Drawing.Size(142, 0);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(142, 21);
            this.cbUsuario.TabIndex = 1;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(73, 108);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(49, 13);
            this.lbUsuario.TabIndex = 12;
            this.lbUsuario.Text = "Usuario: ";
            // 
            // lbLibro
            // 
            this.lbLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLibro.AutoSize = true;
            this.lbLibro.Location = new System.Drawing.Point(353, 108);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(36, 13);
            this.lbLibro.TabIndex = 14;
            this.lbLibro.Text = "Libro: ";
            // 
            // cbLibro
            // 
            this.cbLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLibro.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbLibro.FormattingEnabled = true;
            this.cbLibro.Location = new System.Drawing.Point(395, 105);
            this.cbLibro.MinimumSize = new System.Drawing.Size(142, 0);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(142, 21);
            this.cbLibro.TabIndex = 2;
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(16, 72);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(106, 13);
            this.lbFechaInicio.TabIndex = 13;
            this.lbFechaInicio.Text = "Fecha del préstamo: ";
            // 
            // tbFechaInicio
            // 
            this.tbFechaInicio.Location = new System.Drawing.Point(128, 69);
            this.tbFechaInicio.Name = "tbFechaInicio";
            this.tbFechaInicio.ReadOnly = true;
            this.tbFechaInicio.Size = new System.Drawing.Size(142, 20);
            this.tbFechaInicio.TabIndex = 9;
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(276, 72);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(113, 13);
            this.lbFechaFin.TabIndex = 15;
            this.lbFechaFin.Text = "Fecha de devolución: ";
            // 
            // tbFechaFin
            // 
            this.tbFechaFin.Location = new System.Drawing.Point(395, 69);
            this.tbFechaFin.Name = "tbFechaFin";
            this.tbFechaFin.ReadOnly = true;
            this.tbFechaFin.Size = new System.Drawing.Size(142, 20);
            this.tbFechaFin.TabIndex = 10;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(381, 186);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(462, 186);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(525, 57);
            this.label8.TabIndex = 127;
            this.label8.Text = "Alta Prestamo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btAñadirUsuario
            // 
            this.btAñadirUsuario.Location = new System.Drawing.Point(172, 132);
            this.btAñadirUsuario.Name = "btAñadirUsuario";
            this.btAñadirUsuario.Size = new System.Drawing.Size(98, 23);
            this.btAñadirUsuario.TabIndex = 128;
            this.btAñadirUsuario.Text = "Añadir Usuario";
            this.btAñadirUsuario.UseVisualStyleBackColor = true;
            this.btAñadirUsuario.Click += new System.EventHandler(this.btAñadirUsuario_Click);
            // 
            // btAñadirLibro
            // 
            this.btAñadirLibro.Location = new System.Drawing.Point(439, 132);
            this.btAñadirLibro.Name = "btAñadirLibro";
            this.btAñadirLibro.Size = new System.Drawing.Size(98, 23);
            this.btAñadirLibro.TabIndex = 129;
            this.btAñadirLibro.Text = "Añadir Libro";
            this.btAñadirLibro.UseVisualStyleBackColor = true;
            this.btAñadirLibro.Click += new System.EventHandler(this.btAñadirLibro_Click);
            // 
            // FrmPrestamoCreate
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(549, 221);
            this.Controls.Add(this.btAñadirLibro);
            this.Controls.Add(this.btAñadirUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbFechaFin);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.tbFechaInicio);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.cbLibro);
            this.Controls.Add(this.lbLibro);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.cbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(458, 39);
            this.Name = "FrmPrestamoCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrestamoCreate";
            this.Load += new System.EventHandler(this.FrmPrestamoCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbLibro;
        private System.Windows.Forms.ComboBox cbLibro;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.TextBox tbFechaInicio;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.TextBox tbFechaFin;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAñadirUsuario;
        private System.Windows.Forms.Button btAñadirLibro;
    }
}