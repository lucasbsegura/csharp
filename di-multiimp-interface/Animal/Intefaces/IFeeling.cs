namespace AnimalMoviment.Intefaces
{
    public interface IFeeling<T> where T : class
    {
        string Happy();
        string Sad();

    }
}
