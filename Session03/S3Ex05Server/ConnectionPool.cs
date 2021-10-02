using System;
using System.Collections.Generic;

namespace S3Ex05Server
{
    public class ConnectionPool
    {
        private List<ChatServerHandler> _connections = new List<ChatServerHandler>();

        public void AddConnection(ChatServerHandler csh)
        {
            _connections.Add(csh);
        }

        public void Broadcast(string message)
        {
            foreach (var connection in _connections)
            {
                connection.SendMessageToClient(message);
            }
        }

        public void RemoveConnection(ChatServerHandler csh)
        {
            _connections.Remove(csh);
        }
        
        
        
    }
}