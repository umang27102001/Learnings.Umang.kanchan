using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class CustomQueue<T>
    { 
            private class Node
            {
                public T Val { get; set; }
                public Node Next { get; set; }
                public Node(T val)
                {
                    this.Val = val;
                }
            }
            private Node _head;
            private Node _tail;

            public void Enqueue(T val)
            {
                Node newNode = new Node(val);
                if (_head == null)
                {
                    _head = _tail = newNode;
                    return;
                }
                _tail.Next = newNode;
                _tail = newNode;
            }

            public T Dequeue()
            {
                if (IsEmpty()) return default;
                T val = _head.Val;
                _head = _head.Next;
                return val;
            }
            public bool IsEmpty()
            {
                return _head == null;
            }
            public void Print()
            {
                Node it = _head;
                while (it != null)
                {
                    Console.Write(it.Val + " ");
                    it = it.Next;
                }
            }
        }
    }

