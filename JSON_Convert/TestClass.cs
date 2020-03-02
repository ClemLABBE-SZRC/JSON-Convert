using System.Collections;
namespace JSON_Convert
{
    public class TestClass
    {

        public int Pr_pub_int;
        public string Pr_pub_str;

        private int Pr_pri_int;
        private double Pr_pri_dbl;

        private string[] Pr_pri_tab_str = { "str1", "str2", "str3" };
        private ArrayList Pr_pri_ArL;

        public TestClass2 Pr_pub_SsClasse;
        private TestClass2 Pr_pri_SsClasse;

        public TestClass()
        {
            Pr_pub_int = 0;
            Pr_pub_str = "Unknown";
            Pr_pri_int = 123456789;
            Pr_pri_dbl = 10.0;
            Pr_pri_ArL = new ArrayList();
            Pr_pri_ArL.Add("ArStr1");
            Pr_pri_ArL.Add("ArStr2");
            Pr_pub_SsClasse = new TestClass2();
            Pr_pri_SsClasse = new TestClass2();
       }
    }
}
