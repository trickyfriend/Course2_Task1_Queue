using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MyNode
    {
        string str;
        MyNode next;

        public string Str
        {
            get { return str; }
            set { str = value; }
        }
        public MyNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public MyNode(string str, MyNode next)
        {
            this.Str = str;
            this.Next = next;
        }
    }
}
