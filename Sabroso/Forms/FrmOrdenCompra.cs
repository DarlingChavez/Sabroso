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
    public partial class FrmOrdenCompra : Form
    {

        public string Titulo
        {
            set { labelTitulo.Text = value; }
        }

        public FrmOrdenCompra()
        {
            InitializeComponent();
            TopLevel = false;
            this.WindowState = FormWindowState.Maximized;
            Titulo = "Orden de compra";
            var anchoLabel = labelTitulo.Width;
            var anchoPanel = panelTop.Width;
            labelTitulo.Location = new Point((anchoPanel / 2 - labelTitulo.Width / 2), labelTitulo.Location.Y);
        }
        
        protected void CentrarTitulo()
        {
            var anchoLabel = labelTitulo.Width;
            var anchoPanel = panelTop.Width;
            labelTitulo.Location = new Point((anchoPanel / 2 - labelTitulo.Width / 2), labelTitulo.Location.Y);
        }

        private void FrmOrdenCompra_Resize(object sender, EventArgs e)
        {
            CentrarTitulo();
        }
    }
}
