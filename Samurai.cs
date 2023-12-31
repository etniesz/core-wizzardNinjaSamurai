class Samurai : Human
{
    public Samurai(string name) : base(name, 3, 3, 3, 200) { }

    public override int Attack(Human target)
    {
        base.Attack(target);
        if (target.Health < 50)
        {
            target.Health = 0;
            Console.WriteLine($"{Name} acabó con {target.Name}!");
        }
        return target.Health;
    }

    public void Meditate()
    {
        Health = 200;
        Console.WriteLine($"{Name} se ha curado completamente gracias a la meditación");
    }
}