using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabroso
{
    public partial class MyCRUDButtons : UserControl, INotifyPropertyChanged
    {
        public MyCRUDButtons()
        {
            InitializeComponent();
            PropertyChanged += MyCRUDButtons_PropertyChanged;
        }
        public delegate void ButtonDelegate(Actions accion);
        public event ButtonDelegate ButtonEvent;
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void MyCRUDButtons_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (accion)
            {
                case Actions.Cancel:
                    if (!HaveSelectedEntity)
                    {
                        AplicarNeutro();
                        break;
                    }
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    break;
                case Actions.New:
                    btnNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    Bandera = BanderaGuardar.New;
                    break;
                case Actions.Delete:
                    if (!HaveSelectedEntity)
                    {
                        AplicarNeutro();
                        break;
                    }
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    Bandera = BanderaGuardar.Read;
                    break;
                case Actions.Save:
                    btnNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    break;
                case Actions.Edit:
                    btnNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    Bandera = BanderaGuardar.Edit;
                    break;
                default :
                    AplicarNeutro();
                    break;
            }
        }
        private void AplicarNeutro()
        {
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = haveSelectedEntity;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            Bandera = BanderaGuardar.Zero;
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            var accion = ((MyButton)sender).Accion;
            Accion = accion;
            ButtonEvent?.Invoke(accion);
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
        
        private Actions accion = Actions.Neutro;
        public Actions Accion
        {
            get { return accion; }
            set {
                if (value != accion)
                {
                    accion = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Accion"));
                }
            }
        }
        private BanderaGuardar bandera = BanderaGuardar.Zero;
        public BanderaGuardar Bandera
        {
            get { return bandera; }
            set { bandera = value; }
        }

        private bool haveSelectedEntity;
        public bool HaveSelectedEntity
        {
            get { return haveSelectedEntity; }
            set {
                haveSelectedEntity = value;
                OnPropertyChanged(new PropertyChangedEventArgs("HaveSelectedEntity"));
            }
        }

        public bool DeleteEnabled
        {
            get { return this.btnDelete.Enabled; }
        }
        public bool SaveEnabled
        {
            get { return this.btnSave.Enabled; }
        }
        public bool CancelEnabled
        {
            get { return this.btnCancel.Enabled; }
        }
        public bool EditEnabled
        {
            get { return this.btnEdit.Enabled; }
        }
        public bool NewEnabled
        {
            get { return this.btnNew.Enabled; }
        }
    }
}
