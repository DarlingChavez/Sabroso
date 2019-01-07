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
    public partial class MyBasicControl : UserControl
    {
        public MyBasicControl()
        {
            InitializeComponent();
        }
        private List<Entity> dataSource;
        public List<Entity> DataSource
        {
            get {
                return dataSource;
            }
            set {
                dataSource = value;
                listBoxItems.DataSource = value;
            }
        }

        public Entity SelectedEntity
        {
            get { return ((Entity)listBoxItems.SelectedItem); }
            set { listBoxItems.SelectedItem = value; }
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
        public void ClearFilter()
        {
            textBoxFilter.Clear();
        }
    }
}
