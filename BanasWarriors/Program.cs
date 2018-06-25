namespace BanasWarriors
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior1 = new Warrior("Steve");
            Warrior warrior2 = new Warrior("Tony");

            warrior1.Enemy = warrior2;
            warrior2.Enemy = warrior1;

            while (true)
            {
                warrior1.Attack();
                if (!warrior2.IsAlive)
                {
                    break;
                }
                warrior2.Attack();
                if (!warrior1.IsAlive)
                {
                    break;
                }
            }
        }
    }
}
