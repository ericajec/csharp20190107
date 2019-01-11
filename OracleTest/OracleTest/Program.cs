﻿using Oracle.ManagedDataAccess.Client;
using System;

namespace OracleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "data source=topcredu;user id=scott;password=tiger";

            string str = @"Data Source=(DESCRIPTION =
                         (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
                                   (CONNECT_DATA =
                                    (SERVER = DEDICATED)
                                    (SERVICE_NAME = topcredu)
                                   )
                                  ) ;User Id=scott;Password=tiger";

            OracleConnection Conn = new OracleConnection(str);
            OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;
            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT ENAME FROM EMP";
                OracleDataReader reader = Comm.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
