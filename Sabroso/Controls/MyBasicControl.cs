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
    public partial class MyBasicControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
        public MyBasicControl()
        {
            InitializeComponent();
        }
        private object dataSource;
        public object DataSource
        {
            get {
                return dataSource;
            }
            set {
                dataSource = value;
                listBoxItems.DataSource = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SelectedEntity"));
            }
        }

        public Entity SelectedEntity
        {
            get { try { return ((Entity)listBoxItems.SelectedItem); } catch { return null; } }
            set {
                if(value!= listBoxItems.SelectedItem)
                {
                    listBoxItems.SelectedItem = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("SelectedEntity"));
                }
            }
        }

        public int SelectedIndex
        {
            get
            {
                return listBoxItems.SelectedIndex;
            }
            set
            {
                listBoxItems.SelectedIndex = value;
            }
        }

        public BindingSource MyBindingSource
        {
            get { return entityBindingSource; }
            set { entityBindingSource = value; }
        }
        public string DisplayMember
        {
            get { return listBoxItems.DisplayMember; }
            set { listBoxItems.DisplayMember = value; }
        }
        public string ValueMember
        {
            get { return listBoxItems.ValueMember; }
            set { listBoxItems.ValueMember = value; }
        }
        public int Count
        {
            get { return listBoxItems.Items.Count; }
        }

        public void ClearFilter()
        {
            textBoxFilter.Clear();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxFilter.Text.Trim().ToLower();
            var datosFiltrados = ((List<Entity>)dataSource)
                .Where(entiy => entiy.DisplayMember.ToLower().Contains(filtro)
                || entiy.CodigoFilter.Contains(textBoxFilter.Text)).ToList();
            listBoxItems.DataSource = datosFiltrados;
            if(datosFiltrados.Count<1)
                EventoEntityChanged(sender, e);
        }
        public delegate void ValueChangeDelegate(object sender, EventArgs e);
        public event ValueChangeDelegate EventoEntityChanged;
        private void listBoxItems_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                EventoEntityChanged(sender, e);
            }
            catch (NullReferenceException) { }
        }
    }
}
