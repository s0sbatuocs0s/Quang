using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanhso1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> a = new Node<int>(3) ;
            Node<int> b = new Node<int>(4) ;
            Node<int> c = new Node<int>(5) ;
            List<Node<int>> Q = new List<Node<int>>();
            Q.addfist(a);
            Q.addfist(b);
            Q.addfist(c);
            Q.PrintSolution();

        }
    }
   
}
