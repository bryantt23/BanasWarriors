namespace BanasWarriors
{
    static class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            warrior1.Enemy = warrior2;
            warrior2.Enemy = warrior1;

            //System.Console.WriteLine(warrior1.Name+ " has "+warrior1.MaxHealth+" HP");
            //System.Console.WriteLine(warrior2.Name + " has " + warrior2.MaxHealth + " HP");

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
