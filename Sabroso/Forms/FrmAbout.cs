﻿using System;
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
    public partial class FrmAbout : UIBasicForm
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void myButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
