using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 설문조사
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 왼쪽_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }

        private void 이페이지_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 F3 = new Form3();
            F3.ShowDialog();
        }

        private void 삼페이지_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 F4 = new Form4();
            F4.ShowDialog();
        }

        private void 오른쪽_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 F3 = new Form3();
            F3.ShowDialog();
        }
    }
}
