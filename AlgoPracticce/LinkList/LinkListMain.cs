using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPracticce.LinkList
{
    class LinkListMain
    {
        static void Main(string[] args)
        {
            MyLinkList<int> demoLinkList = new MyLinkList<int>();
            demoLinkList.AddFirst(4);
            demoLinkList.AddFirst(42);
            demoLinkList.AddFirst(43);
           
            demoLinkList.AddFirst(44);
            demoLinkList.AddFirst(54);

            demoLinkList.DisplayList();
            demoLinkList.Remove(54);
            demoLinkList.Remove(4);
            demoLinkList.DisplayList();
        }
    }
}
