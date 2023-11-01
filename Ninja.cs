class Ninja : Human
{
    public Ninja(string name) : base(name, 3, 3, 75, 100) { }

    public override int Attack(Human target)
    {
        int dmg = Dexterity;
        if (new Random().Next(0, 100) < 20)
        {
            dmg += 10;
            Console.WriteLine("Golpe Crítico");
        }
        target.Health -= dmg;
        Console.WriteLine($"{Name} atacó a {target.Name} causando {dmg} de daño!");
        return target.Health;
    }

    public void Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;
        Console.WriteLine($"{Name} robó 5 puntos de HP de {target.Name}!");
    }
}