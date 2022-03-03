using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.ShoppingSpree
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            try
            {
                Engine engine = new Engine();

                engine.Run();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            

            
        }
    }
}
