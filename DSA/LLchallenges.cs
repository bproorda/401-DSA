using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using static DataStructures.LinkedLists;

namespace DSA
{
    public class LLchallenges
    {
        public static LinkedLists mergeLists(LinkedLists lOne, LinkedLists lTwo)
        {
            LinkedLists mergedList = new LinkedLists();
            Node mCurrent = null;
            Node l1Current = lOne.Head;
            Node l2Current = lTwo.Head;
            mCurrent = l1Current;
            mergedList.Head = mCurrent;
            l1Current = l1Current.Next;

            while (l1Current != null || l2Current != null)
            {
                if (l2Current != null)
                {
                    mCurrent.Next = l2Current;
                    l2Current = l2Current.Next;
                    mCurrent = mCurrent.Next;
                }

                if (l1Current != null)
                {
                    mCurrent.Next = l1Current;
                    l1Current = l1Current.Next;
                    mCurrent = mCurrent.Next;
                }

            }
            return mergedList;
        }
    }
}
