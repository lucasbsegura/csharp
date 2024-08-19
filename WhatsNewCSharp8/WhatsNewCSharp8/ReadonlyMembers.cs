namespace WhatsNewCSharp8
{
    public struct PointReadOnly
    {
        public int X { get; set; }
        public int Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public readonly string DisplayPosition() => $"({X},{Y}) is {Distance} from origin";

        //public PointReadOnly(int x, int y) => (X, Y) = (x, y);
        //public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }
}
