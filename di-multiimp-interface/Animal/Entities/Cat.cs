using AnimalMoviment.Intefaces;

namespace AnimalMoviment.Entities
{
    public class Cat : IFeeling<Cat>, IMoviment, ISound
    {
        public string Happy() => "I am a happy Cat!";

        public string Sad() => "I am a sad Cat!";
        
        public string Talk() => "I am a Cat, meowing!";

        public  string Walk() => "I am a Cat, walking!";
    }
}
