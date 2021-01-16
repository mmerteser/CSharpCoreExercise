using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"Thread No : {Thread.CurrentThread.ManagedThreadId}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            MessageBox.Show($"Thread No : {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
