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
    public partial class FrmMain : UIBasicForm
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Mover();
        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            var exists = System.IO.File.Exists(@"C:\sabroso\database.accdb");
            if (!exists)
            {
                ADOX.Catalog catalog = new ADOX.Catalog();
                catalog.Create(@"C:\sabroso\database.accdb");
            }
            FrmWelcome welcome = new FrmWelcome();
            welcome.ShowDialog(this);
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void volverALaPantallaDeBienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Esta a punto de reicniciar el sistema", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(typeof(FrmProducto));
        }

        private void OpenChild(Type type)
        {
            var frmChild = Activator.CreateInstance(type);
            //((Form)frmChild).MdiParent = this;
            ((Form)frmChild).TopLevel = false;
            panelMain.Controls.Add((Form)frmChild);
            ((Form)frmChild).WindowState = FormWindowState.Maximized;
            ((Form)frmChild).Show();
        }

        private void myLabelClose_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            var result = MessageBox.Show(this,"Seguro desea salir de la aplicación?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void myLabelMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
