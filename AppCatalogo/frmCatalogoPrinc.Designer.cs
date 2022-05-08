namespace AppCatalogo
{
    partial class frmCatalogoPrinc
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
            this.btnVerCatalogo = new System.Windows.Forms.Button();
            this.tituloinicio = new System.Windows.Forms.Label();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnAdministrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerCatalogo
            // 
            this.btnVerCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerCatalogo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCatalogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerCatalogo.Location = new System.Drawing.Point(177, 204);
            this.btnVerCatalogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerCatalogo.Name = "btnVerCatalogo";
            this.btnVerCatalogo.Size = new System.Drawing.Size(158, 51);
            this.btnVerCatalogo.TabIndex = 4;
            this.btnVerCatalogo.Text = "Ver Catálogo";
            this.btnVerCatalogo.UseVisualStyleBackColor = true;
            this.btnVerCatalogo.Click += new System.EventHandler(this.btnVerCatalogo_Click);
            // 
            // tituloinicio
            // 
            this.tituloinicio.AccessibleDescription = "";
            this.tituloinicio.AutoSize = true;
            this.tituloinicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloinicio.Location = new System.Drawing.Point(264, 133);
            this.tituloinicio.Name = "tituloinicio";
            this.tituloinicio.Size = new System.Drawing.Size(0, 35);
            this.tituloinicio.TabIndex = 5;
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.BackColor = System.Drawing.Color.Transparent;
            this.labeltitulo.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.ForeColor = System.Drawing.Color.Maroon;
            this.labeltitulo.Location = new System.Drawing.Point(116, 83);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(301, 50);
            this.labeltitulo.TabIndex = 7;
            this.labeltitulo.Text = "Gestión de Artículos\r\n";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(565, 412);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(110, 96);
            this.dgvCategoria.TabIndex = 1;
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdministrar.Location = new System.Drawing.Point(177, 280);
            this.btnAdministrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(158, 51);
            this.btnAdministrar.TabIndex = 8;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // frmCatalogoPrinc
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(535, 458);
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.tituloinicio);
            this.Controls.Add(this.btnVerCatalogo);
            this.Controls.Add(this.dgvCategoria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCatalogoPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerCatalogo;
        private System.Windows.Forms.Label tituloinicio;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnAdministrar;
    }
}

