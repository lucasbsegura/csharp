using AnimalMoviment.Entities;
using AnimalMoviment.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AnimalMoviment.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SoundController : ControllerBase
    {

        private readonly ISound _dogSound;
        private readonly ISound _catSound;
        private readonly ISound _humanSound;
        public SoundController(IEnumerable<ISound> sound)
        {
            _dogSound = sound.SingleOrDefault(s => s.GetType() == typeof(Dog));
            _catSound = sound.SingleOrDefault(s => s.GetType() == typeof(Cat));
            _humanSound = sound.ElementAt(1);
        }

        [HttpGet]
        public string GetCat()
        {
            return _catSound.Talk();
        }

        [HttpGet]
        public string GetDog()
        {
            return _dogSound.Talk();
        }

        [HttpGet]
        public string GetHuman()
        {
            return _humanSound.Talk();
        }

    }
}
