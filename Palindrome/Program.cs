using System;
using Domain;
using Microsoft.Practices.Unity;

namespace Palindrome
{
    class Program
    {
        private IPalindromeDomain _palindromeDomain;

        public Program()
        {
            SetupIOC();
        }

        public Program(IPalindromeDomain palindromeDomain) : base()
        {
            _palindromeDomain = palindromeDomain;

        }

        static void Main(string[] args)
        {
            string testString = "Noel sees Leon";
            if (args.Length > 0)
            {
                testString = args[0];
            }
            else
            {
                Console.WriteLine(string.Format("Since you didn't enter a parameter we will use the default {0}", testString));
            }

            //Only because this is a console app and the starting method is static. We have to do this to start the IoC container.
            //Could avoid using Unity and just create new instance in constructor.
            var main = new Program();
            var result = main._palindromeDomain.IsPalindrome(testString);
            Console.WriteLine("Is the input a palindrome: " + result);
        }


        public void SetupIOC()
        {
            var container = new UnityContainer();
            container.RegisterType<IPalindromeDomain, PalindromeDomain>();
            _palindromeDomain = container.Resolve<PalindromeDomain>();
        }
    }

   
}
