using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = Int32.Parse(txtValue1.Text) + Int32.Parse(txtValue2.Text);
            txtResult.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            txtValue1.Text = string.Empty;
            txtValue2.Text = string.Empty;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var result = Int32.Parse(txtValue1.Text) - Int32.Parse(txtValue2.Text);
            txtResult.Text = result.ToString();
        }
    }
}
