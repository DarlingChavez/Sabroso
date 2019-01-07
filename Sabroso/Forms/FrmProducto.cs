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
    public partial class FrmProducto : UIBasicForm
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Context context = new Context();
            myBasicControlProducto.DataSource = (from entity in context.Producto select entity).ToList().ConvertAll(p => (Entity)p);
        }

        private void myLabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
