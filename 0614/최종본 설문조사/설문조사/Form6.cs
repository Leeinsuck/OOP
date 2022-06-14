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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void 로그인_Click(object sender, EventArgs e)
        {
            if (ID.Text == "Lee0906" || PASS.Text == "dlstjr99") {
                this.Visible = false;
                Form8 F8 = new Form8();
                F8.ShowDialog();
            }
            else
            {
                this.Visible = false;
                Form7 F7 = new Form7();
                F7.ShowDialog();
            }
        }
    }
}
