
using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Collections;


namespace Multicast
{
    public class networking
    {
        private IPAddress ip;
        private int port;
        private Socket sender;
        private Socket receiver;
        private Thread receive_thread;
        private Stack receive_buffer;



        public networking(string address, int port_num)
        {
            receive_buffer = new Stack();
            try
            {

                ip = IPAddress.Parse(address);
                this.port = port_num;


                sender = new Socket(AddressFamily.InterNetwork,
                                    SocketType.Dgram, ProtocolType.Udp);

                IPEndPoint ipep = new IPEndPoint(ip, port);

                sender.Connect(ipep);


                receiver = new Socket(AddressFamily.InterNetwork,
                                    SocketType.Dgram, ProtocolType.Udp);

                
                IPEndPoint ipep_any = new IPEndPoint(IPAddress.Any, port);

               
                receiver.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);

               
                receiver.Bind(ipep_any);

                receiver.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 0);

                receiver.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip));




            }
            catch (System.Net.Sockets.SocketException e)
            {
                
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.GetBaseException());
                Console.Error.WriteLine(e.ErrorCode);
            }
        }
        public void start_receiving()
        {
            

            receive_thread = new Thread(new ThreadStart(receive));
            receive_thread.IsBackground = true;

            receive_thread.Start();
        }

        public void stop_receiving()
        {

            receive_thread.Abort();
        }



        public void send(byte[] b)
        {
        
            if (b == null || b.Length <= 0)
            {
                return;
            }
            try
            {
                
                sender.Send(b, b.Length, SocketFlags.None);


            }
            catch (System.Net.Sockets.SocketException e)
            {

                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.GetBaseException());
                Console.Error.WriteLine(e.ErrorCode);
            }
        }


        public byte[] PopReceiveBuffer()
        {
            lock (receive_buffer.SyncRoot)
            {
                if (receive_buffer.Count > 0)
                {

                    byte[] b = (byte[])receive_buffer.Pop();
                    return b;
                }
                else
                {
                    return (byte[])null;
                }
            }
        }

        public void SendMessage(string message)
        {

            byte[] buff;
            buff = Encoding.ASCII.GetBytes(message);

            send(buff);


        }

        public string GetMessage()
        {
            return "";
        }

        public int GetAmountInReceiveBuffer()
        {
            lock (receive_buffer.SyncRoot)
            {
                return receive_buffer.Count;
            }
        }


        public bool GetReceiveStatus()
        {
            return receive_thread.IsAlive;
        }

        public void ClearReceiveBuffer()
        {
            receive_buffer.Clear();
        }

        private void receive()
        {
            try
            {
                while (true)
                {
                    try
                    {
                        byte[] b = new byte[1024];
                        receiver.Receive(b, SocketFlags.None);
                        lock (receive_buffer.SyncRoot)
                            receive_buffer.Push(b);
                    }
                    catch
                    {
                        Console.WriteLine("Bad packet received. Sender should slow down a bit?");
                    }
                }
            }
            catch (System.Net.Sockets.SocketException e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.GetBaseException());
                Console.Error.WriteLine(e.ErrorCode);
            }
        }
    }
}
