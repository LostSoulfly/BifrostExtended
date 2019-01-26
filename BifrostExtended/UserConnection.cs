﻿using Bifrost;
using System.Net.Sockets;

namespace BifrostExtended
{
    public class UserConnection
    {
        public ClientLink ClientLink;
        public ServerLink ServerLink;
        public TcpClient TcpClient;

        public UserConnection(TcpClient tcpClient, ServerLink serverLink = null, ClientLink clientLink = null)
        {
            this.ServerLink = serverLink;
            this.ClientLink = clientLink;
            this.TcpClient = tcpClient;
        }
    }
}