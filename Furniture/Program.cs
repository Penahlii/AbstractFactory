public interface Chair
{
    void HasLegs();
    void SitOn();
}

public interface Sofa
{
    void Bend();
}

public interface CoffeeTable
{
    void HasCoffee();
}


public interface FurnitereFactory
{
    Chair CreateChair();
    Sofa CreateSofa();
    CoffeeTable CreateCoffeeTable();
}

public class ArtDecoChair : Chair
{
    public void HasLegs()
    {
        Console.WriteLine("Has Legs");
    }

    public void SitOn()
    {
        Console.WriteLine("Sit On");
    }
}

public class VictorianChair : Chair
{
    public void HasLegs()
    {
        Console.WriteLine("Has Legs");
    }

    public void SitOn()
    {
        Console.WriteLine("Sit On");
    }
}

public class ModernChair : Chair
{
    public void HasLegs()
    {
        Console.WriteLine("Has Legs");
    }

    public void SitOn()
    {
        Console.WriteLine("Sit On");
    }
}

public class ArtDecoSofa : Sofa
{
    public void Bend()
    {
        Console.WriteLine("Bend");
    }
}

public class VictorianSofa : Sofa
{
    public void Bend()
    {
        Console.WriteLine("Bend");
    }
}

public class ModernSofa : Sofa
{
    public void Bend()
    {
        Console.WriteLine("Bend");
    }
}

public class ArtDecoCoffeeTable : CoffeeTable
{
    public void HasCoffee()
    {
        Console.WriteLine("Has Coffee");
    }
}

public class VictorianCoffeeTable : CoffeeTable
{
    public void HasCoffee()
    {
        Console.WriteLine("Has Coffee");
    }
}

public class ModernCoffeeTable : CoffeeTable
{
    public void HasCoffee()
    {
        Console.WriteLine("Has Coffee");
    }
}

public class ArtDecoFunritureFactory : FurnitereFactory
{
    public Chair CreateChair()
    {
        return new ArtDecoChair();
    }

    public CoffeeTable CreateCoffeeTable()
    {
        return new ArtDecoCoffeeTable();
    }

    public Sofa CreateSofa()
    {
        return new ArtDecoSofa();
    }
}

public class VictorianFurnitureFactory : FurnitereFactory
{
    public Chair CreateChair()
    {
        return new VictorianChair();
    }

    public CoffeeTable CreateCoffeeTable()
    {
        return new VictorianCoffeeTable();
    }

    public Sofa CreateSofa()
    {
        return new VictorianSofa();
    }
}

public class ModernFurnitureFactory : FurnitereFactory
{
    public Chair CreateChair()
    {
        return new ModernChair();
    }

    public CoffeeTable CreateCoffeeTable()
    {
        return new ModernCoffeeTable();
    }

    public Sofa CreateSofa()
    {
        return new ModernSofa();
    }
}