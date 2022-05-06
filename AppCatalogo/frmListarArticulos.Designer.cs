
namespace AppCatalogo
{
    partial class frmListadoArticulos
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
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.labeltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarca
            // 
            this.dgvMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvMarca.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(86, 371);
            this.dgvMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(245, 165);
            this.dgvMarca.TabIndex = 3;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvArticulos.Location = new System.Drawing.Point(28, 162);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(841, 156);
            this.dgvArticulos.TabIndex = 4;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(525, 371);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(234, 165);
            this.dgvCategoria.TabIndex = 5;
            // 
            // labeltitulo
            // 
            this.labeltitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.Location = new System.Drawing.Point(302, 24);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(303, 36);
            this.labeltitulo.TabIndex = 6;
            this.labeltitulo.Text = "Listado de Articulos";
            // 
            // frmListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(913, 538);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.dgvMarca);
            this.Name = "frmListadoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListarArticulos";
            this.Load += new System.EventHandler(this.frmListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Label labeltitulo;
    }
}