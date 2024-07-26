namespace GameDeveloperI.Classes;

public class MeleeFighter : Enemy
{
    private Dictionary<string, string> attackMessages = new Dictionary<string, string>
    {
        { "Punch", "delivers a powerful punch!" },
        { "Kick", "kicks with great force!" },
        { "Tackle", "tackles the opponent precisely!" }
    };
    public MeleeFighter(string name) : base(name, 120)
    {
        AttackList.Add(new Attack("Punch", 20));
        AttackList.Add(new Attack("Kick", 15));
        AttackList.Add(new Attack("Tackle", 25));
        {
            // Console.WriteLine($"{Name} You're going to get it NOW, Take This!");
        }
    }
    public new void PerformAttack(Enemy target, Attack chosenAttack)
    {
        base.PerformAttack(target, chosenAttack);
        if (attackMessages.ContainsKey(chosenAttack.Name))
        {
            Console.WriteLine($"{Name} {attackMessages[chosenAttack.Name]}");
        }
    }


    public void Rage(Enemy target)
    {
        Attack? randomAttack = RandomAttack();
        if (randomAttack != null)
        {
            randomAttack.DamageAmount += 10;
            PerformAttack(target, randomAttack);
            randomAttack.DamageAmount -= 10; // Reset the damage amount
        }
    }

}

