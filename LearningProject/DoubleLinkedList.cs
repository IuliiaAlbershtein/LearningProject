using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    // * -> 0      <-->     1        <--> 2       <- .
    // * -> 0
    //   prev: null     prev: 0      prev: 1
    //   next: 1        next: 2      next: null
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
            count = 0;
        }

        public void AddFirst(int value)
        {
            count += 1;
        }

        public void RemoveFirst()
        {
        }

        public void RemoveLast()
        {
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
            return 0;
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

        public void Sort()
        {

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
