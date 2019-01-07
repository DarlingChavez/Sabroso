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
    public partial class UIBasicForm : Form
    {
        public UIBasicForm()
        {
            InitializeComponent();
        }
        private bool move;
        private Point location;

        public void Mover()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(MyButton))
                {
                    control.MouseDown += Control_MouseDown;
                    control.MouseMove += Control_MouseMove;
                    control.MouseUp += Control_MouseUp;
                }
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.Location = new Point(MousePosition.X - location.X, MousePosition.Y - location.Y);
            }
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - Location.Y);
            move = true;
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
