using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    internal class SqlWhereBuilder
    {
        private string value;

        public SqlWhereBuilder()
        {
            value = "";
        }

        public string Value 
        { 
            get { return value; } 
            set 
            {
                if(value != "")
                {
                    if (this.value == "")
                        this.value = $"WHERE {value}";
                    else
                        this.value += $" AND {value}";
                }
            } 
        }

        public void Add(object obj, string param)
        {
            if(obj is int && obj != null && ((int)obj) != 0)
            {
                Value = $"{param} = {((int)obj)}";
            }
            else if(obj is string && !string.IsNullOrEmpty((string)obj))
            {
                Value = $"{param} LIKE '%{((string)obj)}%'";
            }
            else if( obj is double && obj != null)
            {
                Value = $"{param} = {((double)obj):N2}";
            }
            return;
        }

    }
}
