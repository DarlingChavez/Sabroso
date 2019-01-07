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
            this.panelTop = new System.Windows.Forms.Panel();
            this.myBasicControlProducto = new Sabroso.MyBasicControl();
            this.myLabelClose = new Sabroso.MyLabel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelTop.Controls.Add(this.labelTitulo);
            this.panelTop.Controls.Add(this.myLabelClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(778, 29);
            this.panelTop.TabIndex = 0;
            // 
            // myBasicControlProducto
            // 
            this.myBasicControlProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.myBasicControlProducto.DataSource = null;
            this.myBasicControlProducto.Location = new System.Drawing.Point(3, 33);
            this.myBasicControlProducto.Name = "myBasicControlProducto";
            this.myBasicControlProducto.SelectedEntity = null;
            this.myBasicControlProducto.SelectedIndex = -1;
            this.myBasicControlProducto.Size = new System.Drawing.Size(246, 405);
            this.myBasicControlProducto.TabIndex = 1;
            // 
            // myLabelClose
            // 
            this.myLabelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myLabelClose.AutoSize = true;
            this.myLabelClose.FirstColor = System.Drawing.Color.Black;
            this.myLabelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabelClose.ForeColor = System.Drawing.Color.Black;
            this.myLabelClose.Location = new System.Drawing.Point(751, 0);
            this.myLabelClose.Name = "myLabelClose";
            this.myLabelClose.SecondColor = System.Drawing.Color.Red;
            this.myLabelClose.Size = new System.Drawing.Size(24, 24);
            this.myLabelClose.TabIndex = 2;
            this.myLabelClose.Text = "X";
            this.myLabelClose.Click += new System.EventHandler(this.myLabelClose_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(3, 6);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(177, 16);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Mantenimiento de productos";
            // 
            // FrmProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 464);
            this.Controls.Add(this.myBasicControlProducto);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mantenimiento de productos";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private MyBasicControl myBasicControlProducto;
        private MyLabel myLabelClose;
        private System.Windows.Forms.Label labelTitulo;
    }
}