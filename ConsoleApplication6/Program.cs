using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.insert("shagun", "pikachu");
            trie.insert("rahul", "dhoop");
            Console.WriteLine(trie.find("shagun"));
            Console.WriteLine(trie.find("rahul"));
            Console.WriteLine(trie.find("hello"));
            Console.WriteLine("done!");
        }
    }
}
