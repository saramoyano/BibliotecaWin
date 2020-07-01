namespace Biblioteca.Frm
{
    partial class FrmLibroUpdate
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
            this.btImagen = new System.Windows.Forms.Button();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.cbEditorial = new System.Windows.Forms.ComboBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nStock = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.btAñadirEditorial = new System.Windows.Forms.Button();
            this.btAñadirAutor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btImagen
            // 
            this.btImagen.Location = new System.Drawing.Point(356, 174);
            this.btImagen.Name = "btImagen";
            this.btImagen.Size = new System.Drawing.Size(124, 23);
            this.btImagen.TabIndex = 6;
            this.btImagen.Text = "Seleccionar Imagen";
            this.btImagen.UseVisualStyleBackColor = true;
            this.btImagen.Click += new System.EventHandler(this.BtImagen_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(89, 176);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(123, 21);
            this.cbGenero.TabIndex = 4;
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(89, 149);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(260, 21);
            this.cbClasificacion.TabIndex = 3;
            // 
            // cbEditorial
            // 
            this.cbEditorial.FormattingEnabled = true;
            this.cbEditorial.Location = new System.Drawing.Point(89, 122);
            this.cbEditorial.Name = "cbEditorial";
            this.cbEditorial.Size = new System.Drawing.Size(167, 21);
            this.cbEditorial.TabIndex = 2;
            // 
            // cbAutor
            // 
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(89, 95);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(167, 21);
            this.cbAutor.TabIndex = 1;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(324, 308);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(405, 308);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(356, 69);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(124, 101);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 121;
            this.pbImagen.TabStop = false;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(89, 69);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(260, 20);
            this.tbTitulo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Editorial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Clasificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Titulo:";
            // 
            // nStock
            // 
            this.nStock.Location = new System.Drawing.Point(262, 176);
            this.nStock.Name = "nStock";
            this.nStock.Size = new System.Drawing.Size(87, 20);
            this.nStock.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "Descripcion:";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(89, 203);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(391, 64);
            this.rtbDescripcion.TabIndex = 7;
            this.rtbDescripcion.Text = "";
            // 
            // btAñadirEditorial
            // 
            this.btAñadirEditorial.Location = new System.Drawing.Point(262, 122);
            this.btAñadirEditorial.Name = "btAñadirEditorial";
            this.btAñadirEditorial.Size = new System.Drawing.Size(87, 23);
            this.btAñadirEditorial.TabIndex = 125;
            this.btAñadirEditorial.Text = "Añadir Editorial";
            this.btAñadirEditorial.UseVisualStyleBackColor = true;
            this.btAñadirEditorial.Click += new System.EventHandler(this.BtAñadirEditorial_Click);
            // 
            // btAñadirAutor
            // 
            this.btAñadirAutor.Location = new System.Drawing.Point(262, 95);
            this.btAñadirAutor.Name = "btAñadirAutor";
            this.btAñadirAutor.Size = new System.Drawing.Size(87, 23);
            this.btAñadirAutor.TabIndex = 124;
            this.btAñadirAutor.Text = "Añadir Autor";
            this.btAñadirAutor.UseVisualStyleBackColor = true;
            this.btAñadirAutor.Click += new System.EventHandler(this.BtAñadirAutor_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(468, 57);
            this.label8.TabIndex = 126;
            this.label8.Text = "Editar Libro";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLibroUpdate
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(492, 343);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btAñadirEditorial);
            this.Controls.Add(this.btAñadirAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.nStock);
            this.Controls.Add(this.btImagen);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbClasificacion);
            this.Controls.Add(this.cbEditorial);
            this.Controls.Add(this.cbAutor);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLibroUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLibroUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btImagen;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.ComboBox cbEditorial;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nStock;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Button btAñadirEditorial;
        private System.Windows.Forms.Button btAñadirAutor;
        private System.Windows.Forms.Label label8;
    }
}