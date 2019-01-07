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
    public partial class MyLabel : Label
    {
        private Color firstColor = Color.DarkBlue;
        private Color secondColor = Color.DarkOrange;

        public Color FirstColor
        {
            get { return firstColor; }
            set { firstColor = value; }
        }
        public Color SecondColor
        {
            get { return secondColor; }
            set { secondColor = value; }
        }

        public MyLabel()
        {
            InitializeComponent();
            this.ForeColor = firstColor;
        }

        private void MyLabel_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = secondColor;
        }

        private void MyLabel_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = firstColor;
        }

    }
}
