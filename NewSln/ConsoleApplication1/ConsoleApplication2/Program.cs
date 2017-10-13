using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new ConsoleApplication2.Program();
            prg.Decrypt("20,50,65,10,9,55,4,9,5,4,22");
        }

        private char delimiter = ',';
        private List<string> dictionary;
        private Hashtable char_map;
        private Hashtable frequency;
        private Hashtable num_map;
        public Program()
        {
            dictionary = Helper.LoadDictionary("dictionary.txt");
            char_map = Helper.InitKeys();
            frequency = Helper.InitFrequency(typeof(Helper.SmallMaxFrequencyMap));
            num_map = new Hashtable();
        }
        public void Decrypt(string cipertext)
        {
            string[] cipherText = cipertext.Split(delimiter);
            ////***** START initializing pts = [['']] *********////
            ArrayList pts = new ArrayList();
            pts.Add(new ArrayList());
            ((ArrayList)pts[0]).Add("");

            ////***** END initializing pts = [['']] *********////
            // pts[-1] is equal to accessing last item in the list (in python standard)

            while (pts.Count == 1 || ((ArrayList)pts[pts.Count - 1]).Count > 1) //while len(pts) == 1 or len(pts[-1]) > 1:
            {
                int num_words = pts.Count;
                pts.Add(new ArrayList());
                foreach (string pt in (ArrayList)pts[num_words - 1])
                {
                    foreach (string word in dictionary)
                    {
                        string new_pt = pt + word + ' ';
                        num_map.Clear(); //num_map = {}
                        foreach (string key in char_map.Keys)
                        {
                            ((ArrayList)char_map[key]).Clear();
                        }
                        bool isMatched = true;
                        foreach (char ch in new_pt)
                        {
                            for (int index = 0; index < cipherText.Length && isMatched; index++)
                            {
                                string num = cipherText[index];
                                string aKey = ch.ToString();
                                ArrayList aList = ((ArrayList)char_map[aKey]);
                                if (aList.Count >= (int)frequency[aKey])
                                {
                                    isMatched = false;
                                }
                                else if (num_map.ContainsKey(num))
                                {
                                    if ((char)num_map[num] != ch)
                                        isMatched = false;
                                }

                                if (isMatched)
                                {
                                    aList.Add(num);
                                    num_map.Add(num, ch);
                                }
                            }
                            if (isMatched)
                            {
                                ((ArrayList)pts[num_words]).Add(new_pt);
                            }
                        }
                    }
                }
                Console.WriteLine("End of cycle");
            }
            Console.WriteLine(string.Format("Match: {0}", ((ArrayList)pts[pts.Count - 1]).ToString()));
        }
    }
}
