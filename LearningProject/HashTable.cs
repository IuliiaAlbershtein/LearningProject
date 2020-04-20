using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    class HashTable
    {
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        private Node[] items;

        public HashTable(int capacity = 100)
        {
            count = 0;
            this.capacity = capacity;
            items = new Node[capacity];
        }

        private int GetIndex(int value)
        {
            return Hash(value) % capacity;
        }

        private int Hash(int value)
        {
            return value * 33;
        }

        public void Insert(int value)
        {
        }

        public void Delete(int value)
        {
        }

        public bool Contains(int value)
        {
            return false;
        }

        public void ForEach(Action<int> action)
        {
        }

        class Node
        {
            private int value;
            public int Value
            {
                get
                {
                    return value;
                }
            }

            public Node(int value)
            {
                this.value = value;
            }

            public Node Next;
        }
    }
}
