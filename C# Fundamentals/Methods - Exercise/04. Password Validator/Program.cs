using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool length = true;
            bool lettersAndDigits = true;
            bool sumBool = true;
            int sum = 0;

            if (password.Length >=6 && password.Length <= 10)
            {
                length = true;
            }
            else
            {
                length = false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]) || char.IsLetter(password[i]))
                {
                    lettersAndDigits = true;
                }
                else
                {
                    lettersAndDigits = false;
                    break;
                }
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    sum++;
                }

                if (sum == 2)
                {
                    sumBool = true;
                    break;
                }
                else
                {
                    sumBool = false;
                }
            }

            if (length && lettersAndDigits && sumBool)
            {
                Console.WriteLine("Password is valid");
            }

            if (length == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (lettersAndDigits == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (sumBool == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }
    }
}
