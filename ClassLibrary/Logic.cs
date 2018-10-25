using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public static class Logic
    {

        public static void QueueAddSort(MyQueue q, string str)
        {
            int count = q.Count;
            bool strIsAdded = false;
            for (int i = 0; i < count; i++)            {
                string sLast = q.Dequeue();
                if (str.CompareTo(sLast) <= 0 && strIsAdded == false)
                {
                    q.Enqueue(str);
                    q.Enqueue(sLast);
                    strIsAdded = true;
                }
                else
                    q.Enqueue(sLast);
            }
            if (strIsAdded == false)
                q.Enqueue(str);
        }
    }
}
