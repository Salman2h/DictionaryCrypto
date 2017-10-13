using System;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Helper
    {
        private static string KeyCodes = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z, ";
        public enum MaxFrequency
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
        public enum MinFrequency
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
            n = 1,
            o = 6,
            p = 2,
            q = 1,
            r = 1,
            s = 5,
            t = 7,
            u = 2,
            v = 1,
            w = 2,
            x = 1,
            y = 2,
            z = 1
        }
        public static Hashtable GetKeyCodes(Type frequencyType)
        {
            Hashtable result = new Hashtable();
            foreach (string ch in Helper.KeyCodes.Split(','))
                result.Add(ch, ((int)Enum.Parse(frequencyType, (ch == " ") ? "space" : ch)));
            return result;
        }
        public static Hashtable GetCharTable()
        {
            Hashtable result = new Hashtable();
            foreach (string ch in KeyCodes.Split(','))
                result.Add(ch, new ArrayList());
            return result;
        }
        public static string[] GetDictionary(string fileName)
        {
            StreamReader srFile = File.OpenText(fileName);
            string content = srFile.ReadToEnd().Replace("\r", "");
            string[] result = content.Split('\n');
            srFile.Close();
            srFile.Dispose();
            srFile = null;
            return result;
        }
        public static string[] GetCipertextArray(string cipertext, char delimiter)
        {
            if (string.IsNullOrEmpty(cipertext)) return null;
            return cipertext.Split(delimiter);
        }
    }
}
