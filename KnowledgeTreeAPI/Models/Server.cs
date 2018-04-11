﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orient.Client;

namespace KnowledgeTreeAPI.Models
{
    public class Server
    {
        private static string _hostname = "localhost";
        private static int _port = 2424;
        private static string _user = "root";
        private static string _passwd = "12345";

        public static OServer Connect()
        {
            OServer server = new OServer(_hostname, _port,
                   _user, _passwd);
            return server;
        }
    }
}