using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEdit
{
    class Brush
    {
        private Color bColor = Color.Red;                  //画笔颜色
        private BrushStyle bStyle = BrushStyle.Brush;      //画笔类型
        private int bSize = 5;                             //画笔大小
        private int bTMD = 90;                             //画笔透明度
        //画笔颜色
        public Color BColor
        {
            get
            {
                return bColor;
            }
            set
            {
                bColor = value;
            }
        }
        //画笔类型
        public BrushStyle BStyle
        {
            get
            {
                return bStyle;
            }
            set
            {
                bStyle = value;
            }
        }
        //画笔大小
        public int BSize
        {
            get
            {
                return bSize;
            }
            set
            {
                bSize = value;
            }
        }
        //画笔透明度
        public int BTMD
        {
            get
            {
                return bTMD;
            }
            set
            {
                bTMD = value;
            }
        }
    }
}
