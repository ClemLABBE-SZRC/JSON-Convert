using System;
using System.Collections.Generic;

namespace JSON_Convert
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TestClass test = new TestClass();
            Serializer serializer = new Serializer();
            //serializer.GetPropertyValues(test);

            Dictionary<string, object> dictionary = serializer.Serialize(test);

            Console.WriteLine(ToString(dictionary));
            Console.WriteLine(dictionary);

        }

        public static string ToString(Dictionary<string, object> dic)
        {
            string strDic = "";
            foreach (KeyValuePair<string, object> kvp in dic)
            {
                var enumerable = kvp.Value as System.Collections.IEnumerable;
                if ((enumerable != null) && (enumerable.GetType() != typeof(String)) && (enumerable.GetType() != typeof(Dictionary<string, object>)))
                {
                    string localString = "";
                    foreach (var item in enumerable)
                    {
                        var localDic = item as Dictionary<string, object>;
                        if (item.GetType() == typeof(Dictionary<string, object>))
                        {
                            localString += "Valueeee = " + ToString(localDic) + ", \tType = " + item.GetType() + "\n";
                        } else 
                        {
                            localString += item.ToString() + ", \t";
                        }
                    }
                    strDic += ("Key = " + kvp.Key + ", \tValues :\n " + localString + ", \tType = " + kvp.Value.GetType() + "\n");
                }
                else if (kvp.Value.GetType() != typeof(Dictionary<string, object>))
                {
                    strDic += ("Key = " + kvp.Key + ", \tValue = " + kvp.Value + ", \tType = " + kvp.Value.GetType() + "\n");
                }
                else
                {
                    strDic += ("Key = " + kvp.Key + ", Value = \n\t" + ToString((Dictionary<string, object>)kvp.Value) + "\t, Type = " + kvp.Value.GetType() + "\n");
                }

            }
            return strDic;
        }
    }

}
