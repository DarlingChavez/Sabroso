namespace Sabroso
{
    partial class FrmProducto
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
            this.myCRUDButtonsProductos = new Sabroso.MyCRUDButtons();
            this.groupBoxEntity = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new Sabroso.CurrencyTextBox();
            this.cmbMedida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxProductos = new System.Windows.Forms.PictureBox();
            this.groupBoxImagen = new System.Windows.Forms.GroupBox();
            this.buttonSeleccionarImagen = new System.Windows.Forms.Button();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.groupBoxEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).BeginInit();
            this.groupBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // myBasicControlEntity
            // 
            this.myBasicControlEntity.Size = new System.Drawing.Size(246, 498);
            this.myBasicControlEntity.EventoEntityChanged += new Sabroso.MyBasicControl.ValueChangeDelegate(this.MyBasicControlEntity_EventoEntityChanged);
            // 
            // myCRUDButtonsProductos
            // 
            this.myCRUDButtonsProductos.Accion = Sabroso.Actions.Neutro;
            this.myCRUDButtonsProductos.Bandera = Sabroso.BanderaGuardar.Zero;
            this.myCRUDButtonsProductos.HaveSelectedEntity = false;
            this.myCRUDButtonsProductos.Location = new System.Drawing.Point(258, 47);
            this.myCRUDButtonsProductos.Name = "myCRUDButtonsProductos";
            this.myCRUDButtonsProductos.Size = new System.Drawing.Size(493, 49);
            this.myCRUDButtonsProductos.TabIndex = 3;
            // 
            // groupBoxEntity
            // 
            this.groupBoxEntity.Controls.Add(this.txtPrecio);
            this.groupBoxEntity.Controls.Add(this.cmbMedida);
            this.groupBoxEntity.Controls.Add(this.label6);
            this.groupBoxEntity.Controls.Add(this.label5);
            this.groupBoxEntity.Controls.Add(this.label4);
            this.groupBoxEntity.Controls.Add(this.txtCodigo);
            this.groupBoxEntity.Controls.Add(this.cmbCategoria);
            this.groupBoxEntity.Controls.Add(this.txtDescripcion);
            this.groupBoxEntity.Controls.Add(this.txtId);
            this.groupBoxEntity.Controls.Add(this.label3);
            this.groupBoxEntity.Controls.Add(this.label2);
            this.groupBoxEntity.Controls.Add(this.label1);
            this.groupBoxEntity.Location = new System.Drawing.Point(258, 115);
            this.groupBoxEntity.Name = "groupBoxEntity";
            this.groupBoxEntity.Size = new System.Drawing.Size(336, 186);
            this.groupBoxEntity.TabIndex = 0;
            this.groupBoxEntity.TabStop = false;
            this.groupBoxEntity.Text = "Producto seleccionado";
            // 
            // txtPrecio
            // 
            this.txtPrecio.DollarValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrecio.Location = new System.Drawing.Point(95, 130);
            this.txtPrecio.MaxLength = 12;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.Text = "$0.00";
            // 
            // cmbMedida
            // 
            this.cmbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedida.Enabled = false;
            this.cmbMedida.FormattingEnabled = true;
            this.cmbMedida.Location = new System.Drawing.Point(95, 156);
            this.cmbMedida.Name = "cmbMedida";
            this.cmbMedida.Size = new System.Drawing.Size(121, 21);
            this.cmbMedida.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(95, 51);
            this.txtCodigo.MaxLength = 60;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(95, 103);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(216, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(95, 77);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(216, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(95, 25);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // pictureBoxProductos
            // 
            this.pictureBoxProductos.Image = global::Sabroso.Properties.Resources.comida;
            this.pictureBoxProductos.Location = new System.Drawing.Point(258, 307);
            this.pictureBoxProductos.Name = "pictureBoxProductos";
            this.pictureBoxProductos.Size = new System.Drawing.Size(475, 245);
            this.pictureBoxProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProductos.TabIndex = 5;
            this.pictureBoxProductos.TabStop = false;
            // 
            // groupBoxImagen
            // 
            this.groupBoxImagen.Controls.Add(this.pictureBoxImagen);
            this.groupBoxImagen.Controls.Add(this.buttonSeleccionarImagen);
            this.groupBoxImagen.Location = new System.Drawing.Point(607, 115);
            this.groupBoxImagen.Name = "groupBoxImagen";
            this.groupBoxImagen.Size = new System.Drawing.Size(299, 255);
            this.groupBoxImagen.TabIndex = 6;
            this.groupBoxImagen.TabStop = false;
            this.groupBoxImagen.Text = "Imagen";
            // 
            // buttonSeleccionarImagen
            // 
            this.buttonSeleccionarImagen.Location = new System.Drawing.Point(261, 9);
            this.buttonSeleccionarImagen.Name = "buttonSeleccionarImagen";
            this.buttonSeleccionarImagen.Size = new System.Drawing.Size(32, 23);
            this.buttonSeleccionarImagen.TabIndex = 1;
            this.buttonSeleccionarImagen.Text = "...";
            this.buttonSeleccionarImagen.UseVisualStyleBackColor = true;
            this.buttonSeleccionarImagen.Click += new System.EventHandler(this.buttonSeleccionarImagen_Click);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(6, 38);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(287, 211);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 2;
            this.pictureBoxImagen.TabStop = false;
            // 
            // FrmProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1077, 557);
            this.ControlBox = true;
            this.Controls.Add(this.groupBoxImagen);
            this.Controls.Add(this.pictureBoxProductos);
            this.Controls.Add(this.groupBoxEntity);
            this.Controls.Add(this.myCRUDButtonsProductos);
            this.KeyPreview = true;
            this.MenuName = "toolStripProducto";
            this.MenuTittle = "Productos";
            this.Name = "FrmProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mantenimiento de productos";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.Controls.SetChildIndex(this.myCRUDButtonsProductos, 0);
            this.Controls.SetChildIndex(this.groupBoxEntity, 0);
            this.Controls.SetChildIndex(this.myBasicControlEntity, 0);
            this.Controls.SetChildIndex(this.pictureBoxProductos, 0);
            this.Controls.SetChildIndex(this.groupBoxImagen, 0);
            this.groupBoxEntity.ResumeLayout(false);
            this.groupBoxEntity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).EndInit();
            this.groupBoxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCRUDButtons myCRUDButtonsProductos;
        private System.Windows.Forms.GroupBox groupBoxEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMedida;
        private System.Windows.Forms.PictureBox pictureBoxProductos;
        private CurrencyTextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.Button buttonSeleccionarImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
    }
}