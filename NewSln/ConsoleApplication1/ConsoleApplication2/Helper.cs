using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication2
{
    public class Helper
    {
        private const string keyString = " ,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        public enum MaxFrequencyMap
        {
            space = 19,
            a = 7,
            b = 1,
            c = 2,
            d = 4,
            e = 10,
            f = 2,
            g = 2,
            h = 5,
            i = 6,
            j = 1,
            k = 1,
            l = 3,
            m = 2,
            n = 6,
            o = 6,
            p = 2,
            q = 1,
            r = 5,
            s = 5,
            t = 7,
            u = 2,
            v = 1,
            w = 2,
            x = 1,
            y = 2,
            z = 1
        }

        public enum SmallMaxFrequencyMap
        {
            space = 2,
            a = 1,
            b = 1,
            c = 2,
            d = 2,
            e = 2,
            f = 2,
            g = 2,
            h = 5,
            i = 6,
            j = 1,
            k = 1,
            l = 3,
            m = 2,
            n = 0,
            o = 6,
            p = 2,
            q = 1,
            r = 0,
            s = 5,
            t = 7,
            u = 2,
            v = 1,
            w = 2,
            x = 1,
            y = 2,
            z = 1
        }


        public static List<string> LoadDictionary(string filePath)
        {
            List<string> dictionaryItems = new List<string>();
            dictionaryItems = File.ReadAllLines(filePath).ToList();
            return dictionaryItems;
        }
        public static Hashtable InitFrequency(Type enumName)
        {
            Hashtable result = new Hashtable();
            foreach (string ch in keyString.Split(','))
            {
                result.Add(ch, (int)Enum.Parse(enumName, Convert.ToString((ch == " " ? "space" : ch))));
            }
            return result;
        }
        public static Hashtable InitKeys()
        {
            Hashtable result = new Hashtable();
            foreach (string ch in keyString.Split(','))
            {
                result.Add(ch, new ArrayList());
            }
            return result;
        }
    }
}
