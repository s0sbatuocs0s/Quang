using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanhso1
{
    class Node<A>
    {
        Node<A> data;

        internal Node<A> Data
        {
            get { return data; }
            set { data = value; }
        }
        private Node<A> next;

        internal Node<A> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
