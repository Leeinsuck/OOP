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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void 왼쪽_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 F3 = new Form3();
            F3.ShowDialog();
        }

        private void 첫페이지_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 F2 = new Form2();
            F2.ShowDialog();
        }

        private void 이페이지_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 F3 = new Form3();
            F3.ShowDialog();
        }

        private void 오른쪽_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 F5 = new Form5();
            F5.ShowDialog();
        }
    }
}
