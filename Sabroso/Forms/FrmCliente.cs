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
    public partial class FrmCliente : UIChildForm
    {
        private Context context = new Context();
        public FrmCliente()
        {
            InitializeComponent();
            this.Titulo = "Mantenimiento de Clientes";
            this.MyDerivedType = typeof(FrmCliente);
            myCRUDButtonsClientes.ButtonEvent += MyCRUDButtonsClientes_ButtonEvent;
            myBasicControlEntity.PropertyChanged += MyBasicControlEntity_PropertyChanged;
            txtId.KeyPress += Control_KeyPress;
            txtCedula.KeyPress += Control_KeyPress;
            txtNombre.KeyPress += Control_KeyPress;
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
                if (myCRUDButtonsClientes.DeleteEnabled)
                {
                    myCRUDButtonsClientes.Accion = Actions.Delete;
                    MyCRUDButtonsClientes_ButtonEvent(Actions.Delete);
                }
            }
            else if (e.KeyValue == (int)Keys.F5)
            {
                if (myCRUDButtonsClientes.SaveEnabled)
                {
                    myCRUDButtonsClientes.Accion = Actions.Save;
                    MyCRUDButtonsClientes_ButtonEvent(Actions.Save);
                }
            }
            else if (e.KeyValue == (int)Keys.F4)
            {
                if (myCRUDButtonsClientes.CancelEnabled)
                {
                    myCRUDButtonsClientes.Accion = Actions.Cancel;
                    MyCRUDButtonsClientes_ButtonEvent(Actions.Cancel);
                }
            }
            else if (e.KeyValue == (int)Keys.F3)
            {
                if (myCRUDButtonsClientes.EditEnabled)
                {
                    myCRUDButtonsClientes.Accion = Actions.Edit;
                    MyCRUDButtonsClientes_ButtonEvent(Actions.Edit);
                }
            }
            else if (e.KeyValue == (int)Keys.F2)
            {
                if (myCRUDButtonsClientes.NewEnabled)
                {
                    myCRUDButtonsClientes.Accion = Actions.New;
                    MyCRUDButtonsClientes_ButtonEvent(Actions.New);
                }
            }
        }

        private void MyBasicControlEntity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MyBasicControlEntity_EventoEntityChanged(null, null);
        }

        private void MyCRUDButtonsClientes_ButtonEvent(Actions accion)
        {
            switch (accion)
            {
                case Actions.New:
                    {
                        txtCedula.Clear();
                        txtNombre.Clear();
                        txtId.Clear();
                        
                        BloquearCampos(false);
                        txtCedula.Focus();
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
                                myCRUDButtonsClientes.Focus();
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
                        txtCedula.Focus();
                        break;
                    }
                case Actions.Save:
                    {
                        var entity = new Cliente()
                        {
                            Cedula = txtCedula.Text,
                            Nombre = txtNombre.Text,
                            Status = Status.Activo
                        };
                        if (myCRUDButtonsClientes.Bandera == BanderaGuardar.Edit)
                        {
                            var entry = ((Cliente)myBasicControlEntity.SelectedEntity);
                            if(entry.Cedula != entity.Cedula)
                            {
                                bool violation = HaveUniqueViolation(entity.Cedula);
                                if (violation)
                                {
                                    myCRUDButtonsClientes.Accion = Actions.Edit;
                                    return;
                                }
                            }
                            entry.Cedula = entity.Cedula;
                            entry.Nombre = entity.Nombre;
                        }
                        else if (myCRUDButtonsClientes.Bandera == BanderaGuardar.New)
                        {
                            bool violation = HaveUniqueViolation(entity.Cedula);
                            if (violation)
                            {
                                myCRUDButtonsClientes.Accion = Actions.New;
                                return;
                            }
                            context.Cliente.Add(entity);
                        }
                        int count = UtilsData.SaveContext(ref context);
                        if (count > 0)
                        {
                            LoadData();
                            MessageBox.Show("Cliente guardado correctamente", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (myBasicControlEntity.Count > 0)
                            {
                                myBasicControlEntity.Focus();
                            }
                            else
                            {
                                myCRUDButtonsClientes.Focus();
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
                                myCRUDButtonsClientes.Accion = Actions.Neutro;
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

        private bool HaveUniqueViolation(string cedula)
        {
            var cliente = context.Cliente.Where(c => c.Cedula.Equals(cedula)).FirstOrDefault();
            var exists = (cliente!=null);
            if (exists)
            {
                string mensaje = "Ya existe un cliente con la cedula ingresada: " + cliente.Cedula + " - " + cliente.Nombre + "\n Por favor ingrese otra cedula";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
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
            if(ex.InnerException!= null)
            {
                return GetMensajeError(ex.InnerException);
            }
            return ex.Message;
        }
        private void LoadData()
        {

            myBasicControlEntity.DisplayMember = "DisplayMember";
            myBasicControlEntity.DataSource = (from entry in context.Cliente
                                               where entry.Status == Status.Activo && entry.Id!=1
                                               select entry).ToList().ConvertAll(p => (Entity)p);

        }

        private void BloquearCampos(bool bloqueo)
        {
            txtCedula.ReadOnly = bloqueo;
            txtNombre.ReadOnly = bloqueo;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
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
                var entity = (Cliente)myBasicControlEntity.SelectedEntity;
                var haveEntity = (entity != null);
                myCRUDButtonsClientes.HaveSelectedEntity = haveEntity;
                if (haveEntity)
                {
                    groupBoxEntity.Text = "Cliente seleccionado";
                    txtId.Text = entity.Id.ToString();
                    txtCedula.Text = entity.Cedula;
                    txtNombre.Text = entity.Nombre;

                    myCRUDButtonsClientes.Accion = Actions.Cancel;
                    BloquearCampos(true);
                }
                else
                {
                    txtId.Clear();
                    txtCedula.Clear();
                    txtNombre.Clear();
                    
                    groupBoxEntity.Text = "Ingrese un nuevo Cliente";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
