using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Node.NodeMySQL
{
    [ScriptImport]
    [ScriptIgnoreNamespace]
    public class Query
    {
        public int index;

        [ScriptEvent("on", "removeListener")]
        public event Action<Row, int> Result
        {
            add
            {
            }
            remove
            {
            }
        }

        [ScriptEvent("on", "removeListener")]
        public event Action End
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
