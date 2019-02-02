using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(); 
            list.AddLast(1);
            list.AddLast(2); 
            list.AddLast(3); 
            LinkedListNode<int> node = list.Find(2); 
            LinkedListNode<int> newNode = new LinkedListNode<int>(5);
            list.AddAfter(node, newNode); // 리스트 출력 
            list.ToList().ForEach(p => Console.WriteLine(p)); 

            list.Remove(2);
            Console.WriteLine("");
            foreach (var m in list)
            {     
                Console.WriteLine(m);
            }

        }

    }
}
