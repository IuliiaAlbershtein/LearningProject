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
            ResizeIfNeeded();
            var index = GetIndex(value);
            if (items[index] == null)
            {
                items[index] = new Node(value);
                return;
            }
            if (items[index] != null)
            {
                var node = items[index];
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new Node(value);
            }
            count += 1;
        }

        public void Delete(int value)
        {
            var index = GetIndex(value);
            var node = items[index];
            if (node == null)
            {
                return;
            }
            if (node.Value == value)
            {
                items[index] = node.Next;
                return;
            }
            if (node != null && node.Value != value)
            {
                while (node.Next.Value != value)
                {
                    node = node.Next;
                    if (node.Next == null)
                    {
                        return;
                    }
                }
                node.Next = node.Next.Next;
            }
            count -= 1;
        }

        public bool Contains(int value)
        {
            var index = GetIndex(value);
            var node = items[index];
            if (node == null)
            {
                return false;
            }
            if (node.Value == value)
            {
                return true;
            }
            if (node != null && node.Value != value)
            {
                while (node != null)
                {
                    if (node.Value != value && node.Next == null)
                    {
                        return false;
                    }
                    node = node.Next;
                    if (node.Value == value)
                    {
                        return true;
                    }
                }
                return true;
            }
            return false;
        }

        public void ForEach(Action<int> action)
        {
            var index = 0;
            var node = items[index];
            while (index <= capacity - 1)
            {
                while (node != null)
                {
                    action(node.Value);
                    node = node.Next;
                }
                index += 1;
                if (index == capacity)
                {
                    break;
                }
                node = items[index];
            }

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
