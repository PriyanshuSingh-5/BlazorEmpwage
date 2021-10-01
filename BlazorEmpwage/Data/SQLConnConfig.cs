using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmpwage.Data
{
    public class SQLConnConfig
    {
        public string Value { get; }

        public SQLConnConfig(string value) => Value = value;
    }
}
