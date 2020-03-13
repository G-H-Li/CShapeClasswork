using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            this.Next = null;
            this.Data = t;
        }
    }
}
