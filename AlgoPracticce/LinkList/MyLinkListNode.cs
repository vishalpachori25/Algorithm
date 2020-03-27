using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPracticce.LinkList
{
    public class MyLinkListNode<T>
    {
        public T Data { get; set; }
        public MyLinkListNode<T> Next { get; set; }
        public MyLinkListNode<T> Previous { get; set; }
        public MyLinkListNode(T data)
        {
            Data = data;
        }
    }
}
