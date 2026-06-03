using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Node<T>{
        public T data;
        public Node<T>? next; //'?' allows to accept null values

        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }

    public class LinkedListExample<T>
    {
        public Node<T>? head;
        public Node<T>? ptr;
        public LinkedListExample()
        {
            this.head = null;
        }
        public void add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                ptr = head;
                while (ptr.next != null)
                {
                    ptr = ptr.next;
                }
                ptr.next = node;
            }
        }

        public void display()
        {
            ptr = head;
            while (ptr != null)
            {
                Console.Write(ptr.data + " ");
                ptr = ptr.next;
            }
        }
    }

    internal class Generic
    {
        public static void main(string[] args)
        {
            LinkedListExample<int> list = new LinkedListExample<int>();
            list.add(1);
            list.add(2);
            list.add(3);
            list.display();

            // 1 2 3 
        }
    }
}
