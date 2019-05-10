using System;
using System.Linq;

namespace GroupEnrollmentHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Hello from GroupEnrollmentHelper");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            if (args.Count() == 2)
            {
                var masterKey = args.First();
                var registrationId = args.Last();
                
                byte[] masterKeyBytes = Convert.FromBase64String(masterKey);

                Console.WriteLine("Computing derived Key...");

                string derivedKey = Utils.ComputeDerivedSymmetricKey(masterKeyBytes, registrationId);

                Console.WriteLine("Derived key calcualted...");
                Console.WriteLine();
                Console.WriteLine(derivedKey);
            }
            else
            {
                Console.WriteLine("You need to provide your masterKey and registratioId as command parameters.");
                Console.WriteLine("GroupEnrollmentHelper <masterKey> <registrationID>");
            }

            Console.WriteLine();
        }
    }
}
