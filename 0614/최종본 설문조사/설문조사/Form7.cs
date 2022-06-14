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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void 확인_Click(object sender, EventArgs e)
        {
                this.Visible = false;
                Form6 F6 = new Form6();
                F6.ShowDialog();
                   }
    }
}
