using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthesis_assignment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnProductPage_Click(object sender, EventArgs e)
        {
            this.Hide ();
            ProductForm productform = new ProductForm();
            productform.ShowDialog();
        }
    }
}
