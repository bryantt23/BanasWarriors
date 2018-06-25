using System;

namespace BanasWarriors
{
    class Warrior
    {
        public int HP { get; set; }
        public String Name { get; set; }
        public Warrior Enemy { get; set; }
        public Boolean IsAlive { get; set; }

        public Warrior(String name)
        {
            this.Name = name;
            this.HP = 100;
            this.IsAlive = true;
        }

        public void Attack()
        {
            Random rnd = new Random();
            int AttackPower = rnd.Next(10, 50);
            this.Enemy.HP -= AttackPower;
            if (this.Enemy.HP <= 0)
            {
                Console.WriteLine(this.Name + " has defeated " + this.Enemy.Name);
                this.Enemy.IsAlive = false;
            }
            else
            {
                Console.WriteLine(this.Name + " attack power is " + AttackPower + ". ");
                Console.WriteLine(this.Enemy.Name + " now has " + this.Enemy.HP + " HP");
            }
        }
    }
}
