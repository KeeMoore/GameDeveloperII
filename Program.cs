// See https://aka.ms/new-console-template for more information
using GameDeveloperI.Classes;


public class Program
{
    public static void Main(string[] args)
    {
        // Create instances of Attack
        Attack fireball = new Attack("Fireball", 25);
        Attack punch = new Attack("Punch", 20);
        Attack throwAttack = new Attack("Throw", 15);

        // Create instances of Enemy subclasses
        MeleeFighter meleeFighter = new MeleeFighter("Melee Fighter");
        RangedFighter rangedFighter = new RangedFighter("Ranged Fighter");
        MagicCaster magicCaster = new MagicCaster("Magic Caster");

        // Perform the Kick Attack from MeleeFighter on RangedFighter
        meleeFighter.PerformAttack(rangedFighter, new Attack("Kick", 15));

        // Perform the Rage method from MeleeFighter on MagicCaster
        meleeFighter.Rage(magicCaster);

        // Perform the Shoot an Arrow Attack from RangedFighter on MeleeFighter (should fail due to distance)
        rangedFighter.PerformAttack(meleeFighter, new GameDeveloperI.Classes.Attack("Shoot an Arrow", 20));

        // Have RangedFighter perform the Dash method
        rangedFighter.Dash();

        // Perform another Shoot an Arrow Attack from RangedFighter (should succeed now)
        rangedFighter.PerformAttack(meleeFighter, new Attack("Shoot an Arrow", 20));

        // Perform a Fireball Attack from MagicCaster on MeleeFighter
        magicCaster.PerformAttack(meleeFighter, new Attack("Fireball", 25));

        // Have MagicCaster perform the Heal method on RangedFighter
        magicCaster.Heal(rangedFighter);

        // Have MagicCaster perform the Heal method on themselves
        magicCaster.Heal(magicCaster);
    }
}


