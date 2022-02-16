using AnimalMoviment.Intefaces;

namespace AnimalMoviment.Entities
{
    public class Human : IFeeling<Human>, IMoviment, ISound
    {
        public string Happy() => "There are no happy Humans!";

        public string Sad() => "I am human, after all!";

        public string Talk() => "I am a loud human!";

        public  string Walk() => "I am a walking dead!";
    }
}
