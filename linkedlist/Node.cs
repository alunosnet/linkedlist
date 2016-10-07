using System;

namespace linkedlist {
    public class Node {
        public int data;
        public Node next;

        public Node(int data) {
            this.data = data;
            next = null;
        }

        public void Print() {
            Console.Write($"{data}|->");
            if (next != null) {
                next.Print();

            }
           
        }
        public void AddSorted(int data) {
            if (next == null)
                next = new Node(data);
            else if(data<next.data) {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }else {
                next.AddSorted(data);
            }
        }
        public void AddAtEnd(int data) {
            if (next == null) {
                next = new Node(data);
                return;
            }
            next.AddAtEnd(data);
        }
    }

    public class MyLinkedList {
        public Node head;

        public MyLinkedList() {
            head = null;
        }


        public void AddAtEnd(int data) {
            if (head == null)
                head = new Node(data);
            else
                head.AddAtEnd(data);
        }

        public void AddToBeginning(int data) {
            if (head == null) {
                head = new Node(data);
            }else {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
        }

        public void AddSorted(int data) {
            if (head == null) {
                head = new Node(data);
            }else {
                if (data < head.data) {
                    AddToBeginning(data);
                } else {
                    head.AddSorted(data);
                }
            }
        }

        public void Remove(int data) {
            Node temp = head;
            if (head.data == data) {
                head = head.next;
                return;
            }
            while (temp != null) {
                if (temp.data == data) {
                    Node prev = head;
                    while (prev.next != temp)
                        prev = prev.next;
                    prev.next = temp.next;
                }
                temp = temp.next;
            }
        }
        public void Print() {
            head.Print();
        }
    }
}