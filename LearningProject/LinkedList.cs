using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    // Array
    // [xxxx]
    // [xxxxxx          ]

    // Node
    //*[ ] -> [ ] -> [ ] -> null
    //  5      3      7
    //*[ ] -> [ ] -> [ ] -> [ ] -> null
    //  9      5      3      7

    class Node
    {
        private int value;
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        private Node next;
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return $"{value}";
        }
    }

    class LinkedList
    {
        private Node head;

        public LinkedList()
        {
        }

        public void AddFirst(int value)
        {
            var newNode = new Node();
            newNode.Next = head;
            newNode.Value = value;

            head = newNode;
        }

        //  ||
        //  \/
        //*[ ] -> [ ] -> [ ] -> [ ] -> null
        //  9      5      3      7
        //*[ ] -> [ ] -> [ ] -> null
        //  5      3      7

        public void RemoveFirst()
        {
            head = head.Next;
        }

        public void RemoveLast()
        {

        }

        // todo: make variable
        public int Count
        {
            get
            {
                var count = 0;
                var node = head;
                while (node != null)
                {
                    count += 1;
                    node = node.Next;
                }
                return count;
            }
        }

        public int GetValue(int index)
        {
            var i = 0;
            var current = head;
            while (current != null)
            {
                current = current.Next;
                i += 1;
                if (i == index)
                {
                    return current.Value;
                }
            }
            return -1;
        }

        public void ForEach(Action<int> action)
        {
            var current = head;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        public void InsertAt(int index, int value)
        {

        }

        public void RemoveAt(int index)
        {

        }

        public void AddLast()
        {

        }
    }
}
