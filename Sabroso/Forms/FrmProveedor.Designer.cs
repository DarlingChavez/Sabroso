namespace Sabroso
{
    partial class FrmProveedor
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
            this.myCRUDButtonsProveedores = new Sabroso.MyCRUDButtons();
            this.groupBoxEntity = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxProveedores = new System.Windows.Forms.PictureBox();
            this.groupBoxEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // myBasicControlEntity
            // 
            this.myBasicControlEntity.Size = new System.Drawing.Size(246, 498);
            this.myBasicControlEntity.EventoEntityChanged += new Sabroso.MyBasicControl.ValueChangeDelegate(this.MyBasicControlEntity_EventoEntityChanged);
            // 
            // myCRUDButtonsProveedores
            // 
            this.myCRUDButtonsProveedores.Accion = Sabroso.Actions.Neutro;
            this.myCRUDButtonsProveedores.Bandera = Sabroso.BanderaGuardar.Zero;
            this.myCRUDButtonsProveedores.HaveSelectedEntity = false;
            this.myCRUDButtonsProveedores.Location = new System.Drawing.Point(258, 47);
            this.myCRUDButtonsProveedores.Name = "myCRUDButtonsProveedores";
            this.myCRUDButtonsProveedores.Size = new System.Drawing.Size(493, 49);
            this.myCRUDButtonsProveedores.TabIndex = 3;
            // 
            // groupBoxEntity
            // 
            this.groupBoxEntity.Controls.Add(this.label4);
            this.groupBoxEntity.Controls.Add(this.txtRuc);
            this.groupBoxEntity.Controls.Add(this.txtDescripcion);
            this.groupBoxEntity.Controls.Add(this.txtId);
            this.groupBoxEntity.Controls.Add(this.label2);
            this.groupBoxEntity.Controls.Add(this.label1);
            this.groupBoxEntity.Location = new System.Drawing.Point(258, 115);
            this.groupBoxEntity.Name = "groupBoxEntity";
            this.groupBoxEntity.Size = new System.Drawing.Size(336, 113);
            this.groupBoxEntity.TabIndex = 0;
            this.groupBoxEntity.TabStop = false;
            this.groupBoxEntity.Text = "Proveedor seleccionado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ruc";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(95, 51);
            this.txtRuc.MaxLength = 13;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.ReadOnly = true;
            this.txtRuc.Size = new System.Drawing.Size(121, 20);
            this.txtRuc.TabIndex = 3;
            this.txtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRuc_KeyPress);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
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
            // pictureBoxProveedores
            // 
            this.pictureBoxProveedores.Image = global::Sabroso.Properties.Resources.proveedor;
            this.pictureBoxProveedores.Location = new System.Drawing.Point(258, 234);
            this.pictureBoxProveedores.Name = "pictureBoxProveedores";
            this.pictureBoxProveedores.Size = new System.Drawing.Size(423, 311);
            this.pictureBoxProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProveedores.TabIndex = 5;
            this.pictureBoxProveedores.TabStop = false;
            // 
            // FrmProveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1077, 557);
            this.ControlBox = true;
            this.Controls.Add(this.pictureBoxProveedores);
            this.Controls.Add(this.groupBoxEntity);
            this.Controls.Add(this.myCRUDButtonsProveedores);
            this.KeyPreview = true;
            this.MenuName = "toolStripProveedor";
            this.MenuTittle = "Proveedores";
            this.Name = "FrmProveedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mantenimiento de Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.Controls.SetChildIndex(this.myCRUDButtonsProveedores, 0);
            this.Controls.SetChildIndex(this.groupBoxEntity, 0);
            this.Controls.SetChildIndex(this.myBasicControlEntity, 0);
            this.Controls.SetChildIndex(this.pictureBoxProveedores, 0);
            this.groupBoxEntity.ResumeLayout(false);
            this.groupBoxEntity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCRUDButtons myCRUDButtonsProveedores;
        private System.Windows.Forms.GroupBox groupBoxEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.PictureBox pictureBoxProveedores;
    }
}