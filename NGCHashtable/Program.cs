using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGCHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "2000");
            ht.Add(2, "678");
            ht.Add(3, 4555);
            ht.Remove(2);
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine( $"{d.Key}  {d.Value} ");
            }
        }
    }
}
