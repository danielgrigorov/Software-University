using System;
using System.Linq;

namespace Guild
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Guild guild = new Guild("dobrin", 22);

            Player dinko = new Player("dinko", "nqkuvclass");

            guild.AddPlayer(dinko);
        }
    }
}
