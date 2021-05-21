using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgEdit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //显示文件对话框
            DialogResult dr = openFileDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮，则更改文本框中的字体
            if (dr == DialogResult.OK)
            {
                //openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //显示文件对话框
            DialogResult dr = openFileDialog2.ShowDialog();
            //如果在对话框中单击“确认”按钮，则更改文本框中的字体
            if (dr == DialogResult.OK)
            {
                //openFileDialog1.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //显示文件对话框
            DialogResult dr = saveFileDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮
            if (dr == DialogResult.OK)
            {
                //saveFileDialog1.FileName;
            }
        }
    }
}
