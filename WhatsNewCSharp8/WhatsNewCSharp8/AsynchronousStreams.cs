namespace WhatsNewCSharp8
{
    public class AsynchronousStreams
    {
        public async Task Run()
        {
            foreach (var p in GetProducts()) 
            { 
                Console.WriteLine(p);
            }
            Console.WriteLine("-------------------");
            await foreach (var p in GetProductsAsync())
            {
                Console.WriteLine(p);
            }
        }

        static IEnumerable<string> GetProducts()
        {
            yield return "Getting Products...";
            yield return "Product 1";
            yield return "Product 2";
            yield return "Product 3";
        }

        static async IAsyncEnumerable<string> GetProductsAsync()
        {
            yield return "Getting Products...";
            await Task.Delay(2000);
            yield return "Product 1";
            await Task.Delay(2000);
            yield return "Product 2";
            await Task.Delay(2000);
            yield return "Product 3";
        }
    }
}
