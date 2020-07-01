namespace Biblioteca.Frm
{
    partial class FrmUsuarioUpdate
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.cbInicioSesion = new System.Windows.Forms.CheckBox();
            this.tbTelefono2 = new System.Windows.Forms.TextBox();
            this.lbTelefono2 = new System.Windows.Forms.Label();
            this.lbTelefono1 = new System.Windows.Forms.Label();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.tbTelefono1 = new System.Windows.Forms.TextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.lbcodPostal = new System.Windows.Forms.Label();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.lbPoblacion = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbInicioSesion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(322, 241);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click_1);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(403, 241);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 11;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click_1);
            // 
            // cbInicioSesion
            // 
            this.cbInicioSesion.AutoSize = true;
            this.cbInicioSesion.Location = new System.Drawing.Point(298, 71);
            this.cbInicioSesion.Name = "cbInicioSesion";
            this.cbInicioSesion.Size = new System.Drawing.Size(15, 14);
            this.cbInicioSesion.TabIndex = 2;
            this.cbInicioSesion.UseVisualStyleBackColor = true;
            this.cbInicioSesion.CheckedChanged += new System.EventHandler(this.CbInicioSesion_CheckedChanged);
            // 
            // tbTelefono2
            // 
            this.tbTelefono2.Location = new System.Drawing.Point(310, 175);
            this.tbTelefono2.Name = "tbTelefono2";
            this.tbTelefono2.Size = new System.Drawing.Size(168, 20);
            this.tbTelefono2.TabIndex = 10;
            // 
            // lbTelefono2
            // 
            this.lbTelefono2.AutoSize = true;
            this.lbTelefono2.Location = new System.Drawing.Point(270, 178);
            this.lbTelefono2.Name = "lbTelefono2";
            this.lbTelefono2.Size = new System.Drawing.Size(34, 13);
            this.lbTelefono2.TabIndex = 67;
            this.lbTelefono2.Text = "Tlf. 2:";
            // 
            // lbTelefono1
            // 
            this.lbTelefono1.AutoSize = true;
            this.lbTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono1.Location = new System.Drawing.Point(42, 176);
            this.lbTelefono1.Name = "lbTelefono1";
            this.lbTelefono1.Size = new System.Drawing.Size(35, 13);
            this.lbTelefono1.TabIndex = 66;
            this.lbTelefono1.Text = "*Tlf.:";
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProvincia.Location = new System.Drawing.Point(8, 126);
            this.lbProvincia.Name = "lbProvincia";
            this.lbProvincia.Size = new System.Drawing.Size(69, 13);
            this.lbProvincia.TabIndex = 65;
            this.lbProvincia.Text = "*Provincia:";
            // 
            // tbTelefono1
            // 
            this.tbTelefono1.Location = new System.Drawing.Point(83, 175);
            this.tbTelefono1.Name = "tbTelefono1";
            this.tbTelefono1.Size = new System.Drawing.Size(168, 20);
            this.tbTelefono1.TabIndex = 9;
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(83, 123);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(137, 20);
            this.tbProvincia.TabIndex = 5;
            // 
            // lbcodPostal
            // 
            this.lbcodPostal.AutoSize = true;
            this.lbcodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodPostal.Location = new System.Drawing.Point(342, 152);
            this.lbcodPostal.Name = "lbcodPostal";
            this.lbcodPostal.Size = new System.Drawing.Size(40, 13);
            this.lbcodPostal.TabIndex = 64;
            this.lbcodPostal.Text = "*C.P.:";
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(388, 149);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(90, 20);
            this.tbCodPostal.TabIndex = 8;
            // 
            // lbPoblacion
            // 
            this.lbPoblacion.AutoSize = true;
            this.lbPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoblacion.Location = new System.Drawing.Point(220, 126);
            this.lbPoblacion.Name = "lbPoblacion";
            this.lbPoblacion.Size = new System.Drawing.Size(72, 13);
            this.lbPoblacion.TabIndex = 63;
            this.lbPoblacion.Text = "*Población:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(7, 152);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(70, 13);
            this.lbDireccion.TabIndex = 62;
            this.lbDireccion.Text = "*Dirección:";
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(298, 123);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(180, 20);
            this.tbPoblacion.TabIndex = 6;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(83, 149);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(254, 20);
            this.tbDireccion.TabIndex = 7;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(83, 71);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(137, 20);
            this.tbDni.TabIndex = 1;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNI.Location = new System.Drawing.Point(39, 74);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(38, 13);
            this.lbDNI.TabIndex = 61;
            this.lbDNI.Text = "*DNI:";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(298, 97);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(180, 20);
            this.tbApellidos.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(83, 97);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(137, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(225, 102);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(67, 13);
            this.lbApellidos.TabIndex = 60;
            this.lbApellidos.Text = "*Apellidos:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(18, 100);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(59, 13);
            this.lbNombre.TabIndex = 59;
            this.lbNombre.Text = "*Nombre:";
            // 
            // lbInicioSesion
            // 
            this.lbInicioSesion.AutoSize = true;
            this.lbInicioSesion.Location = new System.Drawing.Point(319, 71);
            this.lbInicioSesion.Name = "lbInicioSesion";
            this.lbInicioSesion.Size = new System.Drawing.Size(145, 13);
            this.lbInicioSesion.TabIndex = 68;
            this.lbInicioSesion.Text = "Desactivado Inicio de Sesión";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(466, 57);
            this.label8.TabIndex = 127;
            this.label8.Text = "Editar Usuario";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(173, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 128;
            this.label1.Text = "* Campos Obligatorios";
            // 
            // FrmUsuarioUpdate
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(490, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbInicioSesion);
            this.Controls.Add(this.cbInicioSesion);
            this.Controls.Add(this.tbTelefono2);
            this.Controls.Add(this.lbTelefono2);
            this.Controls.Add(this.lbTelefono1);
            this.Controls.Add(this.lbProvincia);
            this.Controls.Add(this.tbTelefono1);
            this.Controls.Add(this.tbProvincia);
            this.Controls.Add(this.lbcodPostal);
            this.Controls.Add(this.tbCodPostal);
            this.Controls.Add(this.lbPoblacion);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.tbPoblacion);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarioUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.CheckBox cbInicioSesion;
        private System.Windows.Forms.TextBox tbTelefono2;
        private System.Windows.Forms.Label lbTelefono2;
        private System.Windows.Forms.Label lbTelefono1;
        private System.Windows.Forms.Label lbProvincia;
        private System.Windows.Forms.TextBox tbTelefono1;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.Label lbcodPostal;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.Label lbPoblacion;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox tbPoblacion;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbInicioSesion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}