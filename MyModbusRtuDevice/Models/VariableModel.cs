using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModbusRtuDevice.Models
{
    public class VariableModel
    {
        // 地址
        public ushort Address { get; set; }
        // 名称
        public string Name { get; set; }
        // 参数
        public object Value { get; set; }
        // 最小值
        public double Min { get; set; }
        // 最大值
        public double Max { get; set; }
        // 系数
        public double Rate { get; set; }
        // 偏移量
        public double Offset { get; set; }
        // 图表颜色
        public Color Color { get; set; }
    }

    public class SelectedVariableModel : VariableModel
    {
        public bool IsSelected { get; set; }
    }
}
