namespace Sabroso
{
    partial class MyCRUDButtons
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNew = new Sabroso.MyButton();
            this.btnEdit = new Sabroso.MyButton();
            this.btnCancel = new Sabroso.MyButton();
            this.btnSave = new Sabroso.MyButton();
            this.btnDelete = new Sabroso.MyButton();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Accion = Sabroso.Actions.New;
            this.btnNew.FirstColor = System.Drawing.Color.DarkBlue;
            this.btnNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.SecondColor = System.Drawing.Color.DarkOrange;
            this.btnNew.Size = new System.Drawing.Size(92, 40);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Accion = Sabroso.Actions.Edit;
            this.btnEdit.Enabled = false;
            this.btnEdit.FirstColor = System.Drawing.Color.DarkBlue;
            this.btnEdit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEdit.Location = new System.Drawing.Point(101, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.SecondColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.Size = new System.Drawing.Size(92, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Accion = Sabroso.Actions.Cancel;
            this.btnCancel.Enabled = false;
            this.btnCancel.FirstColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.Location = new System.Drawing.Point(198, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.SecondColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.Size = new System.Drawing.Size(92, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSave
            // 
            this.btnSave.Accion = Sabroso.Actions.Save;
            this.btnSave.Enabled = false;
            this.btnSave.FirstColor = System.Drawing.Color.DarkBlue;
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.Location = new System.Drawing.Point(296, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.SecondColor = System.Drawing.Color.DarkOrange;
            this.btnSave.Size = new System.Drawing.Size(92, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Accion = Sabroso.Actions.Delete;
            this.btnDelete.Enabled = false;
            this.btnDelete.FirstColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.Location = new System.Drawing.Point(394, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.SecondColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Size = new System.Drawing.Size(92, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button_Click);
            // 
            // MyCRUDButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Name = "MyCRUDButtons";
            this.Size = new System.Drawing.Size(493, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton btnNew;
        private MyButton btnEdit;
        private MyButton btnCancel;
        private MyButton btnSave;
        private MyButton btnDelete;
    }
}
