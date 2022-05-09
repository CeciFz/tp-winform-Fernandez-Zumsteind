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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoPrinc));
            this.btnVerCatalogo = new System.Windows.Forms.Button();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerCatalogo
            // 
            this.btnVerCatalogo.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.btnVerCatalogo, "btnVerCatalogo");
            this.btnVerCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerCatalogo.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnVerCatalogo.FlatAppearance.BorderSize = 3;
            this.btnVerCatalogo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnVerCatalogo.Name = "btnVerCatalogo";
            this.btnVerCatalogo.UseVisualStyleBackColor = false;
            this.btnVerCatalogo.Click += new System.EventHandler(this.btnVerCatalogo_Click);
            // 
            // labeltitulo
            // 
            resources.ApplyResources(this.labeltitulo, "labeltitulo");
            this.labeltitulo.BackColor = System.Drawing.Color.Transparent;
            this.labeltitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labeltitulo.Name = "labeltitulo";
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdministrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdministrar.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnAdministrar, "btnAdministrar");
            this.btnAdministrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.UseVisualStyleBackColor = false;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvCategoria, "dgvCategoria");
            this.dgvCategoria.Name = "dgvCategoria";
            // 
            // frmCatalogoPrinc
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.btnVerCatalogo);
            this.Controls.Add(this.dgvCategoria);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MaximizeBox = false;
            this.Name = "frmCatalogoPrinc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerCatalogo;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.DataGridView dgvCategoria;
    }
}

