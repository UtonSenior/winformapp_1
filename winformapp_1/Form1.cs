using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformapp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String name = tbName.Text;
            //MessageBox.Show("Hello World, "+ name +", is now available...");
            lblAnswer.Text = $" Hello {name}. You are welcome here!";
        }
    }
}
