namespace Biblioteca.Frm
{
    partial class FrmPrestamosRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamosRead));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCrear = new System.Windows.Forms.ToolStripButton();
            this.tsbDevolver = new System.Windows.Forms.ToolStripButton();
            this.tsbAmpliar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCrear,
            this.tsbDevolver,
            this.tsbAmpliar,
            this.toolStripLabel1,
            this.tbFiltrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCrear
            // 
            this.tsbCrear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCrear.Image = ((System.Drawing.Image)(resources.GetObject("tsbCrear.Image")));
            this.tsbCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCrear.Name = "tsbCrear";
            this.tsbCrear.Size = new System.Drawing.Size(46, 22);
            this.tsbCrear.Text = "Añadir";
            this.tsbCrear.Click += new System.EventHandler(this.tsbCrear_Click);
            // 
            // tsbDevolver
            // 
            this.tsbDevolver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDevolver.Image = ((System.Drawing.Image)(resources.GetObject("tsbDevolver.Image")));
            this.tsbDevolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDevolver.Name = "tsbDevolver";
            this.tsbDevolver.Size = new System.Drawing.Size(57, 22);
            this.tsbDevolver.Text = "Devolver";
            this.tsbDevolver.Click += new System.EventHandler(this.tsbDevolver_Click);
            // 
            // tsbAmpliar
            // 
            this.tsbAmpliar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAmpliar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAmpliar.Image")));
            this.tsbAmpliar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAmpliar.Name = "tsbAmpliar";
            this.tsbAmpliar.Size = new System.Drawing.Size(53, 22);
            this.tsbAmpliar.Text = "Ampliar";
            this.tsbAmpliar.Click += new System.EventHandler(this.tsbAmpliar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(174, 22);
            this.toolStripLabel1.Text = "Filtrar (por apellidos de usuario)";
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(100, 25);
            this.tbFiltrar.TextChanged += new System.EventHandler(this.tstbFiltro_TextChanged);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamos.Location = new System.Drawing.Point(0, 25);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(800, 425);
            this.dgvPrestamos.TabIndex = 2;
            // 
            // FrmPrestamosRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPrestamosRead";
            this.Text = "            ";
            this.Load += new System.EventHandler(this.FrmPrestamosRead_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCrear;
        private System.Windows.Forms.ToolStripButton tsbDevolver;
        private System.Windows.Forms.ToolStripButton tsbAmpliar;
        private System.Windows.Forms.ToolStripTextBox tbFiltrar;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}