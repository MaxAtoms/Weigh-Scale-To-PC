using System;
using System.IO.Ports;

namespace WeightMonitor
{
    static class SerialCom
    {
        private static SerialPort port = new SerialPort();

        internal static void Setup(string portName = "COM1")
        {
            if (portName == "")
            {
                portName = "COM1";
            }
            port.PortName = portName;
            port.BaudRate = 9600;
            port.ReadTimeout = 2500;
            port.WriteTimeout = 25000;

            try
            {
                port.Open();
            }
            catch (System.IO.IOException) { }
        }

        public static string GetWeight()
        {
            try
            {
                string message = port.ReadLine();
                return message;
            }
            catch (Exception)
            {
                try
                {
                    port.Open();
                }
                catch (Exception ex) { }
               return "Error";
            }
        }

        public static void SendTara()
        {
            if (port.IsOpen)
            {
                port.WriteLine("T");
            }
        }

        public static void ChangePort(String portName)
        {
            if (port.IsOpen)
            {
                Console.WriteLine("Kommt an");
                port.Close();
                port.PortName = portName;

                try
                {
                    port.Open();
                }
                catch (Exception) {  }
            }
        }
    }
}
