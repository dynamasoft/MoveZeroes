using System;
using System.Collections.Generic;
using System.Linq;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {         
            int [] nums = { 0, 1, 0, 3, 12 };           

            MoveZeroes1(nums);
            Console.WriteLine(string.Join("\n", nums.ToArray()));


            MoveZeroes1(nums);
            Console.WriteLine(string.Join("\n", nums.ToArray()));

        }



        static public void MoveZeroes1(int [] nums)
        {
            List<int> inputList = new List<int>();

            inputList.AddRange(nums);

            var count = inputList.Where(a => a == 0).Count();

            inputList.RemoveAll(a => a == 0);

            inputList.Sort();

            for (int i = 0; i < count; i++)
            {
                inputList.Add(0);
            }

            int index = 0;
            foreach(var value in inputList.ToArray())
            {
                nums[index++] = value;
            }
        }


        static public void MoveZeroes2(int[] nums)
        {
            int zeroIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[zeroIndex++] = nums[i];
            }

            while (zeroIndex < nums.Length)
                nums[zeroIndex++] = 0;

            //Console.WriteLine(string.Join("\n", nums.ToArray()));
        }
    }
}
