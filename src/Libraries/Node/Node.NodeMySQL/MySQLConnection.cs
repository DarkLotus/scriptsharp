using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Node.NodeMySQL
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    public class MySQLConnection
    {
        //Callback delegates
        public delegate void MySQLErrorListener(Exception error);
        public delegate void QueryListener(Exception error, Dictionary<string, string>[] rows, Dictionary<string, string>[] fields);

        public void connect(MySQLErrorListener error)
        {
            return;
        }
        public void connect()
        {
            return;
        }
        public void end()
        {

        }
        public void end(MySQLErrorListener error)
        {

        }
        public void destory() { }
        /// <summary>
        /// For pooled only?
        /// </summary>
        public void release() { }

        public Query query(string query, QueryListener queryResults)
        {
            return null;
        }

        public Query query(string p)
        {
            return null;
        }



        [ScriptEvent("on", "removeListener")]
        public event Action<Exception> Error
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
