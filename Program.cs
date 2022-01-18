using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pro7568
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> inputs = new Dictionary<int, int>();
            int[] line = new int[input];
            string[] vs = new string[2];    
            for (int i = 0; i < input; i++)
            {
                
                vs = Console.ReadLine().Split(' ');
                inputs.Add(Convert.ToInt32(vs[0]), Convert.ToInt32(vs[1]));
            }

            int[] size = new int[input];
            int[] Height = new int[input];
            int count = 0;
            foreach(KeyValuePair<int, int> pair in inputs)
            {
                line[count] = pair.Key;
                size[count] = pair.Key;
                Height[count] = pair.Value;
                count++;
            }

            sortingTable(size);
            sortingTable(Height);

            string rank = "";
            int rankCount = 1;

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < input ; i++)
            {
                int R = 0; //rankNumber
                int outputCount = 0;
                do
                {
                    R = size[outputCount];

                    outputCount++;
                }
                while (inputs[line[i]] != R);

                if(line[outputCount + 1] > line[outputCount]) //if draw
                {
                    sb.Append((outputCount + 1) + ' ');
                    sb.Append((outputCount + 1) + ' ');

                    i++;
                }

                else //if not draw
                {
                    sb.Append((outputCount + 1) + ' ');

                }

                
            }

            Console.WriteLine(sb);


        }

        public static void sortingTable(int[] input)
        {
            bool itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
        }
    }
}
