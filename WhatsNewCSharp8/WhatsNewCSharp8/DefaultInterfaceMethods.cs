namespace WhatsNewCSharp8
{
    class Ferrari : ICar
    {
        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }

    interface ICar
    {
        public void Start() => Console.WriteLine("Car has started");
        public void Run();
        public void Run(double carSpeed) => Console.WriteLine($"Car is running at {carSpeed}");
    }
}
