﻿namespace Sabroso
{
    partial class MyLabel
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
            //components = new System.ComponentModel.Container();
            this.SuspendLayout();
            // 
            // MyButton
            // 
            this.Size = new System.Drawing.Size(123, 59);
            this.ResumeLayout(false);
            this.MouseEnter += MyLabel_MouseEnter;
            this.MouseLeave += MyLabel_MouseLeave;
        }

        #endregion
    }
}