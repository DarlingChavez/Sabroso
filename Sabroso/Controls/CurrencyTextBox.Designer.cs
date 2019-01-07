namespace Sabroso
{
    partial class CurrencyTextBox
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
            components = new System.ComponentModel.Container();
            //
            //CurrencyTextBox
            //
            this.KeyPress += CurrencyTextBox_KeyPress;
            this.Validated += CurrencyTextBox_Validated;
            this.Click += CurrencyTextBox_Click;
            this.Leave += CurrencyTextBox_Leave;
            //this.TextChanged += CurrencyTextBox_TextChanged;
        }

        #endregion
    }
}
