namespace WhatsNewCSharp8
{
    public class Resource : IDisposable
    {
        public void Use() => Console.WriteLine("Using Reosource...");
        public void Dispose() => Console.WriteLine("Disposing Resource...");
    }
}
