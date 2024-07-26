namespace GameDeveloperI.Classes;

public class MeleeFighter : Enemy
{
    public MeleeFighter(string name) : base(name)
    {
        Health = 120;
        AttackList.Add(new Attack("Punch", 20));
        AttackList.Add(new Attack("Kick", 15));
        AttackList.Add(new Attack("Tackle", 25));
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

