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
    public partial class FrmWelcome : UIBasicForm
    {
        private Point location;
        private bool move;
        public FrmWelcome()
        {
            InitializeComponent();
            this.Mover();
            
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //metroLabelDetalle.Text = MyDictionary.MyLabels.HomeDetalleLabel;
        }

        private void myButtonExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void myButtonAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog(this);
        }

        private void myButtonStart_Click(object sender, EventArgs e)
        {
            //FrmMain frmMain = new FrmMain();
            //frmMain.Show();
            //this.Hide();
            this.Close();
        }
        
    }
}
