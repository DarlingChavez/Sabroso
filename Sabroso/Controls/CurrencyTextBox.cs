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
    public partial class CurrencyTextBox : TextBox
    {
        private decimal mDollarValue;
        public decimal DollarValue
        {
            get { return mDollarValue; }
            set { mDollarValue = value; this.Text = value.ToString("C"); }
        }
        public CurrencyTextBox()
        {
            InitializeComponent();
            DollarValue = 0;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);
        }
        private void CurrencyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers, decimals and control characters
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && this.Text.Contains("."))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && this.Text.Length < 1)
            {
                e.Handled = true;
            }
        }
        private void CurrencyTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                // format the value as currency
                //Decimal dTmp = Convert.ToDecimal(this.Text);
                //this.Text = dTmp.ToString();
            }
            catch { }
        }
        private void CurrencyTextBox_Click(object sender, EventArgs e)
        {
            this.Text = mDollarValue.ToString();
            if (this.Text == "0")
                this.Clear();
            this.SelectionStart = this.Text.Length;
        }
        private void CurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //DollarValue = Convert.ToDecimal(this.Text);
            }
            catch { }
        }
        private void CurrencyTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                DollarValue = Convert.ToDecimal(this.Text);
            }
            catch { }
        }

        protected void Clean()
        {
            mDollarValue = 0;
        }
    }
}
