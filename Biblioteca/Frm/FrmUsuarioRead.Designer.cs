namespace Biblioteca.Frm
{
    partial class FrmUsuarioRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioRead));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAñadir = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.btEliminar = new System.Windows.Forms.ToolStripButton();
            this.btReiniciarContraseña = new System.Windows.Forms.ToolStripButton();
            this.lbFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.tbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicioSesion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbInicioSesion = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAñadir,
            this.btEditar,
            this.btEliminar,
            this.btReiniciarContraseña,
            this.lbFiltrar,
            this.tbFiltrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAñadir
            // 
            this.btAñadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btAñadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(46, 22);
            this.btAñadir.Text = "Añadir";
            this.btAñadir.Click += new System.EventHandler(this.BtAñadir_Click);
            // 
            // btEditar
            // 
            this.btEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(41, 22);
            this.btEditar.Text = "Editar";
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click_1);
            // 
            // btEliminar
            // 
            this.btEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(54, 22);
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.Click += new System.EventHandler(this.BtEliminar_Click_1);
            // 
            // btReiniciarContraseña
            // 
            this.btReiniciarContraseña.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btReiniciarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("btReiniciarContraseña.Image")));
            this.btReiniciarContraseña.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btReiniciarContraseña.Name = "btReiniciarContraseña";
            this.btReiniciarContraseña.Size = new System.Drawing.Size(117, 22);
            this.btReiniciarContraseña.Text = "Reiniciar contraseña";
            this.btReiniciarContraseña.Click += new System.EventHandler(this.BtReiniciarContraseña_Click);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(111, 22);
            this.lbFiltrar.Text = "Filtrar (por apellido)";
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(100, 25);
            this.tbFiltrar.TextChanged += new System.EventHandler(this.TbFiltrar_TextChanged);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Apellidos,
            this.InicioSesion});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 25);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(821, 425);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "DNI";
            this.Dni.HeaderText = "DNI ";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // InicioSesion
            // 
            this.InicioSesion.DataPropertyName = "InicioSesion";
            this.InicioSesion.HeaderText = "Inicio Sesion";
            this.InicioSesion.Name = "InicioSesion";
            this.InicioSesion.ReadOnly = true;
            // 
            // cbInicioSesion
            // 
            this.cbInicioSesion.AutoSize = true;
            this.cbInicioSesion.Location = new System.Drawing.Point(554, 2);
            this.cbInicioSesion.Name = "cbInicioSesion";
            this.cbInicioSesion.Size = new System.Drawing.Size(150, 17);
            this.cbInicioSesion.TabIndex = 4;
            this.cbInicioSesion.Text = "Filtrar (por inicio de sesión)";
            this.cbInicioSesion.UseVisualStyleBackColor = true;
            this.cbInicioSesion.CheckedChanged += new System.EventHandler(this.CbInicioSesion_CheckedChanged);
            // 
            // FrmUsuarioRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.cbInicioSesion);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmUsuarioRead";
            this.Text = "FrmUsuarioRead";
            this.Load += new System.EventHandler(this.FrmUsuarioRead_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAñadir;
        private System.Windows.Forms.ToolStripButton btEditar;
        private System.Windows.Forms.ToolStripButton btEliminar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ToolStripButton btReiniciarContraseña;
        private System.Windows.Forms.ToolStripLabel lbFiltrar;
        private System.Windows.Forms.ToolStripTextBox tbFiltrar;
        private System.Windows.Forms.CheckBox cbInicioSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InicioSesion;
    }
}