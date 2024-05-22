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
    /// PLayer name
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
    /// Player hp getter n setter
    /// </summary>
    public float Hp
    {
        get { return hp; }
        private set { hp = value; }
    }
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
    /// Print player health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{Name} has {Hp} / {MaxHp} health");
    }
}