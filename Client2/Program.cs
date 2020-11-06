using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Client2
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress serverAddr = IPAddress.Parse("192.168.0.147");

            IPEndPoint endPoint = new IPEndPoint(serverAddr, 904);

            string text;
            int i = 0;
            
            while (i < 1001)
            {
                text = Convert.ToString(i);

                byte[] sendBuffer = Encoding.ASCII.GetBytes(text);
                sock.SendTo(sendBuffer, endPoint);
                
                i++;
            }
            
        }
    }
}