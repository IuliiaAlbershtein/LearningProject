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
        public void ResizeIfNeeded()
        {
            if (3 * capacity - count < capacity)
            {
                var index = 0;
                var newCapacity = capacity * 2;
                Node[] newItems = new Node[newCapacity];
                
                while (index <= capacity)
                {
                    if (items[index] != null)
                    {
                        var newIndex = GetIndex(items[index].Value);
                        newItems[newIndex] = items[index];
                    }
                    index += 1;
                }
                items = newItems;
            }

        }
        public void Insert(int value)
        {
            //resize if needed

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
