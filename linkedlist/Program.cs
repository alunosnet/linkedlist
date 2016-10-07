using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist {
    class Program {
        static void Main(string[] args) {
            //Node node = new Node(5);
            //node.next = new Node(10);
            //node.next.next = new Node(1);
            //node.AddAtEnd(10);
            //node.AddAtEnd(11);
            //node.AddAtEnd(1);
            //node.Print();
            //MyLinkedList myList = new MyLinkedList();
            //myList.AddAtEnd(5);
            //myList.AddAtEnd(10);
            //myList.AddAtEnd(1);
            MyLinkedList myList = new MyLinkedList();
            //myList.AddToBeginning(5);
            //myList.AddToBeginning(10);
            //myList.AddToBeginning(1);
            myList.AddSorted(5);
            myList.AddSorted(10);
            myList.AddSorted(1);
            myList.Print();
            myList.Remove(10);
            myList.Print();
            Console.ReadKey();
        }
    }
}
