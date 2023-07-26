using System.Collections.Generic;

namespace _118._Pascal_s_Triangle
{
    internal class Program
    {
        static public IList<int> GenerateNext(IList<int> array)
        {
            var result = new int[array.Count() + 1];
            result[0] = 1;
            result[result.Length - 1] = 1;
            for (int i = 1; i < result.Length - 1; i++)
            {
                result[i] = array[i - 1] + array[i];
            }
            return result;
        }
        static public IList<IList<int>> Generate(int numRows)
        {
            
            var result = new List<IList<int>>();
            if (numRows >= 1) result.Add(new int[] { 1 });


                for (int i = 1; i < numRows; i++)
            {
               
              int[] last =(int[])result.Last() ;
              result.Add(GenerateNext(last)); 
            }
            return (IList<IList<int>>)result;
            
        }
        static void Main(string[] args)
        {
            var pascalTriangle = Generate(30);
            foreach (var outer in pascalTriangle)
            {
                foreach (var inner in outer)
                {
                    Console.Write(inner + " ");
                }
                Console.WriteLine();
            }
            /*var result = GenerateNext(new int[] { 1,1 });
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }*/
        }
    }
}