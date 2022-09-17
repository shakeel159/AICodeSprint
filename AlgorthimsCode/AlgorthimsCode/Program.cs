namespace AlgorthimsCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        //constant time
        //O(1) describes an algorithm that will always execute in the same time (or space) regardless of the size of the input data set.
        public void PrintOneNumber(int[] nums)
        {
            Console.Write(nums[0]);
        }

        //linear time
        //escribes an algorithm that will always execute in the same time (or space) regardless of the size of the input data set.
        public void PrintAllNumbers(int[] nums)
        {
            foreach (var number in nums)
            {
                Console.WriteLine(nums);
            }
        }

        //O(n2) represents an algorithm whose performance is directly proportional to the square of the size of the input data set.
        //This is common with algorithms that involve nested iterations over the data set. 

        public bool FindTheMax(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}