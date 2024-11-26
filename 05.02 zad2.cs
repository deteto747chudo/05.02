using System;

public class Animal
{
	public string Name { get; protected set; }
	public string FavouriteFood {get; protected set; }
	public virtual string ExplainMyself()
	{
		return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
	}
}

public class Cat : Animal
{
	public Cat(string name, string favouriteFood)
	{
		this.Name = name;
		this.FavouriteFood = favouriteFood;
	}
	public override string ExplainMyself()
	{
		return base.ExplainMyself() + Environment.NewLine + "MEOW";
	}
}

public class Dog : Animal
{
	public Dog(string name, string favouriteFood)
	{
		this.Name = name;
		this.FavouriteFood = favouriteFood;
	}
	public override string ExplainMyself()
	{
		return base.ExplainMyself() + Environment.NewLine + "BAU BAU";
	}
}
public class Program
{
	public static void Main()
	{
		Animal cat = new Cat("Pesho", "Whiskas");
		Animal dog = new Dog("Gosho", "Meat"); 
		
		Console.WriteLine(cat.ExplainMyself()); 
		Console.WriteLine(dog.ExplainMyself());
	}
}