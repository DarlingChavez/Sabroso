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

namespace Sabroso
{
    public partial class FrmProveedor : UIChildForm
    {
        private Context context = new Context();
        public FrmProveedor()
        {
            InitializeComponent();
            this.Titulo = "Mantenimiento de Proveedores";
            this.MyDerivedType = typeof(FrmProveedor);
            myCRUDButtonsProveedores.ButtonEvent += MyCRUDButtonsProveedores_ButtonEvent;
            myBasicControlEntity.PropertyChanged += MyBasicControlEntity_PropertyChanged;
            txtId.KeyPress += Control_KeyPress;
            txtRuc.KeyPress += Control_KeyPress;
            txtDescripcion.KeyPress += Control_KeyPress;
            this.KeyDown += new KeyEventHandler(FormKeyDown);
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
                if (myCRUDButtonsProveedores.DeleteEnabled)
                {
                    myCRUDButtonsProveedores.Accion = Actions.Delete;
                    MyCRUDButtonsProveedores_ButtonEvent(Actions.Delete);
                }
            }
            else if (e.KeyValue == (int)Keys.F5)
            {
                if (myCRUDButtonsProveedores.SaveEnabled)
                {
                    myCRUDButtonsProveedores.Accion = Actions.Save;
                    MyCRUDButtonsProveedores_ButtonEvent(Actions.Save);
                }
            }
            else if (e.KeyValue == (int)Keys.F4)
            {
                if (myCRUDButtonsProveedores.CancelEnabled)
                {
                    myCRUDButtonsProveedores.Accion = Actions.Cancel;
                    MyCRUDButtonsProveedores_ButtonEvent(Actions.Cancel);
                }
            }
            else if (e.KeyValue == (int)Keys.F3)
            {
                if (myCRUDButtonsProveedores.EditEnabled)
                {
                    myCRUDButtonsProveedores.Accion = Actions.Edit;
                    MyCRUDButtonsProveedores_ButtonEvent(Actions.Edit);
                }
            }
            else if (e.KeyValue == (int)Keys.F2)
            {
                if (myCRUDButtonsProveedores.NewEnabled)
                {
                    myCRUDButtonsProveedores.Accion = Actions.New;
                    MyCRUDButtonsProveedores_ButtonEvent(Actions.New);
                }
            }
        }

        private void MyBasicControlEntity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MyBasicControlEntity_EventoEntityChanged(null, null);
        }

        private void MyCRUDButtonsProveedores_ButtonEvent(Actions accion)
        {
            switch (accion)
            {
                case Actions.New:
                    {
                        txtRuc.Clear();
                        txtDescripcion.Clear();
                        txtId.Clear();

                        BloquearCampos(false);
                        txtRuc.Focus();
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
                        int count = SaveContext();
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
                                myCRUDButtonsProveedores.Focus();
                            }
                        }
                        break;
                    }
                case Actions.Edit:
                    {
                        BloquearCampos(false);
                        txtRuc.Focus();
                        break;
                    }
                case Actions.Save:
                    {
                        var entity = new Proveedor()
                        {
                            Ruc = txtRuc.Text,
                            Descripcion = txtDescripcion.Text,
                            Status = Status.Activo
                        };
                        if (myCRUDButtonsProveedores.Bandera == BanderaGuardar.Edit)
                        {
                            var entry = ((Proveedor)myBasicControlEntity.SelectedEntity);
                            if (entry.Ruc != entity.Ruc)
                            {
                                bool violation = HaveUniqueViolation(entity.Ruc);
                                if (violation)
                                {
                                    myCRUDButtonsProveedores.Accion = Actions.Edit;
                                    return;
                                }
                            }
                            entry.Ruc = entity.Ruc;
                            entry.Descripcion = entity.Descripcion;
                        }
                        else if (myCRUDButtonsProveedores.Bandera == BanderaGuardar.New)
                        {
                            bool violation = HaveUniqueViolation(entity.Ruc);
                            if (violation)
                            {
                                myCRUDButtonsProveedores.Accion = Actions.New;
                                return;
                            }
                            context.Proveedor.Add(entity);
                        }
                        int count = SaveContext();
                        if (count > 0)
                        {
                            LoadData();
                            MessageBox.Show("Proveedor guardado correctamente", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (myBasicControlEntity.Count > 0)
                            {
                                myBasicControlEntity.Focus();
                            }
                            else
                            {
                                myCRUDButtonsProveedores.Focus();
                            }
                        }
                        else
                        {
                            MyBasicControlEntity_EventoEntityChanged(null, null);
                            if (!(myBasicControlEntity.Count > 0))
                            {
                                myCRUDButtonsProveedores.Accion = Actions.Neutro;
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

        private bool HaveUniqueViolation(string Ruc)
        {
            var Proveedor = context.Proveedor.Where(c => c.Ruc.Equals(Ruc)).FirstOrDefault();
            var exists = (Proveedor != null);
            if (exists)
            {
                string mensaje = "Ya existe un Proveedor con la Ruc ingresada: " + Proveedor.Ruc + " - " + Proveedor.Descripcion + "\n Por favor ingrese otra Ruc";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuc.Focus();
            }
            return exists;
        }

        private int SaveContext()
        {
            int count = 0;
            try
            {
                count = context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show(ve.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        context = new Context();
                        LoadData();
                        myBasicControlEntity.ClearFilter();
                        return count;
                    }
                }
            }
            catch (Exception ex2)
            {
                string mensaje = GetMensajeError(ex2);
                MessageBox.Show(mensaje, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                context = new Context();
                LoadData();
                myBasicControlEntity.ClearFilter();
            }
            return count;
        }
        private string GetMensajeError(Exception ex)
        {
            if (ex.InnerException != null)
            {
                return GetMensajeError(ex.InnerException);
            }
            return ex.Message;
        }
        private void LoadData()
        {

            myBasicControlEntity.DisplayMember = "DisplayMember";
            myBasicControlEntity.DataSource = (from entry in context.Proveedor
                                               where entry.Status == Status.Activo
                                               select entry).ToList().ConvertAll(p => (Entity)p);

        }

        private void BloquearCampos(bool bloqueo)
        {
            txtRuc.ReadOnly = bloqueo;
            txtDescripcion.ReadOnly = bloqueo;
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyLabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyBasicControlEntity_EventoEntityChanged(object sender, EventArgs e)
        {
            try
            {
                var entity = (Proveedor)myBasicControlEntity.SelectedEntity;
                var haveEntity = (entity != null);
                myCRUDButtonsProveedores.HaveSelectedEntity = haveEntity;
                if (haveEntity)
                {
                    groupBoxEntity.Text = "Proveedor seleccionado";
                    txtId.Text = entity.Id.ToString();
                    txtRuc.Text = entity.Ruc;
                    txtDescripcion.Text = entity.Descripcion;

                    myCRUDButtonsProveedores.Accion = Actions.Cancel;
                    BloquearCampos(true);
                }
                else
                {
                    txtId.Clear();
                    txtRuc.Clear();
                    txtDescripcion.Clear();

                    groupBoxEntity.Text = "Ingrese un nuevo Proveedor";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
