using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Sabroso
{
    public partial class FrmProducto : UIChildForm
    {
        private Context context = new Context();
        private string rutaImagenes;

        public FrmProducto()
        {
            InitializeComponent();
            this.Titulo = "Mantenimiento de Productos";
            this.MyDerivedType = typeof(FrmProducto);
            myCRUDButtonsProductos.ButtonEvent += MyCRUDButtonsProductos_ButtonEvent;
            myBasicControlEntity.PropertyChanged += MyBasicControlEntity_PropertyChanged;
            txtId.KeyPress += Control_KeyPress;
            txtCodigo.KeyPress += Control_KeyPress;
            txtDescripcion.KeyPress += Control_KeyPress;
            txtPrecio.KeyPress += Control_KeyPress;
            cmbCategoria.KeyPress += Control_KeyPress;
            this.KeyDown += new KeyEventHandler(FormKeyDown);
        }

        private void BloquearCampos(bool bloqueo)
        {
            txtCodigo.ReadOnly = bloqueo;
            txtDescripcion.ReadOnly = bloqueo;
            cmbCategoria.Enabled = !bloqueo;
            txtPrecio.ReadOnly = bloqueo;
            cmbMedida.Enabled = !bloqueo;
            buttonSeleccionarImagen.Enabled = !bloqueo;
            if (bloqueo == true)
            {
                if (myBasicControlEntity.Count < 1)
                {
                    cmbCategoria.SelectedItem = MyEnums.GetFromEnum(Categoria.Seleccione);
                    cmbMedida.SelectedItem = MyEnums.GetFromEnum(Medida.Seleccione);
                }
            }
        }

        private void buttonSeleccionarImagen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif | All files | *";
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                pictureBoxImagen.ImageLocation = fileName;
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.F6)
            {
                if (myCRUDButtonsProductos.DeleteEnabled)
                {
                    myCRUDButtonsProductos.Accion = Actions.Delete;
                    MyCRUDButtonsProductos_ButtonEvent(Actions.Delete);
                }
            }
            else if (e.KeyValue == (int)Keys.F5)
            {
                if (myCRUDButtonsProductos.SaveEnabled)
                {
                    myCRUDButtonsProductos.Accion = Actions.Save;
                    MyCRUDButtonsProductos_ButtonEvent(Actions.Save);
                }
            }
            else if (e.KeyValue == (int)Keys.F4)
            {
                if (myCRUDButtonsProductos.CancelEnabled)
                {
                    myCRUDButtonsProductos.Accion = Actions.Cancel;
                    MyCRUDButtonsProductos_ButtonEvent(Actions.Cancel);
                }
            }
            else if (e.KeyValue == (int)Keys.F3)
            {
                if (myCRUDButtonsProductos.EditEnabled)
                {
                    myCRUDButtonsProductos.Accion = Actions.Edit;
                    MyCRUDButtonsProductos_ButtonEvent(Actions.Edit);
                }
            }
            else if (e.KeyValue == (int)Keys.F2)
            {
                if (myCRUDButtonsProductos.NewEnabled)
                {
                    myCRUDButtonsProductos.Accion = Actions.New;
                    MyCRUDButtonsProductos_ButtonEvent(Actions.New);
                }
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                LoadData();
                LoadRutas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HaveUniqueViolation(string codigo)
        {
            var producto = context.Producto.Where(c => c.Codigo.Equals(codigo)).FirstOrDefault();
            var exists = (producto != null);
            if (exists)
            {
                string mensaje = "Ya existe un producto con el codigo ingresado: " + producto.Codigo + " - " + producto.Descripcion + "\n Por favor ingrese otro codigo";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            return exists;
        }

        private void LlenarCombos()
        {
            cmbCategoria.DisplayMember = "Description";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = Enum.GetValues(typeof(Categoria))
            .Cast<Enum>()
            .Select(value => new CustomAttribute
            (
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(CustomAttribute)) as CustomAttribute).Id,
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(CustomAttribute)) as CustomAttribute).Description
            )).OrderBy(item => item.Id).ToList();
            cmbMedida.DisplayMember = "Description";
            cmbMedida.ValueMember = "Id";
            cmbMedida.DataSource = Enum.GetValues(typeof(Medida))
            .Cast<Enum>()
            .Select(value => new CustomAttribute
            (
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(CustomAttribute)) as CustomAttribute).Id,
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(CustomAttribute)) as CustomAttribute).Description
            )).OrderBy(item => item.Id).ToList();
        }

        private void LoadData()
        {

            myBasicControlEntity.DisplayMember = "DisplayMember";
            myBasicControlEntity.DataSource = (from entry in context.Producto
                                               where entry.Status == Status.Activo
                                               select entry).ToList().ConvertAll(p => (Entity)p);

        }

        private void LoadRutas()
        {
            this.rutaImagenes = ConfigurationManager.AppSettings["folderimagenes"].ToString();
        }

        private void MyBasicControlEntity_EventoEntityChanged(object sender, EventArgs e)
        {
            try
            {
                var entity = (Producto)myBasicControlEntity.SelectedEntity;
                var haveEntity = (entity != null);
                myCRUDButtonsProductos.HaveSelectedEntity = haveEntity;
                if (haveEntity)
                {
                    Categoria categoria = entity.Categoria;
                    var type = categoria.GetType();
                    var name = Enum.GetName(type, categoria);
                    var atributo = type.GetField(name).GetCustomAttributes(false).OfType<CustomAttribute>().SingleOrDefault();
                    cmbCategoria.SelectedValue = atributo.Id;
                    groupBoxEntity.Text = "Producto seleccionado";
                    Medida medida = entity.Medida;
                    var type2 = medida.GetType();
                    var name2 = Enum.GetName(type, medida);
                    var atributo2 = type.GetField(name2).GetCustomAttributes(false).OfType<CustomAttribute>().SingleOrDefault();
                    cmbMedida.SelectedValue = atributo2.Id;

                    txtId.Text = entity.Id.ToString();
                    txtCodigo.Text = entity.Codigo;
                    txtDescripcion.Text = entity.Descripcion;
                    txtPrecio.DollarValue = entity.Precio;
                    pictureBoxImagen.ImageLocation = entity.RutaImagen;

                    myCRUDButtonsProductos.Accion = Actions.Cancel;
                    BloquearCampos(true);
                }
                else
                {
                    txtId.Clear();
                    txtCodigo.Clear();
                    txtPrecio.DollarValue = 0;
                    txtDescripcion.Clear();
                    Categoria categoria = Categoria.Seleccione;
                    var type = categoria.GetType();
                    var name = Enum.GetName(type, categoria);
                    var atributo = type.GetField(name).GetCustomAttributes(false).OfType<CustomAttribute>().SingleOrDefault();
                    cmbCategoria.SelectedValue = atributo.Id;
                    groupBoxEntity.Text = "Ingrese un nuevo producto";
                    Medida medida = Medida.Seleccione;
                    var type2 = categoria.GetType();
                    var name2 = Enum.GetName(type2, medida);
                    var atributo2 = type.GetField(name).GetCustomAttributes(false).OfType<CustomAttribute>().SingleOrDefault();
                    cmbMedida.SelectedValue = atributo2.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyBasicControlEntity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MyBasicControlEntity_EventoEntityChanged(null, null);
        }

        private void MyCRUDButtonsProductos_ButtonEvent(Actions accion)
        {
            switch (accion)
            {
                case Actions.New:
                    {
                        txtCodigo.Clear();
                        txtDescripcion.Clear();
                        txtId.Clear();
                        txtPrecio.Text = string.Empty;
                        cmbCategoria.SelectedIndex = 0;
                        cmbMedida.SelectedIndex = 0;
                        pictureBoxImagen.ImageLocation = string.Empty;
                        BloquearCampos(false);
                        txtCodigo.Focus();
                        break;
                    }
                case Actions.Cancel:
                    {
                        BloquearCampos(true);
                        myBasicControlEntity.Focus();
                        MyBasicControlEntity_EventoEntityChanged(null, null);
                        break;
                    }
                case Actions.Delete:
                    {
                        var entity = myBasicControlEntity.SelectedEntity;
                        entity.Status = Status.Inactivo;
                        int count = UtilsData.SaveContext(ref context);
                        if (count > 0)
                        {
                            LoadData();
                            MessageBox.Show("Registro eliminado correctamente", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (myBasicControlEntity.Count > 0)
                            {
                                myBasicControlEntity.Focus();
                            }
                            else
                            {
                                myCRUDButtonsProductos.Focus();
                            }
                        }
                        else
                        {
                            context = new Context();
                            LoadData();
                            myBasicControlEntity.ClearFilter();
                        }
                        break;
                    }
                case Actions.Edit:
                    {
                        BloquearCampos(false);
                        txtCodigo.Focus();
                        break;
                    }
                case Actions.Save:
                    {
                        decimal precio = txtPrecio.DollarValue;
                        string rutaImagen = string.Concat(this.rutaImagenes, DateTime.Now.ToString("yyyyMMdd hhmmss"));
                        if (string.IsNullOrEmpty(this.pictureBoxImagen.ImageLocation)) { rutaImagen = string.Empty; }
                        var entity = new Producto()
                        {
                            Codigo = txtCodigo.Text,
                            Categoria = ((Categoria)((CustomAttribute)cmbCategoria.SelectedItem).Id),
                            Descripcion = txtDescripcion.Text,
                            Medida = ((Medida)((CustomAttribute)cmbMedida.SelectedItem).Id),
                            Precio = precio,
                            Status = Status.Activo,
                            RutaImagen = rutaImagen
                        };
                        if (myCRUDButtonsProductos.Bandera == BanderaGuardar.Edit)
                        {
                            var entry = ((Producto)myBasicControlEntity.SelectedEntity);
                            if (entry.Codigo != entity.Codigo)
                            {
                                bool violation = HaveUniqueViolation(entity.Codigo);
                                if (violation)
                                {
                                    myCRUDButtonsProductos.Accion = Actions.Edit;
                                    return;
                                }
                            }
                            entry.Categoria = entity.Categoria;
                            entry.Codigo = entity.Codigo;
                            entry.Descripcion = entity.Descripcion;
                            entry.Medida = entity.Medida;
                            entry.Precio = entity.Precio;
                            entry.RutaImagen = entity.RutaImagen;
                        }
                        else if (myCRUDButtonsProductos.Bandera == BanderaGuardar.New)
                        {
                            bool violation = HaveUniqueViolation(entity.Codigo);
                            if (violation)
                            {
                                myCRUDButtonsProductos.Accion = Actions.New;
                                return;
                            }
                            context.Producto.Add(entity);
                        }
                        int count = UtilsData.SaveContext(ref context);
                        if (count > 0)
                        {
                            LoadData();
                            MessageBox.Show("Producto guardado correctamente", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (myBasicControlEntity.Count > 0)
                            {
                                myBasicControlEntity.Focus();
                            }
                            else
                            {
                                myCRUDButtonsProductos.Focus();
                            }
                        }
                        else
                        {
                            context = new Context();
                            LoadData();
                            myBasicControlEntity.ClearFilter();
                            MyBasicControlEntity_EventoEntityChanged(null, null);
                            if (!(myBasicControlEntity.Count > 0))
                            {
                                myCRUDButtonsProductos.Accion = Actions.Neutro;
                            }
                        }
                        BloquearCampos(true);
                        myBasicControlEntity.Focus();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void MyLabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
