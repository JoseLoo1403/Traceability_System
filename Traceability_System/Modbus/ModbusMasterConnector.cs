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
using System.Threading;
using Timer = System.Windows.Forms.Timer;

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


        public void TryGreenLight()
        {
            slave.DataStore.HoldingRegisters[1] = 1;

            var t = new Timer();
            t.Interval = 1000;

            t.Tick += (s, e) =>
            {
                slave.DataStore.HoldingRegisters[1] = 0;
                Thread.Sleep(500);
                slave.Dispose();
                IsReading = false;
                t.Stop();
            };
            t.Start();
        }

        public void ModbusGreenLightOn()
        {
            slave.DataStore.HoldingRegisters[2] = 1;
        }

        public void ModbusRedLightOn()
        {
            slave.DataStore.HoldingRegisters[2] = 0;
        }

        public void SetGenerationLight(int generation)
        {
            slave.DataStore.HoldingRegisters[3] = (ushort)generation;
        }

        private void SetAllRegisterCero()
        {
            slave.DataStore.HoldingRegisters[1] = 0;
            slave.DataStore.HoldingRegisters[2] = 0;
            slave.DataStore.HoldingRegisters[3] = 0;
        }

        public void CloseConnection()
        {
            if (IsReading)
            {
                SetAllRegisterCero();
            }
            slave.Dispose();
            IsReading = false;
        }
    }
}
