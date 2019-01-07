using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sabroso
{
    public partial class FrmVenta : Form
    {
        private Cliente consumidorFinal;
        private Cliente clienteActual = null;
        public string Titulo
        {
            set { labelTitulo.Text = value; }
        }
        public Cliente ClienteActual
        {
            get { return clienteActual; }
            set
            {
                clienteActual = value;
                if(clienteActual==null)
                {
                    txtClienteCedula.Text = string.Empty;
                    txtClienteNombre.Text = string.Empty;
                    return;
                }
                txtClienteCedula.Text = clienteActual.Cedula;
                txtClienteNombre.Text = clienteActual.Nombre;
            }
        }
        public FrmVenta()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.WindowState = FormWindowState.Maximized;
            Titulo = "Toma de pedidos";
            consumidorFinal = UtilsData.Get<Cliente>(1);
            ClienteActual = consumidorFinal;
        }

        private void MyLabelClose_Click(object sender, EventArgs e)
        {
            ((FrmMain)((Panel)this.Parent).Parent).CloseChild(typeof(FrmVenta));
        }

        protected void CentrarTitulo()
        {
            var anchoLabel = labelTitulo.Width;
            var anchoPanel = panelTop.Width;
            labelTitulo.Location = new Point((anchoPanel / 2 - labelTitulo.Width / 2), labelTitulo.Location.Y);
        }

        private void FrmVenta_Resize(object sender, EventArgs e)
        {
            CentrarTitulo();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            lblDetalle.Location = new Point((lblDetalle.Parent.Width / 2) - (lblDetalle.Width / 2), lblDetalle.Location.Y);
            GetProximaFactura();
            GetProductos();
        }

        private void GetProductos()
        {
            tabControlProductos.TabPages.Clear();
            foreach (Categoria categoria in Enum.GetValues(typeof(Categoria)))
            {
                if (categoria == Categoria.Seleccione)
                    continue;
                TabPage tabPage = new TabPage() { Name = "TabPage" + categoria.ToString(), Text = categoria.ToString() };
                tabControlProductos.TabPages.Add(tabPage);
                DataGridView gridView = new DataGridView()
                {
                    RowHeadersVisible = false,
                    ColumnHeadersVisible = false
                };
                gridView.AllowUserToAddRows = false;
                gridView.AllowUserToResizeColumns = false;
                gridView.AllowUserToResizeRows = false;
                var columna1 = new DataGridViewButtonColumn();
                columna1.Width = (tabPage.Width / 3) - 8;
                gridView.Columns.Add(columna1);
                var columna2 = new DataGridViewButtonColumn();
                columna2.Width = (tabPage.Width / 3) - 8;
                gridView.Columns.Add(columna2);
                var columna3 = new DataGridViewButtonColumn();
                columna3.Width = (tabPage.Width / 3) - 8;
                gridView.Columns.Add(columna3);
                tabPage.Controls.Add(gridView);
                gridView.Dock = DockStyle.Fill;
                gridView.CellContentClick += GridView_CellContentClick;
                gridView.GridColor = Color.White;
                gridView.BackgroundColor = Color.White;
                Context context = new Context();
                var productoList = context.Producto.Where(p => p.Categoria == categoria).ToList();
                if (productoList != null && productoList.Count > 0)
                {
                    for (int i = 0; i <= productoList.Count - 1; i += 3)
                    {
                        int index = gridView.Rows.Add();
                        gridView.Rows[index].Cells[0].Value = productoList[i].Descripcion;
                        gridView.Rows[index].Cells[0].Tag = productoList[i];
                        gridView.Rows[index].Height = 90;

                        try
                        {
                            gridView.Rows[index].Cells[0 + 1].Value = productoList[i + 1].Descripcion;
                            gridView.Rows[index].Cells[0 + 1].Tag = productoList[i + 1];

                            gridView.Rows[index].Height = 90;

                            gridView.Rows[index].Cells[0 + 2].Value = productoList[i + 2].Descripcion;
                            gridView.Rows[index].Cells[0 + 2].Tag = productoList[i + 2];

                            gridView.Rows[index].Height = 90;

                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            continue;
                        }
                    }
                    int maxRowIndex = gridView.Rows.Count - 1;
                    try
                    {
                        if (gridView.Rows[maxRowIndex].Cells[2].Tag == null)
                        {
                            DataGridViewImageCell imageCell = new DataGridViewImageCell();
                            imageCell.Value = Properties.Resources.fondo;
                            imageCell.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            gridView.Rows[maxRowIndex].Cells[2] = imageCell;
                        }
                        if (gridView.Rows[maxRowIndex].Cells[1].Tag == null)
                        {
                            DataGridViewImageCell imageCell = new DataGridViewImageCell();
                            imageCell.Value = Properties.Resources.fondo;
                            imageCell.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            gridView.Rows[maxRowIndex].Cells[1] = imageCell;
                        }
                    }catch(Exception )
                    {

                    }
                }
            }
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            var cell = grid[e.ColumnIndex, e.RowIndex];
            var producto = cell.Tag as Producto;
            if (producto != null)
            {
                AgregarProducto(producto);
            }
        }

        private void SumarTotal()
        {
            decimal total = 0;
            foreach (DetalleFactura entity in detalleFacturaBindingSource)
            {
                total += entity.Subtotal;
            }
            lblTotal.Text = total.ToString("C");
        }

        private void GetProximaFactura()
        {
            int maxId = UtilsData.MaxId<CabeceraFactura>() + 1;
            labelNumeroFactura.Text = (maxId).ToString().PadLeft(9, '0');
        }
        private void checkBoxNuevo_CheckedChanged(object sender, EventArgs e)
        {
            txtClienteCedula.ReadOnly = !checkBoxNuevo.Checked;
            txtClienteNombre.ReadOnly = !checkBoxNuevo.Checked;
            txtBuscarCliente.Enabled = !checkBoxNuevo.Checked;
            btnBuscarCliente.Enabled = !checkBoxNuevo.Checked;
            if (checkBoxNuevo.Checked)
            {
                txtClienteNombre.Clear();
                txtClienteCedula.Clear();
                txtClienteCedula.Focus();
                ClienteActual = null;
                txtBuscarCliente.Clear();
            }
            else
            {
                ClienteActual = consumidorFinal;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarEntidad frmBuscarEntidad = new FrmBuscarEntidad(TipoEntidad.Cliente, txtBuscarCliente.Text);
            var result = frmBuscarEntidad.ShowDialog();
            if (result == DialogResult.OK)
            {
                ClienteActual = (Cliente)frmBuscarEntidad.EntidadSeleccionada;
                txtBuscarCliente.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea limpiar el progreso de facturacion?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro desea cerrar la ventana de punto de venta, se perderan los avances realizados", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ((FrmMain)((Panel)this.Parent).Parent).CloseChild(typeof(FrmVenta));
            }
        }

        private void DgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var entity = detalleFacturaBindingSource[e.RowIndex];
                ((DetalleFactura)entity).Subtotal = ((DetalleFactura)entity).Cantidad * ((DetalleFactura)entity).PrecioUnitario;
                SumarTotal();
            }
        }

        private void DgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                detalleFacturaBindingSource.RemoveAt(e.RowIndex);
                SumarTotal();
            }
        }

        private void btnRefreshProdcuto_Click(object sender, EventArgs e)
        {
            GetProductos();
        }

        private void DgvDetalle_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 1)
                {
                    var fondo = this.BackColor;
                    using (SolidBrush brush = new SolidBrush(fondo))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                        e.Paint(e.CellBounds, DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.SelectionBackground | DataGridViewPaintParts.Focus);
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                btnBuscarCliente_Click(null, null);
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmBuscarEntidad frmBuscarEntidad = new FrmBuscarEntidad(TipoEntidad.Producto, string.Empty);
            var result = frmBuscarEntidad.ShowDialog();
            if (result == DialogResult.OK)
            {
                var producto = (Producto)frmBuscarEntidad.EntidadSeleccionada;
                AgregarProducto(producto);
            }
        }

        private void AgregarProducto(Producto producto)
        {
            var entry = new DetalleFactura()
            {
                Cantidad = 1,
                Producto = producto,
                IdProducto = producto.Id,
                PrecioUnitario = producto.Precio,
                Subtotal = producto.Precio * 1
            };
            int index = 0;
            foreach (var entity in detalleFacturaBindingSource)
            {
                if (((DetalleFactura)entity).IdProducto == entry.IdProducto)
                {
                    ((DetalleFactura)entity).Cantidad += 1;
                    ((DetalleFactura)entity).Subtotal = ((DetalleFactura)entity).Cantidad * ((DetalleFactura)entity).PrecioUnitario;
                    index = detalleFacturaBindingSource.IndexOf(entity);
                    SumarTotal();
                    goto Refresh;
                }
            }
            detalleFacturaBindingSource.Add(entry);
            displayMemberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SumarTotal();
            DgvDetalle.CurrentCell = DgvDetalle.Rows[detalleFacturaBindingSource.Count - 1].Cells[3];
            DgvDetalle.BeginEdit(true);
            return;
            Refresh:
            DgvDetalle.CurrentCell = DgvDetalle.Rows[index].Cells[5];
            DgvDetalle.RefreshEdit();
            DgvDetalle.CurrentCell = DgvDetalle.Rows[index].Cells[3];
            DgvDetalle.BeginEdit(true);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            bool valido = Validar();
            if (!valido)
            {
                MessageBox.Show("Falta un campo del cliente por ingresar, por favor revise", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool guardo = GuardarFactura();
            if (guardo)
            {
                var result = MessageBox.Show("Se guardo la factura en la base de datos, Desea imprimirla?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    bool imprimio = ImprimirFactura();
                    if (imprimio)
                    {
                        MessageBox.Show("Listo! Se agrego a la cola de inmpresion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Limpiar();
            }
        }

        private bool GuardarFactura()
        {
            using(Context context = new Context())
            {
                Cliente cliente;
                if (clienteActual != consumidorFinal)
                {
                    if (checkBoxNuevo.Checked)
                    {
                        cliente = new Cliente()
                        {
                            Nombre = txtClienteNombre.Text.Trim(),
                            Cedula = txtClienteCedula.Text.Trim(),
                            Status = Status.Activo
                        };
                        context.Cliente.Add(cliente);
                    }
                    else
                    {
                        cliente = context.Cliente.Where(c => c.Id == ClienteActual.Id).FirstOrDefault();
                    }
                }
                else
                {
                    cliente = context.Cliente.Where(c => c.Id == 1).FirstOrDefault();
                }
                CabeceraFactura cabeceraFactura = new CabeceraFactura()
                {
                    Fecha = DateTime.Today,
                    Status = Status.Activo,
                    Cliente = cliente
                };
                decimal total = 0;
                foreach (DetalleFactura entry in detalleFacturaBindingSource)
                {
                    total += (entry.PrecioUnitario * entry.Cantidad);
                    cabeceraFactura.DetalleFactura.Add(new DetalleFactura() {
                        IdProducto = entry.IdProducto,
                        Cantidad = entry.Cantidad,
                        PrecioUnitario = entry.PrecioUnitario,
                        Subtotal = entry.Subtotal,
                        Status = Status.Activo
                    });
                }
                cabeceraFactura.Total = total;
                cabeceraFactura.IdCliente = cliente.Id;
                context.CabeceraFactura.Add(cabeceraFactura);
                context.SaveChanges();
                return true;
            }
        }
        private bool Validar()
        {
            if (checkBoxNuevo.Checked)
            {
                if(txtClienteCedula.Text.Trim() == string.Empty || txtClienteNombre.Text.Trim() == string.Empty)
                {
                    return false;
                }
            }
            return true;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            bool valido = Validar();
            if(!valido)
            {
                MessageBox.Show("Falta un campo del cliente por ingresar, por favor revise","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            bool imprimio = ImprimirFactura();
            if (imprimio)
            {
                var result = MessageBox.Show("Se agrego a la cola de impresion, Desea guardar la factura?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    bool guardo = GuardarFactura();
                    if (guardo)
                    {
                        MessageBox.Show("Listo! Se guardo correctamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
            }
        }
        private bool ImprimirFactura()
        {
            ReportParameter p1 = new ReportParameter("ReportParameterFecha", DateTime.Now.ToString());
            ReportParameter p2 = new ReportParameter("ReportParameterCedula", txtClienteCedula.Text);
            ReportParameter p3 = new ReportParameter("ReportParameterNombre", txtClienteNombre.Text);
            ReportParameter[] arrayParametros = new ReportParameter[] { p1, p2, p3 };
            decimal total = 0;
            foreach (DetalleFactura entity in detalleFacturaBindingSource)
            {
                total += (entity.Cantidad * entity.PrecioUnitario);
            }
            var lista = arrayParametros.ToList();
            lista.Add(new ReportParameter("ReportParameterTotal", total.ToString("C")));
            arrayParametros = lista.ToArray();
            try
            {
                ReportUtils.Imprimir("Sabroso.Reports.RptFactura.rdlc", "DsFactura", detalleFacturaBindingSource, arrayParametros);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void Limpiar()
        {
            checkBoxNuevo.Checked = false;
            DgvDetalle.Rows.Clear();
            lblTotal.Text = ((decimal)0).ToString("C");
            ClienteActual = consumidorFinal;
        }
        
        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
    }
}
