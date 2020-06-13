using System;
using System.ComponentModel;

namespace pe6
{
    internal class ProcessSortSearch
    {

        //------------------------------------------------------------------------SortAsc
        internal static void SortDate(BindingList<Goods> bList) 
        {
            int N = bList.Count;
            Goods ct;
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N - 1; i++) 
                {
                    if (bList[i].Date > bList[i + 1].Date)
                    {
                        ct = bList[i];
                        bList[i] = bList[i + 1];
                        bList[i + 1] = ct;
                    }

                }

            }

        }
        internal static void SortPrice(BindingList<Goods> bList)
        {
            int N = bList.Count;
            Goods ct;
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    if (bList[i].Price > bList[i + 1].Price)
                    {
                        ct = bList[i];
                        bList[i] = bList[i + 1];
                        bList[i + 1] = ct;
                    }

                }

            }

        }
        internal static void SortKolvo(BindingList<Goods> bList)
        {
            int N = bList.Count;
            Goods ct;
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    if (bList[i].kolvo > bList[i + 1].kolvo)
                    {
                        ct = bList[i];
                        bList[i] = bList[i + 1];
                        bList[i + 1] = ct;
                    }

                }

            }

        }
        internal static void SortSum(BindingList<Goods> bList)
        {
            int N = bList.Count;
            Goods ct;
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    if (bList[i].Sum > bList[i + 1].Sum)
                    {
                        ct = bList[i];
                        bList[i] = bList[i + 1];
                        bList[i + 1] = ct;
                    }

                }

            }

        }
        internal static void SortNumber(BindingList<Goods> bList)
        {
            int N = bList.Count;
            Goods ct;
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    if (bList[i].Number > bList[i + 1].Number)
                    {
                        ct = bList[i];
                        bList[i] = bList[i + 1];
                        bList[i + 1] = ct;
                    }

                }

            }

        }
        //-------------------------------------------------------------------------SearchLinear
        internal static bool SearchLinear(BindingList<Goods> bList, int price) 
        {
            foreach (Goods c in bList)
            {
                if (c.Price == price)
                {
                    return true;
                }
            }
            return false;
        }

        internal static bool SearchLinear(BindingList<Goods> bList, Goods ct)
        {
            return SearchLinear(bList, ct.Price);
        }
        //-------------------------------------------------------------------SearchBinary
        private static bool SearchBinary(BindingList<Goods> bList, int price , int l, int r) 
        {

            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (bList[mid].Price == price)
                    return true;

                if (bList[mid].Price > price)
                    return SearchBinary(bList, price, l, mid - 1);

                return SearchBinary(bList, price, mid + 1, r);
            }

            return false;
        }

        internal static bool SearchBinary(BindingList<Goods> bList, Goods ct)
        {
            return SearchBinary(bList, ct.Price, 0, bList.Count);
        }
        internal static bool SearchBinary(BindingList<Goods> bList, int price)
        {
            return SearchBinary(bList, price, 0, bList.Count);
        }
        //---------------------------------------------------------------------end
    }
}
