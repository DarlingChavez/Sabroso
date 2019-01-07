using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabroso
{
    public partial class UIChildForm : Form
    {

        public string MenuName { get; set; }
        public string MenuTittle { get; set; }
        
        public string Titulo
        {
            set { labelTitulo.Text = value; }
        }
        
        public int SelectedIndex
        {
            get { return myBasicControlEntity.SelectedIndex; }
            set { myBasicControlEntity.SelectedIndex = value; }
        }

        public UIChildForm()
        {
            this.TopLevel = false;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public Type MyDerivedType { get; set; }
        private void MyLabelClose_Click(object sender, EventArgs e)
        {
            ((FrmMain)((Panel)this.Parent).Parent).CloseChild(MyDerivedType);
        }

        private void UIChildForm_Resize(object sender, EventArgs e)
        {
            CentrarTitulo();
        }

        protected void CentrarTitulo()
        {
            var anchoLabel = labelTitulo.Width;
            var anchoPanel = panelTop.Width;
            labelTitulo.Location = new Point((anchoPanel / 2 - labelTitulo.Width / 2), labelTitulo.Location.Y);
        }
    }
}
