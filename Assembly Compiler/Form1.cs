using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assembly_Compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ADD ";
        }

        private void endl_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\r\n");
        }

        private void set_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "SET ";
        }
    }
}
