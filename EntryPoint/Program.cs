using System.Threading.Channels;
using Curs69OOP.AnimalsProject;
using Curs69OOP.BookProject;
using Curs69OOP.PersonProject;

public class Program
{
    public static void Main(string[] args)
    {
        Book book = new Book("Harry Potter", "J.K. Rowling", 387, 73, false);

        Console.WriteLine(book);
        book.Open();
        book.Close();
        book.Open();
        book.SkipPagesForward(10);
        book.ShowCurrentPage();
        book.SkipPagesBack(10);
        book.ShowCurrentPage();
        book.SkipPagesBack(100);
        book.ShowCurrentPage();
        book.SkipPagesForward(400);
        book.ShowCurrentPage();
        book.SkipPagesForward(600);
        book.ShowCurrentPage();


        Console.WriteLine("------------ANIMALS----------");

        Cat cat = new Cat("birmanese", "Black");
        Dog dog = new Dog("Pitbull", "Orange");
        Eagle eagle = new Eagle("Aquila", "Brown");
        Pigeon pigeon = new Pigeon("Rock dove", "Grey");

        Console.WriteLine(cat);
        Console.WriteLine(dog);
        Console.WriteLine(eagle);
        Console.WriteLine(pigeon);

        cat.Run();
        dog.Run();
        eagle.Fly();
        pigeon.Fly();

        List<Animal> animals = new List<Animal>{cat, dog, eagle, pigeon};

        foreach (var anm in animals)
        {
            Console.WriteLine(anm);
        }



        Console.WriteLine("--------PERSON PROJECT----------");

        Person person = new Person("Popescu", "Jonny", 43, new Laptop("Asus", "Black", 1200),
            new Phone("Iphone 14 Pro Max", "White", 1400));

        Console.WriteLine(person);
    }

}