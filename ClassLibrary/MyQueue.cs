using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MyQueue
    {
        MyNode head;
        MyNode tail;
        int count;

        public MyNode Head
        {
            get { return head; }
            set { head = value; }
        }

        public MyNode Tail
        {
            get { return tail; }
            set { tail = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }


        public MyQueue()
        {
            this.Head = null;
            this.Count = 0;
        }

        public bool QueueIsEmpty()
        {
            return Head == null;
        }

        public void Enqueue(string surname)
        {
            if (QueueIsEmpty())
            {
                MyNode h = new MyNode(surname, null);
                Head = h;
                Tail = h;
                Count++;
            }
            else
            {
                MyNode t = new MyNode(surname, null);
                Tail.Next = t;
                Tail = t;
                Count++;
            }
        }

        public string Dequeue()
        {
            string s = Head.Str;
            Head = Head.Next;
            Count--;
            return s;
        }

        public string ConvertToString()
        {
            int count = Count;
            string outString = "";
            for(int i = 0; i < count; i ++)
            {
                string str = Dequeue();
                outString += str + " \r\n";
                Enqueue(str);
            }
            return outString;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
    }
}
