using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Remoting.Contexts;

namespace JSON_Convert
{
    public class Serializer
    {
        public Serializer()
        {
            
        }

        public Dictionary<string, object> Serialize(object o)
        {
            Type myType = o.GetType();
            Dictionary<string, object> dic = new Dictionary<string, object>();

            //public and private attributes
            IList<FieldInfo> publicFields = new List<FieldInfo>(myType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic));
            foreach (FieldInfo field in publicFields)
            {
                if (field.GetValue(o).GetType().IsPrimitive || field.GetValue(o).GetType() == typeof(String) || field.GetValue(o).GetType() == typeof(Decimal)) {
                    dic.Add(field.Name, field.GetValue(o));
                }
                else
                {
                    dic.Add(field.Name, Serialize(field.GetValue(o)));
                }
            }

           

          

            return dic;
        }

   
    }
}
