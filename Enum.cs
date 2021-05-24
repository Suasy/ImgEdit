using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEdit
{
    //滤镜
    enum Filter
    {
        HB,         //黑白
        ZR,         //自然
        FD,         //浮雕
        QC,         //青春
        MH,         //模糊
        JM          //静谧
    }
    //颜色
    enum Color
    {
        Red,        //红色
        Black,      //黑色
        Yellow,     //黄色
        Green,      //绿色
        White,      //白色
        Purple,     //紫色
        Brown,      //棕色
        Other       //其他颜色
    }
    //画笔类型
    enum BrushStyle
    {
        Brush,      //涂鸦笔
        Eraser,     //橡皮擦
        Mosaic      //马赛克
    }
    //贴纸
    enum Sticker
    {
        //卡通
        KT1,        //卡通1
        KT2,        //卡通2
        KT3,        //卡通3
        KT4,        //卡通4        
        KT5,        //卡通5
        KT6,        //卡通6
        //气泡
        QP1,        //气泡1
        QP2,        //气泡2
        QP3,        //气泡3
        QP4,        //气泡4
        QP5,        //气泡5
        QP6         //气泡6
    }
}
