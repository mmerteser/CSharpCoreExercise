using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] products = new string[3] { "Ürün 1", "Ürün 2", "Ürün 3" };
            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);
            }


        }
    }
}
