using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS_Eatery
{
    public partial class Form_KAKA : Form
    {
        public Form_KAKA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wewlcome to 317, Cedar Hill Drive, Blacksburg. Virginia.", "Welcome Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
