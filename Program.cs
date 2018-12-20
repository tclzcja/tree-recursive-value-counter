using System;
using System.Collections.Generic;

namespace BloombergCodingExercise
{
    class Node
    {
        public string value { get; private set; }
        public List<Node> children { get; set; }
        public Node(string v)
        {
            this.value = v;
            this.children = new List<Node>();
        }
        public Dictionary<string, int> printoutValueCount()
        {
            Dictionary<string, int> valueCountMap = new Dictionary<string, int>();
            this.recursiveChildren(valueCountMap);
            // foreach (KeyValuePair<string, int> c in valueCountMap)
            // {
            //     Console.WriteLine(c.Key + ' ' + c.Value);
            // }
            return valueCountMap;
        }
        private void recursiveChildren(Dictionary<string, int> map)
        {
            if (map.ContainsKey(this.value))
            {
                map[this.value]++;
            }
            else
            {
                map.Add(this.value, 1);
            }
            foreach (Node child in this.children)
            {
                child.recursiveChildren(map);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = new BloombergCodingExercise.Node("apple");
            var n2 = new BloombergCodingExercise.Node("orange");
            n1.children.Add(n2);
            var n3 = new BloombergCodingExercise.Node("orange");
            n1.children.Add(n3);
            n2.children.Add(new BloombergCodingExercise.Node("apple"));
            n2.children.Add(new BloombergCodingExercise.Node("apple"));
            n3.children.Add(new BloombergCodingExercise.Node("apple"));
            n3.children.Add(new BloombergCodingExercise.Node("apple"));
            n3.children.Add(new BloombergCodingExercise.Node("apple"));
            n1.printoutValueCount();
        }
    }
}