using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using static DataStructures.LinkedLists;

namespace DSA
{
    public class LLchallenges

    {
        //Still getting infinite loop
        public static LinkedLists mergeLists(LinkedLists lOne, LinkedLists lTwo)
        {

            if (lOne.Head != null && lTwo.Head != null)
            {

                Node oneCurrent = lOne.Head.Next;
                Node twoCurrent = lTwo.Head;
                Node newCurrent = lOne.Head;
                while (oneCurrent != null || twoCurrent != null)
                {
                    if (twoCurrent != null)
                    {
                        newCurrent.Next = twoCurrent;
                        newCurrent = newCurrent.Next;
                        twoCurrent = twoCurrent.Next;
                    }

                    if (oneCurrent != null)
                    {
                        newCurrent.Next = oneCurrent;
                        newCurrent = newCurrent.Next;
                        oneCurrent = oneCurrent.Next;
                    }
                }
                return lOne;
            }
            else if (lOne.Head != null && lTwo.Head == null)
            {
                return lOne;
            } else if (lOne.Head == null && lTwo.Head != null)
            {
                return lTwo;
            } else
            {
                return lOne;
            }
        }

        public static LinkedLists oldMergeLists(LinkedLists lOne, LinkedLists lTwo)
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
