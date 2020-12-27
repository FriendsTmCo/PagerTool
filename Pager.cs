using System;
using System.Collections.Generic;

public static class Pager<T>
{
    public static ResultPager<T> Paging(List<T> value, int count = 10, int index = 0)
    {

        var pagecount = value.Count / count;
        var remaning = value.Count % count;
        var strPageCount = pagecount.ToString() + "." + remaning.ToString();

        //Return Count 
        var pageCount = Convert.ToDouble(strPageCount);

        int skip = index * count;
       
        return new ResultPager<T>()
        {
            List = value.Skip(skip).Take(count).ToList(),
            PageCount = pageCount
        };
    }
}

