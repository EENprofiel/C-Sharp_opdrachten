namespace C_Sharp_opdrachten.College2;

public class Opdracht4
{
    public class Person
    {
        private static int _instanceCounter = 0;

        public Person()
        {
            _instanceCounter++;
        }

        public static int InstanceCount()
        {
            return _instanceCounter;
        }
    }

    public static void Execute()
    {
        Person person1 = new Person();
        Person person2 = new Person();
        Person person3 = new Person();
        
        Console.WriteLine(Person.InstanceCount());
    }
}