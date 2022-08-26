using System;
using System.Threading;

namespace AnimationConsole_vr_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicOldTownRow.MenuStart();
        }
    }

    static class MusicOldTownRow
    {

        public static void MenuStart()
        {
            StepOne();
            
        }

        static void StepOne()
        {
            int stepbystep = 0;
            int start = 0;

            while (true)
            {

                if (start == 10000)
                {
                    StepTwo();
                    break;
                }

                switch (stepbystep)
                {
                    case 0: Console.WriteLine("*"); stepbystep = 1; break;
                    case 1: Console.WriteLine("**"); stepbystep = 2; break;
                    case 2: Console.WriteLine("***"); stepbystep = 3; break;
                    case 3: Console.WriteLine("****"); stepbystep = 4; break;
                    case 4: Console.WriteLine("*****"); stepbystep = 5; break;
                    case 5: Console.WriteLine("****"); stepbystep = 6; break;
                    case 6: Console.WriteLine("***"); stepbystep = 7; break;
                    case 7: Console.WriteLine("**"); stepbystep = 8; break;
                    case 8: Console.WriteLine("*"); stepbystep = 2; break;
                }

                start++;
            }
        }

        static void StepTwo()
        {
            
            int stepbystep2 = 0;
            int start = 0;

            while (true)
            {

                if (start == 100000)
                {
                    StepThree();
                    break;
                }
                switch (stepbystep2)
                {
                    case 0: Console.WriteLine("\t    *"); stepbystep2 = 1; break;
                    case 1: Console.WriteLine("\t   **"); stepbystep2 = 2; break;
                    case 2: Console.WriteLine("\t  ***"); stepbystep2 = 3; break;
                    case 3: Console.WriteLine("\t ****"); stepbystep2 = 4; break;
                    case 4: Console.WriteLine("\t*****"); stepbystep2 = 5; break;
                    case 5: Console.WriteLine("\t ****"); stepbystep2 = 6; break;
                    case 6: Console.WriteLine("\t  ***"); stepbystep2 = 7; break;
                    case 7: Console.WriteLine("\t   **"); stepbystep2 = 8; break;
                    case 8: Console.WriteLine("\t    *"); stepbystep2 = 2; break;
                }

                start++;
            }
        }

        static void StepThree()
        {
            int stepbystep = 1;
            int start = 0;

            while (true)
            {
                if (start == 100000)
                {
                    StepFour();
                    break;
                }
                switch (stepbystep)
                {
                    case 1:
                        Console.Write("\t\t* * * *"); stepbystep = 2; break;
                    case 2:
                        Console.Write("\t\t * * * "); stepbystep = 1; break;
                }
                start++;
            }
        }

        static void StepFour()
        {
            int stepbystep = 1;
            int start = 0;

            while (true)
            {
                if (start == 100000)
                {
                    StepFive();
                    break;
                }
                switch (stepbystep)
                {
                    case 1:
                        Console.Write("* * * *"); stepbystep = 2; break;
                    case 2:
                        Console.Write(" * * * "); stepbystep = 1; break;
                }
                start++;
            }
        }

        static void StepFive()
        {
            int stepbystep = 1;
            int start = 0;

            while (true)
            {
                if (start == 100000)
                {
                    FinalStep();
                    break;
                }
                switch (stepbystep)
                {
                    case 1:
                        Console.Write("*   *  "); stepbystep = 2; break;
                    case 2:
                        Console.Write("   *   "); stepbystep = 1; break;
                }
                start++;
            }
        }

        static void FinalStep()
        {
            int stepbystep = 1;

            while (true)
            {
                switch (stepbystep)
                {
                    case 1: Console.WriteLine(" **** *** ** *"); stepbystep = 2; break;
                    case 2: Console.WriteLine(" *** ** *"); stepbystep = 3; break;
                    case 3: Console.WriteLine(" ** *"); stepbystep = 4; break;
                    case 4: Console.WriteLine(" *"); stepbystep = 5; break;
                    case 5: Console.WriteLine(" ** *"); stepbystep = 6; break;
                    case 6: Console.WriteLine(" *** ** *"); stepbystep = 7; break;
                    case 7: Console.WriteLine(" **** *** ** *"); stepbystep = 1; break;
                }
            }
        }
    }
}
