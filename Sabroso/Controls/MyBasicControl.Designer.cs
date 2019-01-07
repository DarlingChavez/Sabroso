namespace Sabroso
{
    partial class MyBasicControl
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.panelFill = new System.Windows.Forms.Panel();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.entityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textBoxFilter);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(246, 21);
            this.panelTop.TabIndex = 0;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilter.Location = new System.Drawing.Point(0, 0);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(246, 20);
            this.textBoxFilter.TabIndex = 0;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.listBoxItems);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 21);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(246, 377);
            this.panelFill.TabIndex = 1;
            // 
            // listBoxItems
            // 
            this.listBoxItems.DataSource = this.entityBindingSource;
            this.listBoxItems.DisplayMember = "DisplayMember";
            this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(0, 0);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(246, 377);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.ValueMember = "Id";
            // 
            // entityBindingSource
            // 
            this.entityBindingSource.DataSource = typeof(Sabroso.Entity);
            // 
            // MyBasicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.Name = "MyBasicControl";
            this.Size = new System.Drawing.Size(246, 398);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.BindingSource entityBindingSource;
    }
}
