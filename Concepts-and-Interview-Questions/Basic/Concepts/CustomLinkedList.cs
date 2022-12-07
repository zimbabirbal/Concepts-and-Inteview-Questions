using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts_and_Interview_Questions.Basic.Concepts
{
    /// <summary>
    /// This is a Custom Linked List class implementation
    /// </summary>
    internal class CustomLinkedList
    {
        private int _length;
        private Node? _mainNode;

        public int Length { get => _length; set => _length = value; }
        public Node MainNode { get => _mainNode; set => _mainNode = value; }

        public CustomLinkedList()
        {
            _length = 0;
            _mainNode = null;
        }

        internal void GetAllNodes()
        {
            if (_length == 0 || _mainNode == null)
            {
                Console.WriteLine("No nodes found");
                return;
            }

            //start the heads from the beginning
            Console.WriteLine("CustomLinkedList data:");
            while (_mainNode.Next != null)
            {
                Console.WriteLine($"{_mainNode.Data} ");
                _mainNode = _mainNode.Next;
            }
        }

        internal void Add(int data)
        {
            if (_mainNode == null)
            {
                _mainNode = new Node()
                {
                    Data = data,
                    Index = _length++,
                    Next = null
                };

                return;
            }

            //traverse to the end of the linked list
            while (_mainNode.Next != null)
            {
                _mainNode = _mainNode.Next;
            }

            _mainNode.Next = new Node()
            {
                Data = data,
                Index = _length++,
                Next = null
            };
        }

        internal void Delete(int index)
        {
            Node currentNode = _mainNode;
            if (currentNode == null)
                return;

            while (currentNode.Next != null && currentNode.Index == index)
            {
                currentNode.Next = currentNode.Next.Next;
                currentNode = null;
                _length--;
                break;
            }
        }
    }

    internal class Node
    {
        private int _data;
        private Node? _next;
        private int _index;

        public int Data { get => _data; set => _data = value; }
        public Node? Next { get => _next; set => _next = value; }
        public int Index { get => _index; set => _index = value; }

        public Node()
        {
            _index = 0;
            _data = 0;
            _next = null;
        }

        public Node(int index, int data, Node next)
        {
            _index = index;
            _data = data;
            _next = next;
        }
    }
}
