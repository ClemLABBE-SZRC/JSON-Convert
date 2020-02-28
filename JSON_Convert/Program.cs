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

        }

        public static void NestedDictIteration(Dictionary<string, object> nestedDict)
        {
            foreach (KeyValuePair<string, object> kvp in nestedDict)
            {

                object nextLevel = kvp.Value;
                if (nextLevel == null)
                {
                    Console.WriteLine("Key = {0}, Value = {1}, Type = {2}", kvp.Key, kvp.Value, kvp.Value.GetType());
                    continue;
                }
                //NestedDictIteration((Dictionary<string, object>)nextLevel);
            }
        }

        public static string ToString(Dictionary<string, object> dic)
        {
            string strDic = "";
            foreach (KeyValuePair<string, object> kvp in dic)
            {
                if (kvp.Value.GetType() != typeof(Dictionary<string, object>))
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
