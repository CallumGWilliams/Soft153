using System;
using System.Collections.Generic;

namespace inLeui
{
    class Program
    {

        class LinkedListNode
        {
            public int data;
            public LinkedListNode next;
            public LinkedListNode prev;

            public LinkedListNode(int value)
            {
                data = value;
                next = null;
                prev = null;

            }
        }


        class LinkedList
        {
            int count;
            LinkedListNode head;

            LinkedListNode foot;

            public LinkedList()
            {
                head = null;
                count = 0;
                foot = null;
            }

            //adds a node to the front of the linked list
            public void AddFront(int data)
            {
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;
                head = node;
                count++;
            }

            //prints out the linked list
            public void PrintList()
            {
                LinkedListNode runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }

            //generates a random list -> QUESTION A <-
            public void RandomList()
            {
                //generates a random maximum number
                Random ranMax = new Random();
                int maxNum = ranMax.Next(0, 20);

                //generates a random number of elements
                Random ranNum = new Random();
                int N = ranNum.Next(0, maxNum);

                //loops dependant on number of elements
                for (int i = 0; i < N; i++)
                {
                    Random ranData = new Random();
                    int valData = ranData.Next(0, maxNum);

                    LinkedListNode node = new LinkedListNode(valData);
                    node.next = head;
                    head = node;
                    count++;
                }

            }

            //calculates sum of all nodes -> QUESTION B <-
            public void GetSum()
            {
                int sum = 0;

                LinkedListNode runner = head;
                while (runner != null)
                {
                    sum = sum + runner.data;
                    runner = runner.next;

                }

                Console.WriteLine(sum + " is the sum");
            }

            //calculates number of nodes in the linked list -> QUESTION C <-
            public void GetSize() 
            {
                Console.WriteLine(count + " is the size");
            }

            //adds a node to the end of the linked list -> QUESTION D <-
            public void AddLast(int data)
            {
                LinkedListNode foot = head;

                if (head == null)
                {
                    head = new LinkedListNode(data);
                }
                

                while (head.next != null)
                {
                    head = head.next;
                }
                head.next = new LinkedListNode(data);
                count++;
            }
            
            //removes the node at the end of the linked list -> QUESTION E <-
            public void RemoveLast()
            {
                LinkedListNode foot = head;

                while (foot.next.next != null)
                {
                    foot = foot.next;
                }
                foot.next = null;
                count--;

            }
            
            //removes the node one before the end of the linked list -> QUESTION F <-
            public void RemovePenultimate()
            {
                LinkedListNode foot = head;

                for (int i = 0; i < (count - 2); i++)
                {
                    foot = foot.next;
                }
                foot.data = foot.next.data;

                LinkedListNode node = head;

                while (node.next.next != null)
                {
                    node = node.next;
                }
                node.next = null;
                count--;
            }


            //generates the linked list in reverse order -> QUESTION G <-
            public void Reverse()
            {
                LinkedListNode node = head, n = null;
                while (node != null)
                {
                    LinkedListNode tmp = node.next;
                    node.next = n;
                    n = node;
                    node = tmp;
                }
                head = n;
            }

            //duplicates and prints out the entire linked list -> QUESTION H <-
            public void Duplicate()
            {

                LinkedListNode runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    LinkedListNode copied = runner;
                    runner = runner.next;
                }


            }

           
        }

        //call methods for testing purposes
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            //linkedList.RandomList();
            
            //linkedList.AddFront(93);
            linkedList.AddLast(23);
            linkedList.AddLast(13);
            linkedList.AddFront(16);
            linkedList.Reverse();
            linkedList.PrintList();
            linkedList.GetSum();
            linkedList.GetSize();
            linkedList.Duplicate();
            }
    
        }
    }



