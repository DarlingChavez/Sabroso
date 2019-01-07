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
    public partial class MyButton : Button
    {
        private Color firstColor = Color.DarkBlue;
        private Color secondColor = Color.DarkOrange;
        
        public MyButton()
        {
            InitializeComponent();
            this.ForeColor = firstColor;
        }

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

        public Actions Accion { get; set; }

        private void MyButton_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = secondColor;
        }

        private void MyButton_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = firstColor;
        }

    }
}
