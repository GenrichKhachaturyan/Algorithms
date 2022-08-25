using System;

namespace Geek
{
    public class Homework2
    {
        public static void Main(string[] args)
        {
            var list = new GeekList<int>();

            list.AddFirts(10);
            list.AddFirts(15);
            var test = list.AddFirts(200);
            list.AddAfter(test, 30);

            Console.WriteLine("Amount list: {0}",list.CountNodeList);
            Console.WriteLine("Amount node test : {0}", test.CountNode);

            list.RemoveNode(test);
            list.RemoveIndx(1);
            Console.WriteLine();

        }
    }
}