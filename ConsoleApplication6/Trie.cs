using System;

public class Trie
{
    Node head;

    /**
     * find word and return meaning if found, else empty string
     * */
    public string find(string word)
    {
        if (head != null)
        {
            Node curr = head;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                int indexOfChar = c - 'a';
                if (curr == null || curr.children == null)
                {
                    return null;
                }
                else
                {
                    curr = curr.children[indexOfChar];
                }

            }
            return curr.meaning;
        }
        return null;
    }

    /**
     * insert word in trie and return true if success
     * */
    public void insert(string word, string meaning)
    {
        if (head == null) {
            head = new Node('0', null);
        }
        Node curr = head;
        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];
            if (curr.children[c - 'a'] == null) {
                curr.children[c - 'a'] = new Node(c, null);
            }
            curr = curr.children[c - 'a'];
        }
        curr.meaning = meaning;
    }

    public class Node
    {
        public char c;
        public string meaning;
        public Node[] children;

        public Node(char c, string meaning)
        {
            this.c = c;
            this.meaning = meaning;
            this.children = new Node[26];
        }
    }

}
