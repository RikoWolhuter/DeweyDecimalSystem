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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//Close the app
        }

        

        private void ReplacingBooks_Click(object sender, EventArgs e)
        {
            Form2 ReplacingBooks = new Form2();
            this.Hide();
            ReplacingBooks.ShowDialog();
            this.Show();
        }

        private void IdentifyingAreas_Click(object sender, EventArgs e)
        {
            Form5 IdentifyingAreas = new Form5();
            this.Hide();
            IdentifyingAreas.ShowDialog();
            this.Show();
        }

        private void Finding_Call_Numbers_Click(object sender, EventArgs e)
        {
            Form6 Finding_Call_Numbers = new Form6();
            this.Hide();
            Finding_Call_Numbers.ShowDialog();
            this.Show();
        }
    }
}
