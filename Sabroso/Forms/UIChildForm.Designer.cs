namespace Sabroso
{
    partial class UIChildForm
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.myLabelClose = new Sabroso.MyLabel();
            this.myBasicControlEntity = new Sabroso.MyBasicControl();
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
            this.panelTop.Size = new System.Drawing.Size(849, 41);
            this.panelTop.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(3, 5);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(0, 31);
            this.labelTitulo.TabIndex = 3;
            // 
            // myLabelClose
            // 
            this.myLabelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myLabelClose.AutoSize = true;
            this.myLabelClose.FirstColor = System.Drawing.Color.Black;
            this.myLabelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabelClose.ForeColor = System.Drawing.Color.Black;
            this.myLabelClose.Location = new System.Drawing.Point(811, 4);
            this.myLabelClose.Name = "myLabelClose";
            this.myLabelClose.SecondColor = System.Drawing.Color.Red;
            this.myLabelClose.Size = new System.Drawing.Size(35, 33);
            this.myLabelClose.TabIndex = 2;
            this.myLabelClose.Text = "X";
            this.myLabelClose.Click += new System.EventHandler(this.MyLabelClose_Click);
            // 
            // myBasicControlEntity
            // 
            this.myBasicControlEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.myBasicControlEntity.DataSource = null;
            this.myBasicControlEntity.Location = new System.Drawing.Point(6, 47);
            this.myBasicControlEntity.Name = "myBasicControlEntity";
            this.myBasicControlEntity.SelectedIndex = -1;
            this.myBasicControlEntity.Size = new System.Drawing.Size(246, 302);
            this.myBasicControlEntity.TabIndex = 2;
            // 
            // UIChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 396);
            this.ControlBox = false;
            this.Controls.Add(this.myBasicControlEntity);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIChildForm";
            this.Text = "UIChildForm";
            this.Resize += new System.EventHandler(this.UIChildForm_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitulo;
        private MyLabel myLabelClose;
        public MyBasicControl myBasicControlEntity;
    }
}