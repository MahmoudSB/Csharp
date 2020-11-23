using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace S7Driver
{
    public class PlcS7
    {
        Plc PLC;
        public Status ConnectionSatus { get; private set; }

        public PlcS7(CpuType cpu, string ip, short rack, short slot)
        {
            PLC = new Plc(cpu, ip, rack, slot);
        }

        public void Connect()
        {
            ConnectionSatus = Status.Connecting;
            var error = PLC.Open();
            if (error != ErrorCode.NoError)
            {
                ConnectionSatus = Status.Offline;
                throw new Exception(error.ToString());
            }
            if (PLC.IsConnected) { ConnectionSatus = Status.Online; }
        }

        public void Disconnect()
        {
            PLC.Close();
            if (!PLC.IsConnected) { ConnectionSatus = Status.Offline; }
        }

    }
}
