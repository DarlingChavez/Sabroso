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
            try
            {
                configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
                CrearBase();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
            string value = configuration.AppSettings.Settings["expiro"].Value;
            if (value.Equals("1"))
            {
                FrmValidacion frmValidacion = new FrmValidacion();
                frmValidacion.ShowDialog();
            }
            else
            {
                FrmWelcome welcome = new FrmWelcome();
                welcome.ShowDialog(this);
                this.menuStripMenu.Visible = true;
            }
        }
        System.Configuration.Configuration configuration;
        private void CrearBase()
        {
            string cs = configuration.ConnectionStrings.ConnectionStrings["default"].ConnectionString;
            string[] arrayString = cs.Split(';');
            string ds = (from cadena in arrayString where cadena.ToLower().Contains("data source") select cadena).First();
            string[] arrayDs = ds.Split('=');
            string fileName = arrayDs[1];
            string[] dirs = fileName.Split('\\');
            int length = dirs.Length;
            string path = string.Empty;
            for (int i = 0; i <= (length - 2); i++)
            {
                path += dirs[i] + '\\';
            }
            var existsDir = System.IO.Directory.Exists(@path);
            if (!existsDir)
            {
                System.IO.Directory.CreateDirectory(@path);
            }
            var exists = System.IO.File.Exists(@path + "database.accdb");
            if (!exists)
            {
                ADOX.Catalog catalog = new ADOX.Catalog();
                catalog.Create(cs);
                using(Context context = new Context())
                {
                    context.Database.ExecuteSqlCommand("Insert into Cliente(Cedula,Nombre,Status) values('9999999999','Consumidor Final',0)");
                }
            }
        }
        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void volverALaPantallaDeBienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Esta a punto de reiniciar el sistema", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
            foreach(object obj in panelMain.Controls)
            {
                if(obj.GetType() == type)
                {
                    ((Form)obj).Show();
                    ((Form)obj).Refresh();
                    goto CrearMenu;
                }
            }
            var frmChild = Activator.CreateInstance(type);
            ((Form)frmChild).TopLevel = false;
            panelMain.Controls.Add((Form)frmChild);
            ((Form)frmChild).WindowState = FormWindowState.Maximized;
            ((Form)frmChild).Show();
            CrearMenu:
            formulariosToolStripMenuItem.DropDownItems.Clear();
            foreach (object obj in panelMain.Controls)
            {
                try
                {
                    var formulario = ((UIChildForm)obj);
                    if (formulario.GetType() != type)
                        formulario.Hide();
                    ToolStripItem item = new ToolStripMenuItem()
                    {
                        Name = formulario.MenuName,
                        Text = formulario.MenuTittle,
                        Tag = formulario.GetType()
                    };
                    item.Click += Item_Click;
                    formulariosToolStripMenuItem.DropDownItems.Add(item);
                }
                catch(InvalidCastException)
                {
                    var formulario = ((Form)obj);
                    formulario.ShowIcon = false;
                    if (formulario.GetType() != type)
                        formulario.Hide();
                    ToolStripItem item = new ToolStripMenuItem()
                    {
                        Name = "toolStripItem"+formulario.Name,
                        Text = formulario.Text,
                        Tag = formulario.GetType()
                    };
                    item.Click += Item_Click;
                    formulariosToolStripMenuItem.DropDownItems.Add(item);
                }
            }
        }
        private void Item_Click(object sender, EventArgs e)
        {
            var type = ((Type)((ToolStripItem)sender).Tag);
            OpenChild(type);
        }
        protected internal void CloseChild(Type type)
        {
            foreach(object obj in panelMain.Controls)
                if(obj.GetType() == type)
                    ((Form)obj).Close();
            foreach (ToolStripItem item in formulariosToolStripMenuItem.DropDownItems)
                if (((Type)item.Tag) == type)
                {
                    formulariosToolStripMenuItem.DropDownItems.Remove(item);
                    return;
                }
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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(typeof(FrmCliente));
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(typeof(FrmProveedor));
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(typeof(FrmOrdenCompra));
        }

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(typeof(FrmVenta));
        }
    }
}
