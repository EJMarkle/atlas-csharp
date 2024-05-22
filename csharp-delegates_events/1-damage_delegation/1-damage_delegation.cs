using System;

/// <summary>
/// Player class
/// </summary>
public class Player
{

    private string name;
    private float maxHp;
    private float hp;
    /// <summary>
    /// Player name
    /// </summary>
    public string Name
    {
        get { return name; }
        private set { name = value; }
    }
    /// <summary>
    /// Max hp
    /// </summary>
    public float MaxHp
    {
        get { return maxHp; }
        private set { maxHp = value; }
    }
    /// <summary>
    /// Player hp
    /// </summary>
    public float Hp
    {
        get { return hp; }
        private set { hp = value; }
    }
    /// <summary>
    /// Delegate for health calculation
    /// </summary>    
    public delegate void CalculateHealth(float amount);
    /// <summary>
    /// Player constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.Name = name;

        if (maxHp > 0)
        {
            this.MaxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.MaxHp = 100f;
        }

        this.Hp = this.MaxHp;
    }
    /// <summary>
    /// Print health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{Name} has {Hp} / {MaxHp} health");
    }
    /// <summary>
    /// Damage handler
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine($"{Name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{Name} takes {damage} damage!");
            Hp = Math.Max(0, Hp - damage);
        }
    }
    /// <summary>
    /// Healing handler
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{Name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{Name} heals {heal} HP!");
            Hp = Math.Min(MaxHp, Hp + heal);
        }
    }
}
