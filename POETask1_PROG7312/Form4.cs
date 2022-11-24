using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POETask1_PROG7312
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.Owner as Form2).button1.Enabled = true;//Enables button1 from Form2
        }
    }
}
