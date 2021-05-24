using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
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

        private string fName;                              //当前打开的文件名
        private Bitmap img;                                //当前的像素图

        private Filter filter = Filter.HB;                 //滤镜类型

        private Brush brush;                               //画笔
        private Font font;                                 //字体

        private bool isHaveFile = false;                   //是否有文件
        private bool isNew = false;                        //是否是画板


        /// <summary>
        /// 菜单控件
        /// </summary>
        //新建
        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {

        }
        //打开
        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "所有支持的图片格式|*.jpg;*jpeg;*.jpe;*.bmp;*.gif;*.png;*.raw;*.arw;*.nef;*.crw;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.dng;*.pef;*.cr2;*.st2;*.mef;*.orf;*.psd" + "|" + 
                "JPG 格式|*.jpg;*.jpeg;*.jpe|BMP 格式|*.bmp|GIF 格式|*.gif|PNG 格式|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
                isHaveFile = true;
            }
        }
        //保存
        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {

        }
        //另存为
        private void ToolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = "JPG 格式|*.jpg|PNG 格式|*.png|BMP 格式|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
        //最近编辑过的图片
        private void ToolStripMenuItemEdited_Click(object sender, EventArgs e)
        {

        }
        //撤销
        private void ToolStripMenuItemUndo_Click(object sender, EventArgs e)
        {

        }
        //恢复
        private void ToolStripMenuItemRedo_Click(object sender, EventArgs e)
        {

        }
        //重做
        private void ToolStripMenuItemRework_Click(object sender, EventArgs e)
        {

        }
        //修改尺寸
        private void ToolStripMenuItemResize_Click(object sender, EventArgs e)
        {

        }
        //裁剪图片
        private void ToolStripMenuItemCut_Click(object sender, EventArgs e)
        {

        }
        //插入图片
        private void ToolStripMenuItemInsert_Click(object sender, EventArgs e)
        {

        }
        //查看帮助
        private void ToolStripMenuItemViewHelp_Click(object sender, EventArgs e)
        {

        }
        //关于
        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 滑动条滑动事件
        /// </summary>
        //亮度
        private void tkbLD_Scroll(object sender, EventArgs e)
        {
            
        }
        //对比度
        private void tkbDBD_Scroll(object sender, EventArgs e)
        {

        }
        //灰度
        private void tkbHD_Scroll(object sender, EventArgs e)
        {

        }
        //色调
        private void tkbSD_Scroll(object sender, EventArgs e)
        {

        }
        //编辑大小
        private void tkbESize_Scroll(object sender, EventArgs e)
        {

        }
        //画笔大小
        private void tkbBSize_Scroll(object sender, EventArgs e)
        {

        }
        //画笔透明度
        private void tkbBTMD_Scroll(object sender, EventArgs e)
        {

        }

    }
}
