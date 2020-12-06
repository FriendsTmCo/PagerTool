using System;

public record ResultPager<T>
    {
        public double PageCount { get; set; }
        public List<T> List { get; set; }
    }