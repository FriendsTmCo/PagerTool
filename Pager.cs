using System;
using System.Collections.Generic;

namespace Tools.Paging
{

    public static class Pager<T>
    {

        public static ResultPager<T> Paging(List<T> value,int count = 10, int index = 0)
        {
            //pagecount = value / count 
            //pagecountRemaning = value % count 
            //Page Count = pagecount + pagecountRemaning
            //start = start * count
            int end = 10;
            int start = 0;

            var pagecount = value.Count / count;
            var remaning = value.Count % count;
            var strPageCount = pagecount.ToString() + "." + remaning.ToString();

            //Return Count 
            var pageCount = Convert.ToDouble(strPageCount);


            if (index != 0)
            {
                var st = index * count;
                var en = st + count;
                if (st == en)
                {
                    st = st - en;
                }

                List<T> lst0 = new List<T>();
                if (value.Count > en)
                {
                    for (int i = st; i < en; i++)
                    {
                        lst0.Add(value[i]);
                    }
                }
                else
                {
                    for (int i = st; i < value.Count; i++)
                    {
                        lst0.Add(value[i]);
                    }
                }

                var result0 = new ResultPager<T>()
                {
                    List = lst0,
                    PageCount = pageCount
                };

                return result0;
            }


            //if Index is zero

            List<T> lst = new List<T>();
            if (value.Count > end)
            {
                for (int i = start; i < end; i++)
                {
                    lst.Add(value[i]);
                }
            }
            else
            {
                for (int i = start; i < value.Count; i++)
                {
                    lst.Add(value[i]);
                }
            }

            var result = new ResultPager<T>()
            {
                List = lst,
                PageCount = pageCount
            };

            return result;
        }
    }

}
