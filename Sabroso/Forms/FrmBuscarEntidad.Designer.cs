namespace Sabroso
{
    partial class FrmBuscarEntidad
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
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFiltro.Location = new System.Drawing.Point(0, 0);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(640, 20);
            this.textBoxFiltro.TabIndex = 0;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            this.textBoxFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltro_KeyPress);
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.AllowUserToAddRows = false;
            this.dataGridViewDatos.AllowUserToDeleteRows = false;
            this.dataGridViewDatos.AllowUserToResizeColumns = false;
            this.dataGridViewDatos.AllowUserToResizeRows = false;
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnDescripcion});
            this.dataGridViewDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDatos.Location = new System.Drawing.Point(0, 20);
            this.dataGridViewDatos.MultiSelect = false;
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.ReadOnly = true;
            this.dataGridViewDatos.RowHeadersVisible = false;
            this.dataGridViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDatos.Size = new System.Drawing.Size(640, 440);
            this.dataGridViewDatos.TabIndex = 1;
            this.dataGridViewDatos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDatos_CellMouseDoubleClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "CodigoFilter";
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 150;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.DataPropertyName = "DisplayMember";
            this.ColumnDescripcion.HeaderText = "Descripcion";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            this.ColumnDescripcion.Width = 450;
            // 
            // FrmBuscarEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 460);
            this.Controls.Add(this.dataGridViewDatos);
            this.Controls.Add(this.textBoxFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarEntidad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmBuscarEntidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
    }
}