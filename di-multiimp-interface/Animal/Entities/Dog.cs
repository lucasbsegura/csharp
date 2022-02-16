using AnimalMoviment.Intefaces;

namespace AnimalMoviment.Entities
{
    public class Dog : IFeeling<Dog>, IMoviment, ISound
    {
        public string Happy() => "I am a happy Dog!";

        public string Sad() => "I am a sad Dog!";

        public string Talk() => "I am a Dog, barking!";

        public string Walk() => "I am a Dog, walking!";
    }
}
