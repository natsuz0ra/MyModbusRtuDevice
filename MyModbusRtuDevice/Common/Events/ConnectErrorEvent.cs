using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModbusRtuDevice.Common.Events
{
    public delegate void ConnectErrorEventHandler(object sender, ConnectErrorEventArgs e);

    public class ConnectErrorEventArgs : EventArgs
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public bool Disconnect { get; set; }

        public ConnectErrorEventArgs(int code, string message, bool disconnect)
        {
            Code = code;
            Message = message;
            Disconnect = disconnect;
        }
    }
}
