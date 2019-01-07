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
    public partial class FrmBuscarEntidad : Form
    {
        public string Filtro { get; set; }
        public TipoEntidad Tipo { get; set; }
        public List<Entity> DataSource { get; set; }
        public Entity EntidadSeleccionada { get; set; }

        public FrmBuscarEntidad(TipoEntidad tipo,string filtro)
        {
            InitializeComponent();
            Filtro = filtro;
            Tipo = tipo;
            dataGridViewDatos.AutoGenerateColumns = false;
        }

        private void FrmBuscarEntidad_Load(object sender, EventArgs e)
        {
            using(Context context = new Context())
            {
                switch (Tipo)
                {
                    case TipoEntidad.Cliente:
                        DataSource = (from entity in context.Cliente
                                      where entity.Status == Status.Activo
                                      select entity).ToList().ConvertAll(cliente=>(Entity)cliente);
                        this.Text = "Buscar Cliente";
                        break;
                    case TipoEntidad.Proveedor:
                        DataSource = (from entity in context.Proveedor
                                      where entity.Status == Status.Activo
                                      select entity).ToList().ConvertAll(proveedor => (Entity)proveedor);
                        this.Text = "Buscar Proveedor";
                        break;
                    case TipoEntidad.Producto:
                        DataSource = (from entity in context.Producto
                                      where entity.Status == Status.Activo
                                      select entity).ToList().ConvertAll(producto => (Entity)producto);
                        this.Text = "Buscar Producto";
                        break;
                }
            }
            textBoxFiltro.Text = Filtro;
            if (dataGridViewDatos.DataSource == null)
                dataGridViewDatos.DataSource = DataSource;
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            dataGridViewDatos.DataSource = null;
            if(textBoxFiltro.Text == string.Empty)
            {
                dataGridViewDatos.DataSource = DataSource;
            }
            else
            {
                dataGridViewDatos.DataSource = (from entity in DataSource
                                                where entity.CodigoFilter.ToLower().Contains(textBoxFiltro.Text.ToLower())
                                                || entity.DisplayMember.ToLower().Contains(textBoxFiltro.Text.ToLower())
                                                select entity
                                                ).ToList();
            }
        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (dataGridViewDatos.Rows.Count < 1)
                    return;
                EntidadSeleccionada = (Entity)dataGridViewDatos.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            else if(e.KeyChar == (char)Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void dataGridViewDatos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EntidadSeleccionada = (Entity)dataGridViewDatos.SelectedRows[0].DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (dataGridViewDatos.Rows.Count < 1)
                return base.ProcessCmdKey(ref msg, keyData);
            int rowIndex = dataGridViewDatos.CurrentCell.RowIndex;
            if (keyData == Keys.Down)
            {
                if(rowIndex < dataGridViewDatos.Rows.Count-1)
                {
                    dataGridViewDatos.Rows[rowIndex + 1].Selected = true;
                    dataGridViewDatos.Rows[rowIndex + 1].Cells[0].Selected = true;
                }
                return true;
            }else if(keyData == Keys.Up)
            {
                if (rowIndex > 0)
                {
                    dataGridViewDatos.Rows[rowIndex - 1].Selected = true;
                    dataGridViewDatos.Rows[rowIndex - 1].Cells[0].Selected = true;
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
