using System;
namespace JSON_Convert
{
    public class TestClass2
    {
        public int Sc_pub_int;
        public string Sc_pub_str;

        private int Sc_pri_int;
        private double Sc_pri_dbl;



        public TestClass2()
        {
            Sc_pub_int = 0;
            Sc_pub_str = "Unknown";
            Sc_pri_int = 123456789;
            Sc_pri_dbl = 10.0;
        }
    }
}
