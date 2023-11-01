class Wizard : Human
{
    public Wizard(string name) : base(name, 3, 25, 3, 50) { }

    public override int Attack(Human target)
    {
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} atacó a {target.Name} causando {dmg} de daño y se curo {dmg}");
        return target.Health;
    }

    public void Heal(Human target)
    {
        int healAmount = Intelligence * 3;
        target.Health += healAmount;
        Console.WriteLine($"{Name} curó a {target.Name} por {healAmount} de HP");
    }
}