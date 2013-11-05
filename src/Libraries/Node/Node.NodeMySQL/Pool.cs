using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Node.NodeMySQL
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    public class Pool
    {
        public Boolean waitForConnections;
        public int connectionList;
        public int queueLimit;

        public delegate void ConnectionListener(Exception err, MySQLConnection con);
        public void getConnection(ConnectionListener callback) { }




        [ScriptEvent("on", "removeListener")]
        public event Action<MySQLConnection> Connection
        {
            add
            {
            }
            remove
            {
            }
        }

    }
}
