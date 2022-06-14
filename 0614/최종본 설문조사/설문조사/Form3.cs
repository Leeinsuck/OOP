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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void 왼쪽_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 F2 = new Form2();
            F2.ShowDialog();
        }

        private void 첫페이지_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 F2 = new Form2();
            F2.ShowDialog();
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
            Form4 F4 = new Form4();
            F4.ShowDialog();
        }
    }
}
