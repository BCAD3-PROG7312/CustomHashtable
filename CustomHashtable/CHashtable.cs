using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHashtable
{
    class CHashtable
    {
        LinkedList<CNode>[] hashData = new LinkedList<CNode>[10];

        public CHashtable()
        {
            for (int i = 0; i < hashData.Length; i++)
            {
                hashData[i] = new LinkedList<CNode>();
            }
        }

        public int GetHash(int key)
        {
            return key % hashData.Length;
        }

        public void Add(int key, string value)
        {
            int index = GetHash(key);
            CNode c = new CNode(key, value);

            hashData[index].AddLast(c);
        }

        public void Remove(int key)
        {
            int index = GetHash(key);
            CNode result = hashData[GetHash(key)].Where<CNode>(n => n.key == key).First();
            hashData[GetHash(key)].Remove(result);
        }

        public string GetHashTable()
        {
            string output = "";
            for (int i = 0; i < hashData.Length; i++)
            {
                if (hashData[i].Count > 0)
                {
                    foreach (CNode cn in hashData[i])
                    {
                        output += cn.ToString() + "    ";
                    }
                } else
                {
                    output += "*    ";
                }
                
            }
            return output;
        }
        
        
    }
}
