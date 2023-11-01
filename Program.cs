class Program
{
    static void Main(string[] args)
    {
        Wizard wizard = new Wizard("Wizzard");
        Ninja ninja = new Ninja("Ninja");
        Samurai samurai = new Samurai("Samurai");

        wizard.Attack(ninja);
        ninja.Attack(samurai);
        samurai.Attack(wizard);

        wizard.Heal(ninja);
        ninja.Steal(samurai);
        samurai.Meditate();
    }
}
