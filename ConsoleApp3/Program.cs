namespace class_Worker
{
    abstract class Worker
    {
        public abstract void Print();
    }

    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am the president");
        }
    }

    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am a security guard");
        }
    }

    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am a manager");
        }
    }

    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am an engineer");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Worker president = new President();
            president.Print();

            Worker security = new Security();
            security.Print();

            Worker manager = new Manager();
            manager.Print();

            Worker engineer = new Engineer();
            engineer.Print();
        }
    }
}
