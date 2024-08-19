namespace WhatsNewCSharp8
{
    //ref struct Car : IDisposable
    //{
    //}

    ref struct Car
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose Method Called");
        }
    }
}
