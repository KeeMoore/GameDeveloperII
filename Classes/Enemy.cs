namespace GameDeveloperI.Classes;
public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Attack> AttackList { get; set; }
    public int MaxHealth { get; set; }

    public Enemy(string name, int maxHealth = 100)
    {
        Name = name;
        Health = maxHealth;
        MaxHealth = MaxHealth;
        AttackList = new List<Attack>();
    }
    public void PerformAttack(Enemy target, Attack chosenAttack)
    {
        target.Health -= chosenAttack.DamageAmount;
        if (target.Health < 0)
        {
            target.Health = 0;
        }

        Console.WriteLine($"{Name} attacks {target.Name}, dealing {chosenAttack.DamageAmount} damage and reducing {target.Name}'s health to {target.Health}!!");
    }

    public Attack? RandomAttack()
    {
        if (AttackList.Count == 0)
        {
            return null;
        }

        Random random = new Random();
        int index = random.Next(AttackList.Count);
        return AttackList[index];
    }
}
