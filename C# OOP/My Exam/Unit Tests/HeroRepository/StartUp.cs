public class StartUp
{
    static void Main(string[] args)
    {
        var hero = new Hero("Dinko", 23);
        var herorep = new HeroRepository();
        herorep.Create(hero);
        herorep.Remove(null);
    }
}
