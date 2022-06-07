using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0607발표자료폼
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Size = new Size(250, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form Form1();
            Form1.StartPosition = FormStartPosition.Manual;
            Form1.Location = new Point(100, 100);
            Form1.Show();
        }
    }
}
