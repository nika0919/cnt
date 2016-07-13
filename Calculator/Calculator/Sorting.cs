using System;

namespace Calculator
{
    public class Sorting: ISorting
    {
        public void Sort(double[] a)
        {
            Sort(a,0,1);
        }

        private void Sort(double[] a, int l, int r)
        {
            double temp;
            double x = a[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
            {
                Sort(a, i, r);
            }

            if (l < j)
            {
                Sort(a, l, j);
            }
        }


    }
}