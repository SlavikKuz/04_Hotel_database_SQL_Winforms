﻿using HotelDB.Domain.DataAccess;

namespace HotelDB.Domain
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection()
        {
            Connection = new SqlConnector(); 
        }

        public static string CnnString(string name)
        {
            return "  "; 
                //ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}