using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanhso1
{
    class List<N>
    {
        Node<N> head;

        internal Node<N> Head
        {
            get { return head; }
            set { head = value; }
        }
        Node<N> tail;

        internal Node<N> Tail
         {
             get { return tail; }
        set { tail = value; }
           } 
        public void addfist(Node<N> n)
        {
            n.Next = head;
            this.head = n ;
        }
        public List()
        {
            this.head = null; 
        }
        public void PrintSolution()
        {
            Node<N> point = head;
            while (point.Next != null)
            {
                Console.WriteLine(point.Data);
                point = point.Next;
            }
        }
      

        internal void addfist(Node<int> a)
        {
            throw new NotImplementedException();
        }
    }        
}

