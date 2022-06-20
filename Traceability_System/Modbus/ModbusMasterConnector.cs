using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using Modbus.Device;
using System.Windows.Forms;
using System.Net;
using Traceability_System.Repositories;
using Traceability_System.Models;

namespace Traceability_System.Modbus
{
    public class ModbusMasterConnector
    {
        private TcpListener slaveTcpListener;
        private ModbusSlave slave;
        private int Port;
        private string Ip;
        public bool IsReading = false;


        public ModbusMasterConnector()
        {
            SetConfigurations();
        }

        //Test Connection
        public void StartConnection(string ip, int _port)
        {
            byte slaveID = 1;
            int port = _port;
            IPAddress address = IPAddress.Parse(ip);

            if (!IsReading)
            {
                slaveTcpListener = new TcpListener(address, port);
                slaveTcpListener.Start();

                slave = ModbusTcpSlave.CreateTcp(slaveID, slaveTcpListener);
                slave.Listen();

                IsReading = true; 
            }
        }

        public void StartConnection()
        {
            byte slaveID = 1;

            IPAddress address = IPAddress.Parse(Ip);

            try
            {
                slaveTcpListener = new TcpListener(address, Port);
                slaveTcpListener.Start();

                slave = ModbusTcpSlave.CreateTcp(slaveID, slaveTcpListener);
                slave.Listen();

                IsReading = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error intentando conectarse al PLC");
            }
        }

        private void SetConfigurations()
        {
            ConfigurationRepository repo = new ConfigurationRepository();

            Configuration[] configurations = repo.GetTcpConfiguration();

            Ip = configurations.FirstOrDefault(x => x.Name == "Ip").Value;
            Port = Convert.ToInt32(configurations.FirstOrDefault(x => x.Name == "Port").Value);
        }

        public void ModbusGreenLightOn()
        {
            slave.DataStore.HoldingRegisters[2] = 1;

            var t = new Timer();
            t.Interval = 10000;

            t.Tick += (s, e) =>
            {
                slave.DataStore.HoldingRegisters[2] = 0;
                t.Stop();
            };
            t.Start();
        }

        public void TryGreenLight()
        {
            slave.DataStore.HoldingRegisters[1] = 1;

            var t = new Timer();
            t.Interval = 1000;

            t.Tick += (s, e) =>
            {
                slave.DataStore.HoldingRegisters[1] = 0;
                CloseConnection();
                t.Stop();
            };
            t.Start();
        }

        public void ModbusRedLightOn()
        {
            slave.DataStore.HoldingRegisters[3] = 1;
        }

        public void ModbusRedLightOff()
        {
            slave.DataStore.HoldingRegisters[3] = 0;
        }

        public void CloseConnection()
        {
            //var t = new Timer();
            //t.Interval = 2000;

            //t.Tick += (s, e) =>
            //{
            //    slave.Dispose();
            //    IsReading = false;
            //    t.Stop();
            //};
            //t.Start();

            slave.Dispose();
            IsReading = false;
        }
    }
}
