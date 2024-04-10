using System;

namespace FinalProject.MyClasses
{
    public class Utils
    {
        public static bool IsInformationCorrect()
        {
            Console.WriteLine("Is all the information correct? (Y/N)");
            string response = Console.ReadLine().ToUpper();
            return response == "Y";
        }
    }
}
