using System;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;

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
                var enumerable = field.GetValue(o) as IEnumerable;
                if ((enumerable != null) && (enumerable.GetType() != typeof(String)))
                {
                    ArrayList LocalList = new ArrayList();
                    foreach (var item in enumerable)
                    {
                        if (item.GetType().IsPrimitive || item.GetType() == typeof(String) || item.GetType() == typeof(Decimal))
                        {
                            LocalList.Add(item);
                        }
                        else
                        {
                            LocalList.Add(Serialize(item));
                        }
                    }
                    dic.Add(field.Name, LocalList);
                }
                else if (field.GetValue(o).GetType().IsPrimitive || field.GetValue(o).GetType() == typeof(String) || field.GetValue(o).GetType() == typeof(Decimal)) {
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
