﻿using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{

    class Server
    {
        static void Main(string[] args)
        {
            NetworkStream stream = null;
            TcpListener tcpListener = null;
            Socket clientsocket = null;
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");
                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();

                clientsocket = tcpListener.AcceptSocket();

                stream = new NetworkStream(clientsocket);
                Encoding encode = Encoding.GetEncoding("utf-8");

                reader = new StreamReader(stream, encode);
                writer = new StreamWriter(stream, encode) { AutoFlush = true };

                while (true)
                {
                    string str = reader.ReadLine();
                    Console.WriteLine(str);
                    writer.WriteLine(str);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }
        }
    }
}
