using System;
namespace SomeTestLoginovIP
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsLine newsLine = new NewsLine();
            newsLine.AddLine(new Record("привет", 1, "dfdf", 23));
            newsLine.AddLine(new Record("пока", 2, "asddfdf", 33));
            newsLine.AddLine(new Record("покаыфв", 5, "asf", 3));
            newsLine.SortRecords();
            foreach (var p in newsLine)
            {
                Console.WriteLine(p);
            }
        }
    }
}