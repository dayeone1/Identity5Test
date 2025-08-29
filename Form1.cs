using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identity5Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 상담하기ToolStripMenuItem_Click(object sender, EventArgs e)
        { // = 정보보기. 뭔가 꼬여서 수정할 수 없음...
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 운세테스트내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
