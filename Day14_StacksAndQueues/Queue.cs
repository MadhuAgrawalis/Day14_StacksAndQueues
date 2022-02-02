using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Queue
    {
        NewMethod7 head;
        public void Enqueue(int item)
        {
            NewMethod7 new_node = GetNew_node(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                NewMethod7 temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("Inserted into queue : " + new_node.data);
        }

        private static NewMethod7 GetNew_node(int item)
        {
            return NewMethod(item);
        }

        private static NewMethod7 NewMethod(int item)
        {
            return NewMethod1(item);
        }

        private static NewMethod7 NewMethod1(int item)
        {
            return NewMethod2(item);
        }

        private static NewMethod7 NewMethod2(int item)
        {
            return NewMethod3(item);
        }

        private static NewMethod7 NewMethod3(int item)
        {
            return NewMethod4(item);
        }

        private static NewMethod7 NewMethod4(int item)
        {
            return NewMethod5(item);
        }

        private static NewMethod7 NewMethod5(int item)
        {
            return NewMethod6(item);
        }

        private static NewMethod7 NewMethod6(int item)
        {
            throw new NotImplementedException();
        }

        private static NewMethod7 NewMethod7(int item)
        {
            return new Node(item);
        }

        //delete the element in front end
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            NewMethod7 temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("\nItem deleted is {0}", temp.data);
        }

        public void Display()
        {
            NewMethod7 temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("No element present in the Queue");
                return;
            }
            Console.WriteLine("The nodes are : ");
            while (temp != null)
            {

                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }
    }
}