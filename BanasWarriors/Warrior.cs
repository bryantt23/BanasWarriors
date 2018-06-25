using System;

namespace BanasWarriors
{
    class Warrior
    {
        public String Name { get; set; }
        public int MaxHealth { get; set; }
        public int MaxAttack { get; set; }
        public int MaxBlock { get; set; }
        public Warrior Enemy { get; set; }
        public Boolean IsAlive { get; set; }

        public Warrior(String Name, int MaxHealth, int MaxAttack, int MaxBlock)
        {
            this.Name = Name;
            this.MaxHealth = MaxHealth;
            this.MaxAttack = MaxAttack;
            this.MaxBlock = MaxBlock;
            this.IsAlive = true;
        }

        //Function to get random number
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        public void Attack()
        {
            System.Console.WriteLine(this.Enemy.Name + " has " + this.Enemy.MaxHealth + " HP");
            System.Console.WriteLine(this.Name + " has " + this.MaxHealth + " HP");

            int attackPower = GetRandomNumber(1, this.MaxAttack);
            int blockPower = Block(this.Enemy);
            int enemyBlock = blockPower > MaxAttack ? MaxAttack : blockPower;
            int effectiveAttack = Math.Max(0, attackPower - blockPower);
            this.Enemy.MaxHealth -= effectiveAttack;
            Console.WriteLine(this.Name + " attack power is " + attackPower + ". " + this.Enemy.Name + " block power is " + enemyBlock + ".");
            Console.WriteLine(this.Name + " causes " + effectiveAttack + " damage");
            if (this.Enemy.MaxHealth <= 0)
            {
                Console.WriteLine(this.Name + " has defeated " + this.Enemy.Name);
                this.Enemy.IsAlive = false;
            }
            else
            {
                Console.WriteLine(this.Enemy.Name + " now has " + this.Enemy.MaxHealth + " HP \n");
            }
        }

        public int Block(Warrior warrior)
        {
            int blockPower = GetRandomNumber(1, warrior.MaxBlock);
            return blockPower;
        }
    }
}
