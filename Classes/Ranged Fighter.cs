namespace GameDeveloperI.Classes;

public class RangedFighter : Enemy
{
    private Dictionary<string, string> attackMessages = new Dictionary<string, string>
    {
        { "Shoot an Arrow", "shoots an arrow with precision!" },
        { "Throw a Knife", "throws a knife swiftly!" }
    };
    public int Distance { get; set; }

    public RangedFighter(string name) : base(name)
    {
        Health = 100;
        Distance = 5;
        AttackList.Add(new Attack("Shoot an Arrow", 20));
        AttackList.Add(new Attack("Throw a Knife", 15));
    }

    public new void PerformAttack(Enemy target, Attack chosenAttack)
    {
        if (Distance < 10)
        {
            Console.WriteLine($"{Name} is too close to perform a ranged attack!");
        }
        else
        {
            base.PerformAttack(target, chosenAttack);
            if (attackMessages.ContainsKey(chosenAttack.Name))
            {
                Console.WriteLine($"{Name} {attackMessages[chosenAttack.Name]}");
            }
        }
    }

    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"{Name} dashes away, increasing distance to {Distance}.");
    }
}
