using System;

namespace Variable_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber;// Favorite Number Declaration //
            bool isJumping = false, isRunning = false;// Prevents Jumping and Prevents Running //
            float daFloat;// Float Point Declaration //
            favoriteNumber = 128;// Stored Number Variable Value // 
            daFloat = 32;// Float Point Variable Value //
            const double finalGrade = 90.0;// Unchanging Variable Value //

            Console.WriteLine(favoriteNumber);// Display Favorite Number //
            Console.WriteLine(isJumping);// Displays Jumping is set to False //
            Console.WriteLine(isRunning);// Displays Running is set to False //
            Console.WriteLine(daFloat);// Display Float Point Variable //
            Console.WriteLine(finalGrade);// Displays the Unchanging Variable //
        }
    }
}
