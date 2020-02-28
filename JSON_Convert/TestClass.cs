using System;
namespace JSON_Convert
{
    public class TestClass
    {

        public int age;
        public string name;

        private int id;
        private double money;

        public TestClass2 subObject1;
        private TestClass2 subObject2;

        public TestClass()
        {
            age = 0;
            name = "Unknown";
            id = 123456789;
            money = 10.0;
            subObject1 = new TestClass2();
            subObject2 = new TestClass2();
        }
    }
}
