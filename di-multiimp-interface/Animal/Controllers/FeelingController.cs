using AnimalMoviment.Entities;
using AnimalMoviment.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalMoviment.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FeelingController : ControllerBase
    {

        private readonly IFeeling<Dog> _dogFeeling;
        private readonly IFeeling<Cat> _catFeeling;
        private readonly IFeeling<Human> _humanFeeling;
        public FeelingController(IFeeling<Dog> dogFeeling, IFeeling<Cat> catFeeling, IFeeling<Human> humanFeeling)
        {
            _dogFeeling = dogFeeling;
            _catFeeling = catFeeling;
            _humanFeeling = humanFeeling;
        }

        [HttpGet]
        public string GetHappyCat()
        {
            return _catFeeling.Happy();
        }
        [HttpGet]
        public string GetSadCat()
        {
            return _catFeeling.Sad();
        }

        [HttpGet]
        public string GetHappyDog()
        {
            return _dogFeeling.Happy();
        }
        [HttpGet]
        public string GetSadDog()
        {
            return _dogFeeling.Sad();
        }

        [HttpGet]
        public string GetHappyHuman()
        {
            return _humanFeeling.Happy();
        }
        [HttpGet]
        public string GetSadHuman()
        {
            return _humanFeeling.Sad();
        }
    }
}
