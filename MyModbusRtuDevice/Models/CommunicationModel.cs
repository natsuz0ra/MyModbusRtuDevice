using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModbusRtuDevice.Models
{
    public class CommunicationModel
    {
        // 端口名
        public string PortName { get; set; }
        // 波特率
        public int BaudRate { get; set; }
        // 数据位
        public int DateBit { get; set; }
        // 校验位
        public Parity Parity { get; set; }
        // 停止位
        public StopBits StopBits { get; set; }
        // 读取缓冲区大小
        public int ReadBuffterSize { get; set; }
        // 读取超时时间
        public int ReadTimeout { get; set; }
        // 写入缓冲区大小
        public int WriteBuffterSize { get; set; }
        // 写入超时时间
        public int WriteTimeout { get; set; }

        // 设备列表
        public List<DeviceModel> DeviceList { get; set; }
    }
}
