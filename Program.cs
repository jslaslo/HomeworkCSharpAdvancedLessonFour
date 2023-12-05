using static Homework.TaskOne;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bits bit = new(100);
            Bits bitInt = new(99);
            Bits bitByte = new(50);
            Bits bitLong = new(3);

            Console.WriteLine(bit);
            Console.WriteLine(bitInt);
            Console.WriteLine(bitByte);
            Console.WriteLine(bitLong);

        }
    }
}
