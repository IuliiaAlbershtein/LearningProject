﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    class DoubleLinkedList
    {
        private Node head;
        private Node tail;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFirst(int value)
        {
            var newNode = new Node();
            newNode.Value = value;
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
            count += 1;
        }

        public void RemoveFirst()
        {
            head = head.Next;
            count -= 1;
        }

        public void RemoveLast()
        {
            tail = tail.Previous;
            count -= 1;
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

        public int GetValue(int index)
        {
            var countNodes = 0;
            var current = head;
            while (countNodes != index)
            {
                current = current.Next;
                countNodes += 1;
            }
            return current.Value;
        }

        public void InsertAt(int index, int value)
        {
            var countNodes = 0;
            var current = head;
            var newNode = new Node();
            newNode.Value = value;
            if (index == 0)
            {
                newNode.Value = value;
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head.Previous = newNode;
                    head = newNode;
                }
            }
            while (countNodes <= index)
            {
                if (countNodes + 1 == index)
                {
                    newNode.Next = current.Next;
                    newNode.Previous = current;
                    current.Next = newNode;
                }
                current = current.Next;
                countNodes += 1;
                if (countNodes == index + 1 && current != null)
                {
                    current.Previous = newNode;
                }
            }
            if (index == count)
            {
                newNode.Value = value;
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    tail = newNode;
                }
            }
            count += 1;
        }

        public void RemoveAt(int index)
        {
            var countNodes = 0;
            var current = head;
            if (index == 0)
            {
                RemoveFirst();
            }
            else if (index == count - 1)
            {
                RemoveLast();
            }
            else
            {
                while (current != null)
                {
                    if (countNodes + 1 == index)
                    {
                        var temp = current.Next;
                        current.Next = temp.Next;

                        current = current.Next;
                        temp = current.Previous;
                        current.Previous = temp.Previous;
                    }
                    /*if ()
                    {

                    }*/
                    current = current.Next;
                    countNodes += 1;
                }
                count -= 1;
            }
        }

        public void AddLast(int value)
        {
            var newNode = new Node();
            newNode.Value = value;
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
            count += 1;
        }
        public void Swap(int index)
        {
            var k = 0;
            var current = head;
            if (index == 0)
            {
                head = current.Next;
                current.Next = head.Next;
                current.Previous = head;
                head.Next = current;
                head.Previous = null;
                current.Next.Previous = current;
            }
            if (index != 0)
            {
                while (k <= index)
                {
                    if (index == Count - 1)
                    {
                        break;
                    }

                    if (k == index)
                    {
                        var temp = current.Value;
                        RemoveAt(k);
                        if (k == count)
                        {
                            AddLast(temp);
                        }
                        else
                        {
                            InsertAt(k + 1, temp);
                        }
                    }
                    k += 1;
                    current = current.Next;
                }
            }
        }
        public void Sort()
        {
            var current = head;
            var index = 0;
            var count = this.Count;
            while (current != null && count >= 0)
            {
                while (count - 2 >= 0 && index < count - 1)
                {
                    if (current.Value > current.Next.Value)
                    {
                        current = current.Next;
                        Swap(index);
                    }
                    current = current.Next;
                    index += 1;
                }
                current = head;
                index = 0;
                count -= 1;
            }
        }

        class Node
        {
            //в нем существуют значения
            private int value;
            //конструкция getter/setter для возвращения/становления значения
            public int Value
            {
                get { return value; }
                //при вызове сеттера можно расширить условия
                set { this.value = value; }
            }

            //ссылка на предыдущее значение
            private Node previous;
            public Node Previous
            {
                get { return previous; }
                set { previous = value; }
            }

            //ссылка на следующее значение
            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            //расширение или упрощение доступной функционалиты под свои требования
            public override string ToString()
            {
                //неуверена в понимании синтаксиа???????????
                return $"{value}";
            }
        }
    }
}
