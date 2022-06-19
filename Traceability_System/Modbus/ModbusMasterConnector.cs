using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using Modbus.Device;
using System.Windows.Forms;
using System.Net;

namespace Traceability_System.Modbus
{
    public class ModbusMasterConnector
    {
        private TcpListener slaveTcpListener;
        private ModbusSlave slave;

        public void StartConnection(string ip, int _port)
        {
            byte slaveID = 1;
            int port = _port;
            IPAddress address = IPAddress.Parse(ip);

            slaveTcpListener = new TcpListener(address, port);
            slaveTcpListener.Start();

            slave = ModbusTcpSlave.CreateTcp(slaveID,slaveTcpListener);
            slave.Listen();
        }

        public void WriteRegister(int index)
        {
            slave.DataStore.HoldingRegisters[index] = 1;
        }
    }
}
