namespace Sabroso
{
    partial class FrmWelcome
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxIcono = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.myButtonExit = new Sabroso.MyButton();
            this.myButtonAbout = new Sabroso.MyButton();
            this.myButtonStart = new Sabroso.MyButton();
            this.metroLabelDetalle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myButtonFacturar = new Sabroso.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Navy;
            this.panelTop.Location = new System.Drawing.Point(0, -4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(647, 19);
            this.panelTop.TabIndex = 5;
            // 
            // pictureBoxIcono
            // 
            this.pictureBoxIcono.BackColor = System.Drawing.Color.Navy;
            this.pictureBoxIcono.Image = global::Sabroso.Properties.Resources.cinta;
            this.pictureBoxIcono.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxIcono.Name = "pictureBoxIcono";
            this.pictureBoxIcono.Size = new System.Drawing.Size(132, 115);
            this.pictureBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcono.TabIndex = 6;
            this.pictureBoxIcono.TabStop = false;
            // 
            // labelHome
            // 
            this.labelHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelHome.Location = new System.Drawing.Point(255, 18);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(232, 37);
            this.labelHome.TabIndex = 6;
            this.labelHome.Text = "EL SABROSO";
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHome.Image = global::Sabroso.Properties.Resources.linguini;
            this.pictureBoxHome.Location = new System.Drawing.Point(192, 71);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(338, 349);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 0;
            this.pictureBoxHome.TabStop = false;
            // 
            // myButtonExit
            // 
            this.myButtonExit.Accion = Sabroso.Actions.New;
            this.myButtonExit.FirstColor = System.Drawing.Color.DarkBlue;
            this.myButtonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.myButtonExit.Location = new System.Drawing.Point(23, 355);
            this.myButtonExit.Name = "myButtonExit";
            this.myButtonExit.SecondColor = System.Drawing.Color.DarkOrange;
            this.myButtonExit.Size = new System.Drawing.Size(114, 40);
            this.myButtonExit.TabIndex = 3;
            this.myButtonExit.Text = "Salir";
            this.myButtonExit.UseVisualStyleBackColor = true;
            this.myButtonExit.Click += new System.EventHandler(this.myButtonExit_Click);
            // 
            // myButtonAbout
            // 
            this.myButtonAbout.Accion = Sabroso.Actions.New;
            this.myButtonAbout.FirstColor = System.Drawing.Color.DarkBlue;
            this.myButtonAbout.ForeColor = System.Drawing.Color.DarkBlue;
            this.myButtonAbout.Location = new System.Drawing.Point(23, 292);
            this.myButtonAbout.Name = "myButtonAbout";
            this.myButtonAbout.SecondColor = System.Drawing.Color.DarkOrange;
            this.myButtonAbout.Size = new System.Drawing.Size(114, 40);
            this.myButtonAbout.TabIndex = 2;
            this.myButtonAbout.Text = "Acerca de nosotros";
            this.myButtonAbout.UseVisualStyleBackColor = true;
            this.myButtonAbout.Click += new System.EventHandler(this.myButtonAbout_Click);
            // 
            // myButtonStart
            // 
            this.myButtonStart.Accion = Sabroso.Actions.New;
            this.myButtonStart.FirstColor = System.Drawing.Color.DarkBlue;
            this.myButtonStart.ForeColor = System.Drawing.Color.DarkBlue;
            this.myButtonStart.Location = new System.Drawing.Point(23, 177);
            this.myButtonStart.Name = "myButtonStart";
            this.myButtonStart.SecondColor = System.Drawing.Color.DarkOrange;
            this.myButtonStart.Size = new System.Drawing.Size(114, 40);
            this.myButtonStart.TabIndex = 0;
            this.myButtonStart.Text = "Ingresar";
            this.myButtonStart.UseVisualStyleBackColor = true;
            this.myButtonStart.Click += new System.EventHandler(this.myButtonStart_Click);
            // 
            // metroLabelDetalle
            // 
            this.metroLabelDetalle.AutoSize = true;
            this.metroLabelDetalle.Location = new System.Drawing.Point(220, 55);
            this.metroLabelDetalle.Name = "metroLabelDetalle";
            this.metroLabelDetalle.Size = new System.Drawing.Size(288, 13);
            this.metroLabelDetalle.TabIndex = 7;
            this.metroLabelDetalle.Text = "Sistema para la administración de restaurantes y comedores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 12);
            this.panel2.TabIndex = 8;
            // 
            // myButtonFacturar
            // 
            this.myButtonFacturar.Accion = Sabroso.Actions.New;
            this.myButtonFacturar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.myButtonFacturar.FirstColor = System.Drawing.Color.DarkBlue;
            this.myButtonFacturar.ForeColor = System.Drawing.Color.DarkBlue;
            this.myButtonFacturar.Location = new System.Drawing.Point(23, 235);
            this.myButtonFacturar.Name = "myButtonFacturar";
            this.myButtonFacturar.SecondColor = System.Drawing.Color.DarkOrange;
            this.myButtonFacturar.Size = new System.Drawing.Size(114, 40);
            this.myButtonFacturar.TabIndex = 9;
            this.myButtonFacturar.Text = "Facturar";
            this.myButtonFacturar.UseVisualStyleBackColor = true;
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 433);
            this.Controls.Add(this.myButtonFacturar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroLabelDetalle);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pictureBoxIcono);
            this.Controls.Add(this.myButtonExit);
            this.Controls.Add(this.myButtonAbout);
            this.Controls.Add(this.myButtonStart);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.pictureBoxHome);
            this.MaximizeBox = false;
            this.Name = "FrmWelcome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Label labelHome;
        private MyButton myButtonStart;
        private MyButton myButtonAbout;
        private MyButton myButtonExit;
        private System.Windows.Forms.PictureBox pictureBoxIcono;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label metroLabelDetalle;
        private System.Windows.Forms.Panel panel2;
        private MyButton myButtonFacturar;
    }
}

