namespace TupleRevision
{
    public class SystemValueTuple
    {

        public void Run()
        {
            //reference type
            Tuple<int, string> value1 = new(1, "Karthik");

            //value type
            ValueTuple<int, string> value2 = (2, "Karthik");
            ValueTuple<int, string> value3 = new ValueTuple<int, string>(3, "Karthik");

             Console.WriteLine($"{value1.Item1} {value2.Item1}");

            int[] numbers = [1,2,3,4,5];
            int max = 0;
          int min = this.FindMinMax(numbers,out max) ;
          Console.WriteLine($"Maximum number is {max} and the minimum number is {min}");

          (min, max) = FindMaxUsingTuple(numbers);
          Console.WriteLine($"Using Tuples - Maximum number is {max} and the minimum number is {min}");

        }

        // Without Tuple
        public int FindMinMax(int[] numbers, out int max)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.");
            }

            int min = numbers[0];
            max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        // With Tuple (Another alternate is to use record or a class to store min and max

        public (int Min, int Max) FindMaxUsingTuple(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.");
            }

            int min = numbers[0];
            int max = numbers[0];

            for (int i=1; i< numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return (min, max);
        }

    }
}
