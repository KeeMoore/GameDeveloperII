namespace GameDeveloperI.Classes;

public class MagicCaster : Enemy
{
    private Dictionary<string, string> attackMessages = new Dictionary<string, string>
    {
        { "Fireball", "casts a blazing fireball!" },
        { "Lightning Bolt", "summons a bolt of lightning!" },
        { "Staff Strike", "strikes with their staff!" }
    };
    public MagicCaster(string name) : base(name, 80)
    {
        AttackList.Add(new Attack("Fireball", 25));
        AttackList.Add(new Attack("Lightning Bolt", 20));
        AttackList.Add(new Attack("Staff Strike", 10));
    }

    public new void PerformAttack(Enemy target, Attack chosenAttack)
    {
        base.PerformAttack(target, chosenAttack);
        if (attackMessages.ContainsKey(chosenAttack.Name))
        {
            Console.WriteLine($"{Name} {attackMessages[chosenAttack.Name]}");
        }
    }

    public void Heal(Enemy target)
    {
        target.Health += 40;
        if (target.Health > target.MaxHealth)
        {
            target.Health = target.MaxHealth;
        }
        Console.WriteLine($"{Name} heals {target.Name}, increasing their health to {target.Health}.");
    }
}

