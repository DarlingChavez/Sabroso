namespace Sabroso
{
    partial class FrmCliente
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
            this.myCRUDButtonsClientes = new Sabroso.MyCRUDButtons();
            this.groupBoxEntity = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxClientes = new System.Windows.Forms.PictureBox();
            this.groupBoxEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // myBasicControlEntity
            // 
            this.myBasicControlEntity.Size = new System.Drawing.Size(246, 498);
            this.myBasicControlEntity.EventoEntityChanged += new Sabroso.MyBasicControl.ValueChangeDelegate(this.MyBasicControlEntity_EventoEntityChanged);
            // 
            // myCRUDButtonsClientes
            // 
            this.myCRUDButtonsClientes.Accion = Sabroso.Actions.Neutro;
            this.myCRUDButtonsClientes.Bandera = Sabroso.BanderaGuardar.Zero;
            this.myCRUDButtonsClientes.HaveSelectedEntity = false;
            this.myCRUDButtonsClientes.Location = new System.Drawing.Point(258, 47);
            this.myCRUDButtonsClientes.Name = "myCRUDButtonsClientes";
            this.myCRUDButtonsClientes.Size = new System.Drawing.Size(493, 49);
            this.myCRUDButtonsClientes.TabIndex = 3;
            // 
            // groupBoxEntity
            // 
            this.groupBoxEntity.Controls.Add(this.label4);
            this.groupBoxEntity.Controls.Add(this.txtCedula);
            this.groupBoxEntity.Controls.Add(this.txtNombre);
            this.groupBoxEntity.Controls.Add(this.txtId);
            this.groupBoxEntity.Controls.Add(this.label2);
            this.groupBoxEntity.Controls.Add(this.label1);
            this.groupBoxEntity.Location = new System.Drawing.Point(258, 115);
            this.groupBoxEntity.Name = "groupBoxEntity";
            this.groupBoxEntity.Size = new System.Drawing.Size(336, 113);
            this.groupBoxEntity.TabIndex = 0;
            this.groupBoxEntity.TabStop = false;
            this.groupBoxEntity.Text = "Cliente seleccionado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula/Ruc";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(95, 51);
            this.txtCedula.MaxLength = 13;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(121, 20);
            this.txtCedula.TabIndex = 3;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 77);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(216, 20);
            this.txtNombre.TabIndex = 5;
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
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
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
            // pictureBoxClientes
            // 
            this.pictureBoxClientes.Image = global::Sabroso.Properties.Resources.cliente;
            this.pictureBoxClientes.Location = new System.Drawing.Point(258, 234);
            this.pictureBoxClientes.Name = "pictureBoxClientes";
            this.pictureBoxClientes.Size = new System.Drawing.Size(529, 318);
            this.pictureBoxClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClientes.TabIndex = 5;
            this.pictureBoxClientes.TabStop = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1077, 557);
            this.ControlBox = true;
            this.Controls.Add(this.pictureBoxClientes);
            this.Controls.Add(this.groupBoxEntity);
            this.Controls.Add(this.myCRUDButtonsClientes);
            this.KeyPreview = true;
            this.MenuName = "toolStripCliente";
            this.MenuTittle = "Clientes";
            this.Name = "FrmCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.Controls.SetChildIndex(this.myCRUDButtonsClientes, 0);
            this.Controls.SetChildIndex(this.groupBoxEntity, 0);
            this.Controls.SetChildIndex(this.myBasicControlEntity, 0);
            this.Controls.SetChildIndex(this.pictureBoxClientes, 0);
            this.groupBoxEntity.ResumeLayout(false);
            this.groupBoxEntity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCRUDButtons myCRUDButtonsClientes;
        private System.Windows.Forms.GroupBox groupBoxEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.PictureBox pictureBoxClientes;
    }
}