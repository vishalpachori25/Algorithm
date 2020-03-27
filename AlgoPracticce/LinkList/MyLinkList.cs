using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgoPracticce.LinkList
{
    public class MyLinkList<T> : IEnumerable<T>, ICollection<T>
    {
        public MyLinkListNode<T> Head { get; set; }
        public MyLinkListNode<T> Tail { get; set; }

        int ICollection<T>.Count => Count();

        public bool IsReadOnly =>false;

        public MyLinkList()
        {
            Head = null;
        }

        public MyLinkList(MyLinkListNode<T> node)
        {
            Head = node;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }
        public void DisplayList()
        {
            Console.WriteLine("List From Head to Tail--->");
            MyLinkListNode<T> currentNode = Head;
            while (currentNode !=null)
            {
                Console.WriteLine($"< {currentNode.Data} >");
                currentNode = currentNode.Next;
            }
        }
        public void Clear()
        {
            Head = null;
        }
        public int Count()
        {
            if (Head==null)
            {
                return 0;
            }

            MyLinkListNode<T> currentNode = Head;
            int count = 0;
            while (currentNode.Next!=null)
            {
                count++;
            }
            return count;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(this);
        }
        /// <summary>
        /// This will insert the newnode to the last of the List
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            MyLinkListNode<T> newNode = new MyLinkListNode<T>(item)
            {
                Next = null
            };
            if (Head == null)
            {
                Head = newNode;
            }

            var lastNode = Head;
            while (lastNode.Next != null)
            {
                lastNode = lastNode.Next;
            }
            lastNode.Next = newNode;
        }

        /// <summary>
        /// This will insert the newnode to the First of the List
        /// </summary>
        /// <param name="item"></param>
        public void AddFirst(T item)
        {
            MyLinkListNode<T> newNode = new MyLinkListNode<T>(item)
            { Next = Head };

            Head = newNode;
       }

        /// <summary>
        /// This will insert the newnode to the First of the List
        /// </summary>
        /// <param name="item"></param>
        public void AddFirst(MyLinkListNode<T> item)
        {
            item.Next = Head;
            Head = item;
        }

        /// <summary>
        /// This will insert the newnode after specific node
        /// </summary>
        /// <param name="item"></param>
        public void AddAfter(MyLinkListNode<T> node, T item)
        {
            MyLinkListNode<T> newNode = new MyLinkListNode<T>(item)
            { Next = node };

            newNode.Next = node.Next;
            node.Next = newNode;
        }
        /// <summary>
        /// This will insert the newnode after specific node
        /// </summary>
        /// <param name="item"></param>
        public void AddAfter(MyLinkListNode<T> node, MyLinkListNode<T> newNode)
        {
            newNode.Next = node.Next;
            node.Next = newNode;
        }

      
        public bool Contains(T item)
        {
            if (Head == null)
            {
                return false;
            }
            MyLinkListNode<T> currentNode = Head;
            if (currentNode != null && currentNode.Data.Equals(item))
            {
                return true;
            }
            while (currentNode != null && !currentNode.Data.Equals(item)  )
            {
                currentNode = currentNode.Next;
            }
            
            return currentNode.Data.Equals(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count() > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            var currentNode = Head;
            for (int i = 0; i < arrayIndex; i++)
            {
                array[i + arrayIndex] = currentNode.Data;
                currentNode = currentNode.Next;
            }
        }

        public bool Remove(T item)
        {
            if (!Contains(item))
            {
                return false;
            }
            MyLinkListNode<T> prevNode = null, currentNode = Head;

            if (currentNode != null && currentNode.Data.Equals(item))
            {
                Head = currentNode.Next;
                return true;
            }
            while (currentNode != null && !currentNode.Data.Equals(item))
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }

            if (currentNode == null)
            {
                return false;
            }

            prevNode.Next = currentNode.Next;
            return true;

        }

        class MyEnumerator : IEnumerator<T>
        {
            private MyLinkList<T> _collection;
            private MyLinkListNode<T> _current;
            public MyEnumerator(MyLinkList<T> collection)
            {
                _collection = collection;
                _current = _collection.Head;
            }
            public T Current => _current.Data;

            object IEnumerator.Current => _current;

            public void Dispose()
            {
                _collection = null;
                _current = null;
            }

            public bool MoveNext()
            {
                if (_current == null || _current.Next == null)
                {
                    return false;
                }
                _current = _current.Next;
                return true;
            }

            public void Reset()
            {
                _current = _collection.Head;
            }
        }
    }
}
