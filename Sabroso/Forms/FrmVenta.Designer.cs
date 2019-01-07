namespace Sabroso
{
    partial class FrmVenta
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.checkBoxNuevo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.txtClienteCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumeroFactura = new System.Windows.Forms.Label();
            this.groupBoxNumeroFactura = new System.Windows.Forms.GroupBox();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.panelDetalleFill = new System.Windows.Forms.Panel();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageColumnRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.displayMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubTotalString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDetalleTop = new System.Windows.Forms.Panel();
            this.btnProducto = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnRefreshProdcuto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.tabControlProductos = new System.Windows.Forms.TabControl();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnSalir = new Sabroso.MyButton();
            this.panelTop.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxNumeroFactura.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.panelDetalleFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).BeginInit();
            this.panelDetalleTop.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gold;
            this.panelTop.Controls.Add(this.labelTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(878, 35);
            this.panelTop.TabIndex = 1;
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
            // panelCliente
            // 
            this.panelCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCliente.Controls.Add(this.groupBoxCliente);
            this.panelCliente.Location = new System.Drawing.Point(5, 41);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(652, 63);
            this.panelCliente.TabIndex = 2;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.btnBuscarCliente);
            this.groupBoxCliente.Controls.Add(this.label3);
            this.groupBoxCliente.Controls.Add(this.txtBuscarCliente);
            this.groupBoxCliente.Controls.Add(this.checkBoxNuevo);
            this.groupBoxCliente.Controls.Add(this.label2);
            this.groupBoxCliente.Controls.Add(this.txtClienteNombre);
            this.groupBoxCliente.Controls.Add(this.txtClienteCedula);
            this.groupBoxCliente.Controls.Add(this.label1);
            this.groupBoxCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCliente.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(652, 63);
            this.groupBoxCliente.TabIndex = 0;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(431, 14);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(30, 20);
            this.btnBuscarCliente.TabIndex = 7;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(325, 14);
            this.txtBuscarCliente.MaxLength = 13;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCliente.TabIndex = 5;
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            // 
            // checkBoxNuevo
            // 
            this.checkBoxNuevo.AutoSize = true;
            this.checkBoxNuevo.Location = new System.Drawing.Point(18, 16);
            this.checkBoxNuevo.Name = "checkBoxNuevo";
            this.checkBoxNuevo.Size = new System.Drawing.Size(130, 17);
            this.checkBoxNuevo.TabIndex = 4;
            this.checkBoxNuevo.Text = "Agregar nuevo cliente";
            this.checkBoxNuevo.UseVisualStyleBackColor = true;
            this.checkBoxNuevo.CheckedChanged += new System.EventHandler(this.checkBoxNuevo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteNombre.Location = new System.Drawing.Point(325, 37);
            this.txtClienteNombre.MaxLength = 60;
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.ReadOnly = true;
            this.txtClienteNombre.Size = new System.Drawing.Size(318, 20);
            this.txtClienteNombre.TabIndex = 2;
            // 
            // txtClienteCedula
            // 
            this.txtClienteCedula.Location = new System.Drawing.Point(86, 37);
            this.txtClienteCedula.MaxLength = 13;
            this.txtClienteCedula.Name = "txtClienteCedula";
            this.txtClienteCedula.ReadOnly = true;
            this.txtClienteCedula.Size = new System.Drawing.Size(143, 20);
            this.txtClienteCedula.TabIndex = 1;
            this.txtClienteCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula/Ruc";
            // 
            // labelNumeroFactura
            // 
            this.labelNumeroFactura.AutoSize = true;
            this.labelNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroFactura.Location = new System.Drawing.Point(17, 16);
            this.labelNumeroFactura.Name = "labelNumeroFactura";
            this.labelNumeroFactura.Size = new System.Drawing.Size(188, 37);
            this.labelNumeroFactura.TabIndex = 4;
            this.labelNumeroFactura.Text = "000000000";
            // 
            // groupBoxNumeroFactura
            // 
            this.groupBoxNumeroFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNumeroFactura.Controls.Add(this.labelNumeroFactura);
            this.groupBoxNumeroFactura.Location = new System.Drawing.Point(663, 41);
            this.groupBoxNumeroFactura.Name = "groupBoxNumeroFactura";
            this.groupBoxNumeroFactura.Size = new System.Drawing.Size(210, 63);
            this.groupBoxNumeroFactura.TabIndex = 5;
            this.groupBoxNumeroFactura.TabStop = false;
            this.groupBoxNumeroFactura.Text = "#Factura";
            // 
            // panelDetalle
            // 
            this.panelDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetalle.Controls.Add(this.panelDetalleFill);
            this.panelDetalle.Controls.Add(this.panelDetalleTop);
            this.panelDetalle.Location = new System.Drawing.Point(5, 104);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(381, 394);
            this.panelDetalle.TabIndex = 6;
            // 
            // panelDetalleFill
            // 
            this.panelDetalleFill.Controls.Add(this.DgvDetalle);
            this.panelDetalleFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalleFill.Location = new System.Drawing.Point(0, 39);
            this.panelDetalleFill.Name = "panelDetalleFill";
            this.panelDetalleFill.Size = new System.Drawing.Size(381, 355);
            this.panelDetalleFill.TabIndex = 2;
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.AllowUserToAddRows = false;
            this.DgvDetalle.AllowUserToDeleteRows = false;
            this.DgvDetalle.AllowUserToResizeColumns = false;
            this.DgvDetalle.AllowUserToResizeRows = false;
            this.DgvDetalle.AutoGenerateColumns = false;
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ImageColumnRemove,
            this.displayMemberDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.ColumnSubTotalString,
            this.idProductoDataGridViewTextBoxColumn});
            this.DgvDetalle.DataSource = this.detalleFacturaBindingSource;
            this.DgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDetalle.Location = new System.Drawing.Point(0, 0);
            this.DgvDetalle.MultiSelect = false;
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.RowHeadersVisible = false;
            this.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalle.Size = new System.Drawing.Size(381, 355);
            this.DgvDetalle.TabIndex = 0;
            this.DgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellContentClick);
            this.DgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellEndEdit);
            this.DgvDetalle.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvDetalle_CellPainting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // ImageColumnRemove
            // 
            this.ImageColumnRemove.HeaderText = "";
            this.ImageColumnRemove.Image = global::Sabroso.Properties.Resources.limpiar1;
            this.ImageColumnRemove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ImageColumnRemove.Name = "ImageColumnRemove";
            this.ImageColumnRemove.ReadOnly = true;
            this.ImageColumnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ImageColumnRemove.Width = 30;
            // 
            // displayMemberDataGridViewTextBoxColumn
            // 
            this.displayMemberDataGridViewTextBoxColumn.DataPropertyName = "DisplayMember";
            this.displayMemberDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.displayMemberDataGridViewTextBoxColumn.Name = "displayMemberDataGridViewTextBoxColumn";
            this.displayMemberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioString";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColumnSubTotalString
            // 
            this.ColumnSubTotalString.DataPropertyName = "SubTotalString";
            this.ColumnSubTotalString.HeaderText = "SubTotal";
            this.ColumnSubTotalString.Name = "ColumnSubTotalString";
            this.ColumnSubTotalString.ReadOnly = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.Visible = false;
            // 
            // detalleFacturaBindingSource
            // 
            this.detalleFacturaBindingSource.DataSource = typeof(Sabroso.DetalleFactura);
            // 
            // panelDetalleTop
            // 
            this.panelDetalleTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetalleTop.Controls.Add(this.btnProducto);
            this.panelDetalleTop.Controls.Add(this.lblDetalle);
            this.panelDetalleTop.Controls.Add(this.btnRefreshProdcuto);
            this.panelDetalleTop.Controls.Add(this.lblTotal);
            this.panelDetalleTop.Controls.Add(this.label4);
            this.panelDetalleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetalleTop.Location = new System.Drawing.Point(0, 0);
            this.panelDetalleTop.Name = "panelDetalleTop";
            this.panelDetalleTop.Size = new System.Drawing.Size(381, 39);
            this.panelDetalleTop.TabIndex = 1;
            // 
            // btnProducto
            // 
            this.btnProducto.BackgroundImage = global::Sabroso.Properties.Resources.producto;
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto.Location = new System.Drawing.Point(50, 3);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(41, 31);
            this.btnProducto.TabIndex = 4;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(137, 13);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(148, 16);
            this.lblDetalle.TabIndex = 3;
            this.lblDetalle.Text = "Detalle de la factura";
            // 
            // btnRefreshProdcuto
            // 
            this.btnRefreshProdcuto.BackgroundImage = global::Sabroso.Properties.Resources.refresh;
            this.btnRefreshProdcuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshProdcuto.Location = new System.Drawing.Point(3, 3);
            this.btnRefreshProdcuto.Name = "btnRefreshProdcuto";
            this.btnRefreshProdcuto.Size = new System.Drawing.Size(41, 31);
            this.btnRefreshProdcuto.TabIndex = 2;
            this.btnRefreshProdcuto.UseVisualStyleBackColor = true;
            this.btnRefreshProdcuto.Click += new System.EventHandler(this.btnRefreshProdcuto_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(301, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$ 0.00";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total a pagar:";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.Controls.Add(this.tabControlProductos);
            this.panelBotones.Location = new System.Drawing.Point(392, 104);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(378, 394);
            this.panelBotones.TabIndex = 9;
            // 
            // tabControlProductos
            // 
            this.tabControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProductos.Location = new System.Drawing.Point(0, 0);
            this.tabControlProductos.Name = "tabControlProductos";
            this.tabControlProductos.SelectedIndex = 0;
            this.tabControlProductos.Size = new System.Drawing.Size(378, 394);
            this.tabControlProductos.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Quitar";
            this.dataGridViewImageColumn1.Image = global::Sabroso.Properties.Resources.remove;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackgroundImage = global::Sabroso.Properties.Resources.imprimir;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(776, 197);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 69);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundImage = global::Sabroso.Properties.Resources.limpiar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(776, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 69);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturar.BackgroundImage = global::Sabroso.Properties.Resources.facturar;
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturar.Location = new System.Drawing.Point(776, 110);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(90, 69);
            this.btnFacturar.TabIndex = 7;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Accion = Sabroso.Actions.New;
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FirstColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(776, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.SecondColor = System.Drawing.Color.Red;
            this.btnSalir.Size = new System.Drawing.Size(90, 69);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.groupBoxNumeroFactura);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.Resize += new System.EventHandler(this.FrmVenta_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxNumeroFactura.ResumeLayout(false);
            this.groupBoxNumeroFactura.PerformLayout();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalleFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).EndInit();
            this.panelDetalleTop.ResumeLayout(false);
            this.panelDetalleTop.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClienteCedula;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumeroFactura;
        private System.Windows.Forms.GroupBox groupBoxNumeroFactura;
        private System.Windows.Forms.CheckBox checkBoxNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelDetalleTop;
        private System.Windows.Forms.Panel panelDetalleFill;
        private System.Windows.Forms.Panel panelBotones;
        private Sabroso.MyButton btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TabControl tabControlProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource detalleFacturaBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnRefreshProdcuto;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ImageColumnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubTotalString;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnProducto;
    }
}