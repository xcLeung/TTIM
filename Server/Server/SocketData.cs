﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ServerSocket
{
    public class ClientInfo
    {
        public byte[] buffer;

        public string NickName { get; set; }

        public EndPoint Id { get; set; }

        public IntPtr handle { get; set; }

        public string Name
        {
            get
            {
                if (!string.IsNullOrEmpty(NickName))
                {
                    return NickName;
                }
                else
                {
                    return string.Format("{0}#{1}", Id, handle);
                }
            }
        }

        public bool IsHandShaked { get; set; }
        
    }

    public class SocketMessage
    {
        public int MessageType { get; set; }

        public ClientInfo Client { get; set; }

        public string Message { get; set; }

        public DateTime Time { get; set; }
    }
}
