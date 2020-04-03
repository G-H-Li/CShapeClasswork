using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private float x;
        private float y;
        private CayleyTree tree;
        public Form1()
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            setTag(this);
            this.tree = new CayleyTree();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            if (this.tree.Graphics == null)
            {
                this.tree.Graphics = this.pnlDrawPlat.CreateGraphics();
            }
            this.tree.Recursion = this.hsbRecursion.Value;
            this.tree.Length = this.hsbLength.Value;
            this.tree.RightAngle = this.hsbRightAngle.Value * Math.PI / 180;
            this.tree.LeftAngle = this.hsbLeftAngle.Value * Math.PI / 180;
            this.tree.RightPer = this.hsbRightPer.Value / 10.0;
            this.tree.LeftPer = this.hsbLeftPer.Value / 10.0;

            this.pnlDrawPlat.Refresh();
            this.tbStatement.AppendText($"递归深度:{this.tree.Recursion}\r\n主干长度:{this.tree.Length}\r\n" +
                $"右分支角度:{this.hsbRightAngle.Value}\r\n左分支角度:{this.hsbLeftAngle.Value}\r\n" +
                $"右分支长度比:{this.tree.RightPer}\r\n左分支长度比:{this.tree.LeftPer}\r\n" +
                $"横坐标:{this.hsbDrawX.Value}\r\n纵坐标:{this.hsbDrawY.Value}\r\n");
            this.tbStatement.AppendText(DateTime.Now.ToString()+": 开始绘制\r\n");
            this.tree.DrawCayleyTree(this.tree.Recursion, this.hsbDrawX.Value, this.hsbDrawY.Value, this.tree.Length, -Math.PI / 2);
            this.tbStatement.AppendText(DateTime.Now.ToString() + ": 绘制完成\r\n");
        }

        private void BtnSelectColor_Click(object sender, EventArgs e)
        {
            if(this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Brush brush = new SolidBrush(this.colorDialog1.Color);
                this.tree.Color = new Pen(brush);
            }
        }

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }

        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//宽度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//顶边距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }
    }
}
