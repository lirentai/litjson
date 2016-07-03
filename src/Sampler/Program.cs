using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;

namespace Sampler
{
    class Program
    {
        public enum Hello
        {
            World,
            T_T,
        }
        public class Test
        { 
            public Dictionary<string, string> TestDic =new Dictionary<string, string> {
                {"adfa","rentai"},
                {"adsfas","baba"},
            };

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach(var obj in TestDic)
                {
                    sb.Append(obj.Key.ToString() + ":" + obj.Value.ToString() + "\n");
                }
                return sb.ToString();
            }
        }
        public static string TestSerialize()
        {
            Test test = new Test();
            string json = JsonMapper.ToJson(test, true);
            return json;
        }
        public static void TestDesializer(string json)
        {
            Test test = JsonMapper.ToObject<Test>(json);
            System.Console.Write(test.ToString());
        }
        static void Main(string[] args)
        {
            string json = TestSerialize();
            TestDesializer(json);
            while (true) ;
        }
    }
}
