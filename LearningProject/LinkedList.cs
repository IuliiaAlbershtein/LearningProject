﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    class LinkedList
    {
        //значение стоящее в начале цепочки
        private Node head;

        //добавление значения вначале
        public void AddFirst(int value)
        {
            var newNode = new Node();
            //создаем указатель от вставленного звена на тоб
            //которое было первым
            newNode.Next = head;
            newNode.Value = value;
            //назначение нового члена цепочки первым
            head = newNode;
        }
        //удаление первого значения
        public void RemoveFirst()
        {
            head = head.Next;
        }
        //удаление последнего значения - проба
        public void RemoveLast()
        {
            var current = head;
            while (current != null)
            {
                current = current.Next;
                if (current.Next == null)
                {
                    current = null;
                }
            }
        }
        //подсчет узлов в цепочке
        public int Count
        {
            get
            {
                var count = 0;
                var node = head;
                //двигаемся по цепочке
                while (node != null)
                {
                    count += 1;
                    node = node.Next;
                }
                return count;
            }
        }
        //получение значения под определенным индексом
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
                    //вернуть значение в данном узле
                    return current.Value;
                }
            }
            return -1;
        }
        //выполнить действие для каждого
        public void ForEach(Action<int> action)
        {
            var current = head;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }
        //вложить указанное значение в указанный индекс
        public void InsertAt(int index, int value)
        {
            var newNode = new Node();
            newNode.Value = value;
            var current = head;
            var i = 0;
            while (current != null)
            {
                current = current.Next;
                i += 1;
                if (i + 1 == index)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }
        //удалить значение в индексе
        public void RemoveAt(int index)
        {
            var i = 0;
            var current = head;
            while (current != null)
            {
                current = current.Next;
                i += 1;
                if (i == index - 1)
                {
                    var temp = current.Next;
                    current.Next = temp.Next;
                }
            }

        }
        //добавить новое последнее значение
        public void AddLast()
        {
            var current = head;
            var newNode = new Node();
            while (current != null)
            {
                current = current.Next;
            }
            if (current.Next == null)
            {
                current.Next = newNode;
                newNode.Next = null;
            }
        }

        public void Sort()
        {

        }

        //создание нового класса Node
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
