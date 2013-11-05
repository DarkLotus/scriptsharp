using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Node.NodeMySQL
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    [ScriptName("mysql")]
    public static class NodeMySQL
    {
        public static MySQLConnection createConnection(Dictionary<string, string> Params)
        {
            return null;
        }
        public static Pool createPool(Dictionary<string, string> Params)
        {
            return null;
        }

    }
}
