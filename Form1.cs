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
    public partial class FormImgEdit : Form
    {
        public FormImgEdit()
        {
            InitializeComponent();
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //显示字体对话框
            DialogResult dr = fontDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮
            if (dr == DialogResult.OK)
            {
                lblFont.Text = fontDialog1.Font.Name;
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            //显示颜色对话框
            DialogResult dr = colorDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮
            if (dr == DialogResult.OK)
            {
                rbtBOthColor.Text = colorDialog1.Color.Name;
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            //显示文件对话框
            DialogResult dr = openFileDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮，则更改文本框中的字体
            if (dr == DialogResult.OK)
            {
                //openFileDialog1.FileName;
            }*/
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示文件对话框
            DialogResult dr = openFileDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮
            if (dr == DialogResult.OK)
            {
                //openFileDialog1.FileName;
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示文件对话框
            DialogResult dr = saveFileDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮
            if (dr == DialogResult.OK)
            {
                //saveFileDialog1.FileName;
            }
        }

        private void 插入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
