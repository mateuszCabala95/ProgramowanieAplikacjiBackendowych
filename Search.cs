using System;
using System.Collections.Generic;

namespace Backend
{
    public static class Search
    {

        public static int BinarySearch(List<int> array, int value)
        {
            array.Sort();
            int index = 0;
            double limit = array.Count - 1;

            while (index <= limit)
            {
                var point = (int)Math.Ceiling((index + limit) / 2);
                var entry = array[point];

                if (value > entry)
                {
                    index = point + 1;
                    continue;
                }

                if (value < entry)
                {
                    limit = point - 1;
                    continue;
                }

                return point;
            }

            return -1;
        }
    }
}
