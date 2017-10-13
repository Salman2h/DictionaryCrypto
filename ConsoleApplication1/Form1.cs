using System;
using DictionaryCrypto;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private char delimiter = ',';
        private List<string> dictionary;
        private Hashtable char_map;
        private Hashtable frequency;
        private Hashtable num_map;
        public Form1()
        {
            InitializeComponent();
            dictionary = Helper.LoadDictionary(txtDictFileName.Text);
            char_map = Helper.InitKeys();
            frequency = Helper.InitFrequency(typeof(Helper.SmallMaxFrequencyMap));
            num_map = new Hashtable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbDelimiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDelimiter.Text)
            {
                case "Tab":
                    delimiter = '\t';
                    break;
                case "Comma":
                    delimiter = ',';
                    break;
                case "Space":
                    delimiter = ' ';
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDictFileName.Text = "";
            DialogResult result = fDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtDictFileName.Text = fDialog.FileName;
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string[] cipherText = cipherTextBox.Text.Split(delimiter);
            ////***** START initializing pts = [['']] *********////
            ArrayList pts = new ArrayList(); 
            pts.Add(new ArrayList());
            ((ArrayList)pts[0]).Add("");

            ////***** END initializing pts = [['']] *********////
            // pts[-1] is equal to accessing last item in the list (in python standard)

            while (pts.Count==1 || ((ArrayList)pts[pts.Count-1]).Count>1) //while len(pts) == 1 or len(pts[-1]) > 1:
            {
                int num_words = pts.Count;
                pts.Add(new ArrayList());
                foreach(string pt in (ArrayList)pts[num_words - 1])
                {
                    foreach(string word in dictionary)
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
                                else if(num_map.ContainsKey(num))
                                {
                                    if ((char)num_map[num] != ch)
                                        isMatched = false;
                                }
                                
                                if(isMatched)
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
                MessageBox.Show("End of cycle");
            }
            plainTextBox.Text = string.Format("Match: {0}", ((ArrayList)pts[pts.Count - 1]).ToString());
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
