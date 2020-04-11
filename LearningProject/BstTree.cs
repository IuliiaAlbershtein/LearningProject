using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    class BstTree
    {
        private Node head;

        public BstTree()
        {
        }

        public void ForEach(Action<int> action)
        {
            ForEach(head, action);
        }

        private void ForEach(Node node, Action<int> action)
        {
            if (node == null) return;

            ForEach(node.Left, action);
            action(node.Value);
            ForEach(node.Right, action);
        }
        private void ForEachI(Node node, Action<int> action)
        {/*
            Stack newStack = new Stack();
            newStack = null;
            var current = head;
            if (head == null)
            {
                return;
            }
            while (current != null)
            {
                newStack.Push(current);
                current = current.Left;
            }
            if (current == null)
            {
                current = newStack.Pop();

                Consol
                
            }*/
            
        }
        public bool Contains(int value)
        {
            return Contains(head, value);
        }
        public bool ContainsI(int value)
        {
            return ContainsI(head, value);
        }

        private bool Contains(Node node, int value)
        {
            if (node == null) return false;

            if (value < node.Value)
            {
                return Contains(node.Left, value);
            }
            else if (value > node.Value)
            {
                return Contains(node.Right, value);
            }
            else
            {
                return true;
            }
        }
        private bool ContainsI(Node node, int value)
        {
            while (true)
            {
                if (node == null)
                {
                    return false;
                }
                else if (value < node.Value)
                {
                    node = node.Left;
                }
                else if (value > node.Value)
                {
                    node = node.Right;
                }
                else
                {
                    return true;
                }
            }
        }
        public void AddR(int newValue)
        {
            AddR(head, newValue);
        }
        private void AddR(Node node, int newValue)
        {
            if (head == null)
            {
                head = new Node(newValue);
                return;
            }
            else if (newValue < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(newValue);
                    return;
                }
                // node = node.Left;
                AddR(node.Left, newValue);
            }
            else if (newValue > node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(newValue);
                    return;
                }
                // node = node.Right;
                AddR(node.Right, newValue);
            }
            else
            {
                return;
            }
        }
        public void Add(int newValue)
        {
            if (head == null)
            {
                head = new Node(newValue);
                return;
            }

            var current = head;
            while (true)
            {
                if (newValue < current.Value)
                {
                    // go left
                    if (current.Left == null)
                    {
                        current.Left = new Node(newValue);
                        return;
                    }

                    current = current.Left;
                }
                else if (newValue > current.Value)
                {
                    // go right
                    if (current.Right == null)
                    {
                        current.Right = new Node(newValue);
                        return;
                    }

                    current = current.Right;
                }
                else
                {
                    // equals, already added
                    return;
                }
            }
        }

        public void Remove(int value)
        {
            if (head == null)
            {
                return;
            }
            
            // remove head
            if (head.Value == value)
            {
                // if right subtree is empty
                if (head.Right == null)
                {
                    head = head.Left;
                    return;
                }

                // right is not empty
                var leftSubtree = head.Left;

                head = head.Right;

                var current = head;
                while (true)
                {
                    if (current.Left == null)
                    {
                        current.Left = leftSubtree;
                        return;
                    }

                    current = current.Left;
                }
            }

            // remove some other node
        }


        class Node
        {
            public Node(int value)
            {
                this.value = value;
            }

            private int value;
            public int Value
            {
                get { return value; }
                set { this.value = value; }
            }

            private Node left;
            public Node Left
            {
                get { return left; }
                set { left = value; }
            }

            private Node right;
            public Node Right
            {
                get { return right; }
                set { right = value; }
            }

            public override string ToString()
            {
                return $"{value}";
            }
        }
    }
}
