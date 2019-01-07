namespace Sabroso
{
    partial class FrmOrdenCompra
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridViewCompra = new System.Windows.Forms.DataGridView();
            this.panelProveedor = new System.Windows.Forms.Panel();
            this.groupBoxProveedor = new System.Windows.Forms.GroupBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).BeginInit();
            this.panelProveedor.SuspendLayout();
            this.groupBoxProveedor.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gold;
            this.panelTop.Controls.Add(this.labelTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(807, 35);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(0, 31);
            this.labelTitulo.TabIndex = 4;
            // 
            // dataGridViewCompra
            // 
            this.dataGridViewCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompra.Location = new System.Drawing.Point(3, 132);
            this.dataGridViewCompra.Name = "dataGridViewCompra";
            this.dataGridViewCompra.Size = new System.Drawing.Size(419, 315);
            this.dataGridViewCompra.TabIndex = 1;
            // 
            // panelProveedor
            // 
            this.panelProveedor.Controls.Add(this.groupBoxProveedor);
            this.panelProveedor.Location = new System.Drawing.Point(428, 41);
            this.panelProveedor.Name = "panelProveedor";
            this.panelProveedor.Size = new System.Drawing.Size(367, 80);
            this.panelProveedor.TabIndex = 2;
            // 
            // groupBoxProveedor
            // 
            this.groupBoxProveedor.Controls.Add(this.txtDescripcion);
            this.groupBoxProveedor.Controls.Add(this.txtRuc);
            this.groupBoxProveedor.Controls.Add(this.label2);
            this.groupBoxProveedor.Controls.Add(this.label1);
            this.groupBoxProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProveedor.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProveedor.Name = "groupBoxProveedor";
            this.groupBoxProveedor.Size = new System.Drawing.Size(367, 80);
            this.groupBoxProveedor.TabIndex = 0;
            this.groupBoxProveedor.TabStop = false;
            this.groupBoxProveedor.Text = "Proveedor";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(97, 24);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(144, 20);
            this.txtRuc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruc";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(97, 52);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(264, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // panelFiltro
            // 
            this.panelFiltro.Controls.Add(this.groupBoxFiltro);
            this.panelFiltro.Location = new System.Drawing.Point(3, 41);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(419, 85);
            this.panelFiltro.TabIndex = 3;
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.btnBuscar);
            this.groupBoxFiltro.Controls.Add(this.dateTimePickerHasta);
            this.groupBoxFiltro.Controls.Add(this.dateTimePickerDesde);
            this.groupBoxFiltro.Controls.Add(this.label4);
            this.groupBoxFiltro.Controls.Add(this.label3);
            this.groupBoxFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFiltro.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(419, 85);
            this.groupBoxFiltro.TabIndex = 0;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtro de busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha final:";
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(84, 21);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 2;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(84, 49);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHasta.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(300, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 65);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 459);
            this.ControlBox = false;
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelProveedor);
            this.Controls.Add(this.dataGridViewCompra);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdenCompra";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Orden de compra";
            this.Resize += new System.EventHandler(this.FrmOrdenCompra_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).EndInit();
            this.panelProveedor.ResumeLayout(false);
            this.groupBoxProveedor.ResumeLayout(false);
            this.groupBoxProveedor.PerformLayout();
            this.panelFiltro.ResumeLayout(false);
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewCompra;
        private System.Windows.Forms.Panel panelProveedor;
        private System.Windows.Forms.GroupBox groupBoxProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Button btnBuscar;
    }
}