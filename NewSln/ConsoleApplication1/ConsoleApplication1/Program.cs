using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            result = DoDecryption("20,50,65,10,9,55,4,56,5,44,22,33,57,55,9,100,99,98,97,96,95,94,100", "dictionary_salman.txt");
            Console.WriteLine("Result: {0}", result);
            Console.Read();
        }

        public static string DoDecryption(string cipertext, string filepath)
        {
            ArrayList result = new ArrayList(); // to add list of possible findings
            string[] dictionary = Helper.GetDictionary(filepath); // list of words from dictionary file.
            Hashtable charFrequency = Helper.GetKeyCodes(typeof(Helper.MinFrequency)); // to have list of char frequency in hashtable
            Hashtable charList = Helper.GetCharTable(); // to maintain list of codes for each indexed char
            string[] cipertextList = Helper.GetCipertextArray(cipertext, ','); // cipertext code array
            Hashtable numList = new Hashtable(); // to maintain list of cipercode with its corresponding letters/chars
            int ciperCharIndex = 0; // to point the index of current cibertext code
            int prevCiperCharIndex = 0; // to maintain the previous index of last found word
            bool shallIContinue2NextWord = true; // to toggle to skip the main dictionary loop when ciperchar index reached last code in cipertext.

            foreach(string word in dictionary) // loop to pick each word in the dictionary list.
            {
                shallIContinue2NextWord = true; // always initialize to pick next word
                Hashtable tempNumList = CopyHashtableFrom(numList);
                bool isMatch = true;
                foreach(char ch in word)
                {
                    string key = ch.ToString();
                    string ciperCode = cipertextList[ciperCharIndex];
                    ArrayList charCodeArray = (ArrayList)charList[key];

                    if (!charCodeArray.Contains(ciperCode))
                    {
                        charCodeArray.Add(ciperCode);
                    }

                    if (charCodeArray.Count > (int)charFrequency[key])
                    {
                        isMatch = false; break;
                    }

                    if (tempNumList.ContainsKey(ciperCode))
                    {
                        if (tempNumList[ciperCode].ToString() != key)
                        {
                            isMatch = false;
                            break;
                        }
                    }
                    else
                    {
                        tempNumList.Add(ciperCode, key);
                    }
                    if (++ciperCharIndex >= cipertextList.Length)
                    {
                        ciperCharIndex = prevCiperCharIndex;
                        shallIContinue2NextWord = false;
                        break;
                    }
                }
                if (isMatch)
                {
                    result.Add(word);
                    Console.WriteLine("Matching Word: {0}", word);
                    foreach (string key in numList.Keys)
                    {
                        Console.Write("[{0},{1}] ", key, numList[key]);
                    }
                    Console.WriteLine("------------------");
                    prevCiperCharIndex = ciperCharIndex;
                    numList = CopyHashtableFrom(tempNumList);
                }
                else
                {
                    ciperCharIndex = prevCiperCharIndex;
                    foreach (string key in charList.Keys)
                    {
                        ArrayList arrayOfCharList = ((ArrayList)charList[key]);
                        arrayOfCharList.Clear();
                        foreach(string numKey in numList.Keys)
                        {
                            if (numList[numKey].ToString().Equals(key))
                            {
                                arrayOfCharList.Add(numKey);
                            }
                        }
                    }

                }
                if (!shallIContinue2NextWord) break;
            }
            string resultString = string.Empty;
            foreach (string word in result)
            {
                resultString += word;
            }
             return resultString;
        }
        public static Hashtable CopyHashtableFrom(Hashtable hTable)
        {
            Hashtable result = new Hashtable();
            foreach (string numKey in hTable.Keys)
            {
                result.Add(numKey, hTable[numKey]);
            }
            return result;
        }
    }
}

