using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    abstract class Shape   // 图形抽象类
    {
        public abstract double GetArea();  // 计算图形面积
        public abstract bool IsLegal();  // 判断图形是否合法
        public abstract string GetInfo();  // 返回图形信息
    }
}
