using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace WeatherServerLibrary
{
    public class Client
    {
        private int portNum;
        private string hostName;
        NetworkStream ns;
        public string Read() {
            byte[] bytes = new byte[1024];
            int bytesRead = ns.Read(bytes, 0, bytes.Length);
            return Encoding.UTF8.GetString(bytes, 0, bytesRead);
        }
        public void Send(string msg)
        {
            byte[] binMsg = Encoding.UTF8.GetBytes(msg);
            ns.Write(binMsg, 0, binMsg.Length);
        }
        public int Start(string hostName, int portNum)
        {
            this.portNum = portNum;
            this.hostName = hostName;
            try
            {
                var client = new TcpClient(hostName, portNum);

                ns = client.GetStream();

                while (true)
                {
                    Console.Write(Read());
                    Console.Write(Read());

                    string city = Console.ReadLine();
                    Send(city);
                    Console.Write(Read());
                }
                //client.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return 0;
        }
    }
}
