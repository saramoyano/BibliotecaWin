namespace Biblioteca.Frm
{
    partial class FrmGeneroRead
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAñadir = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.btEliminar = new System.Windows.Forms.ToolStripButton();
            this.lbFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.tbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAñadir,
            this.btEditar,
            this.btEliminar,
            this.lbFiltrar,
            this.tbFiltrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // lbFiltrar
            // 
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(130, 22);
            this.lbFiltrar.Text = "Filtrar (por descripción)";
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(100, 25);
            this.tbFiltrar.TextChanged += new System.EventHandler(this.TbFiltrar_TextChanged);
            // 
            // dgvGenero
            // 
            this.dgvGenero.AllowUserToAddRows = false;
            this.dgvGenero.AllowUserToDeleteRows = false;
            this.dgvGenero.AllowUserToResizeColumns = false;
            this.dgvGenero.AllowUserToResizeRows = false;
            this.dgvGenero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenero.Location = new System.Drawing.Point(0, 25);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.ReadOnly = true;
            this.dgvGenero.RowHeadersVisible = false;
            this.dgvGenero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenero.Size = new System.Drawing.Size(800, 425);
            this.dgvGenero.TabIndex = 3;
            // 
            // FrmGeneroRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGenero);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmGeneroRead";
            this.Text = "FrmGeneroRead";
            this.Load += new System.EventHandler(this.FrmGeneroRead_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAñadir;
        private System.Windows.Forms.ToolStripButton btEditar;
        private System.Windows.Forms.ToolStripButton btEliminar;
        private System.Windows.Forms.ToolStripLabel lbFiltrar;
        private System.Windows.Forms.ToolStripTextBox tbFiltrar;
        private System.Windows.Forms.DataGridView dgvGenero;
    }
}