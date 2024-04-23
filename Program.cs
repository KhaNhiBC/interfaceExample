internal class Program
{
    private static void Main(string[] args)
    {
       Fish fishyelow = new Fish();
       /* fishyelow.Attack();
       fishyelow.Eat();
       fishyelow.Swim(); */
       Ianimal fishred = new Fish();
       fishred.Eat();

       Iwater fishgreen = new Fish();
       fishgreen.Swim();

       Iattack fishblue = new Fish();
       fishblue.Attack();

    }
}
public abstract class CatSmall()
{
    public abstract string HowtoEat ();
}

public interface Ianimal
{
    void Eat();
}
public interface Iwater
{
    void Swim();
}
public interface Iattack
{
    void Attack();
}
public class Fish : Ianimal, Iwater, Iattack
{
    public void Attack()
    {
        Console.WriteLine("Attack");
    }

    public void Eat()
    {
        Console.WriteLine("an Reu");
    }

    public void Swim()
    {
        Console.WriteLine("Boi");
    }
}
public class Cat : CatSmall
{
    public override string HowtoEat()
    {
        throw new NotImplementedException();
    }
}
public class Charfish : CatSmall, Ianimal
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public override string HowtoEat()
    {
        throw new NotImplementedException();
    }
}