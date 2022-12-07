using System.Text;

namespace Concepts_and_Interview_Questions.Basic.Concepts
{
    /// <summary>
    /// This is a Custom Linked List class implementation
    /// </summary>
    public class CustomSingleLinkedList
    {
        private int _length;
        private Node? _mainNode;

        public int Length { get => _length; set => _length = value; }
        public Node MainNode { get => _mainNode; set => _mainNode = value; }

        public CustomSingleLinkedList()
        {
            _length = 0;
            _mainNode = null;
        }

        public void GetAllNodes()
        {
           
        }

        public void Add(object data)
        {
            var newNode = new Node() { Data = data, Next = null };
            if (_mainNode == null)
            {
                _mainNode = newNode;
                return;
            }

            Node node = _mainNode;
            //traverse to the end of the linked list
            while (node.Next != null)
            {
                node = node.Next;
            }

            node.Next = newNode;
        }

        public void Add(object data, int position)
        {
            var newNode = new Node() { Data = data, Next = null };

            if (_mainNode == null)
            {
                _mainNode = newNode;
                return;
            }

            int i = 0;

            Node node = _mainNode;
            //traverse to the 1 position less than the actual position;
            while (node.Next != null && i < position - 1)
            {
                node = node.Next;
                i++;
            }

            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public void Delete(int index)
        {
            Node currentNode = _mainNode;
            if (currentNode == null)
                return;

            int i = 0;

            //traverse from beginning to the node before it go to delete. 
            while (currentNode.Next != null && i < index -1)
            {
                currentNode = currentNode.Next;
                i++;
            }

            Node temp = currentNode.Next; //save the node to delete
            currentNode.Next = currentNode.Next.Next; //previous node next points to next of delete the node
            temp.Next = null;

        }

        public string DisplayNodesData(Node headNode = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Node p = headNode ?? _mainNode;
            int counter = 0;
            while (p != null)
            {
                stringBuilder.Append($"Node{counter}->{p.Data}");
                counter++;
                p = p.Next;
            }
            return stringBuilder.ToString();
        }
    }

    public class Node
    {
        private object _data;
        private Node? _next;

        public object Data { get => _data; set => _data = value; }
        public Node? Next { get => _next; set => _next = value; }

        public Node()
        {
            _data = 0;
            _next = null;
        }

        public Node(object data, Node next)
        {
            _data = data;
            _next = next;
        }
    }
}
